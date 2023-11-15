using System;
using System.Collections.Generic;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{
    public class ClientModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string calle { get; set; }
        public string telefono { get; set; }

        public ClientModel()
        {

        }

        public ClientModel(int id, string nombre, string calle, string telefono) : this()
        {
            this.id = id;
            this.nombre = nombre;
            this.calle = calle;
            this.telefono = telefono;
        }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public List<ClientModel> GetAll()
        {
            List<ClientModel> data = new List<ClientModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/client");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    List<ClientModel> responseBody = JsonConvert.DeserializeObject<List<ClientModel>>(response.Content);

                    foreach (ClientModel item in responseBody)
                    {
                        data.Add(item);
                    }

                    return data;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
