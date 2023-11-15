using System;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json;
using Models;

namespace Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string correo { get; set; }
        public string rol { get; set; }

        public UserModel()
        {

        }

        public UserModel(int id, string correo, string rol): this()
        {
            this.id = id;
            this.correo = correo;
            this.rol = rol;
        }

        public (bool success, string msg, UserModel user) Login(string correo, string contrasena)
        {
            string apiUrl = $"{ConfigurationSettings.AppSettings["AUTH_URI"]}/login";

            var data = new { correo, contrasena };
            RestClient client = new RestClient(apiUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddJsonBody(data);
            IRestResponse response = client.Execute(request);
            if(response.IsSuccessful)
            {
                string responseBody = response.Content;
                UserModel responseObject = JsonConvert.DeserializeObject<UserModel>(responseBody);
                if(responseObject == null)
                {
                    return (false, "Hubo un error en la petición", new UserModel());
                }

                if (responseObject.rol != "almacenero")
                {
                    return (false, "No tienes los permisos necesarios para acceder a esta aplicación", new UserModel());
                }

                return (true, "", responseObject);
            }
            return (false, "Usuario o contraseña incorrecto", new UserModel());
        }
    }
}