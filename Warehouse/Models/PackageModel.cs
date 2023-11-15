using System;
using System.Configuration;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{
    public class PackageModel
    {
        public int id { get; set; }
        public string id_externo { get; set; }
        public int id_cliente { get; set; }
        public string peso { get; set; }
        public string dir_envio { get; set; }
        public string estado { get; set; }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public PackageModel()
        {

        }

        public PackageModel(int id_interno, string id_externo, int id_cliente, string peso, string dir_envio, string estado) : this()
        {
            this.id = id_interno;
            this.id_externo = id_externo;
            this.id_cliente = id_cliente;
            this.peso = peso;
            this.dir_envio = dir_envio;
            this.estado = estado;
        }

        public List<PackageModel> GetAll()
        {
            List<PackageModel> data = new List<PackageModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/package");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    List<PackageModel> responseBody = JsonConvert.DeserializeObject<List<PackageModel>>(response.Content);

                    foreach (PackageModel item in responseBody)
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

        public int Create(string id_externo, int id_cliente, double peso, string dir_envio, string estado)
        {
            try
            {
                var data = new { IdExterno = id_externo, IdCliente = id_cliente, peso, DirEnvio = dir_envio, estado };
                RestClient client = new RestClient($"{apiUrl}/package");
                RestRequest request = new RestRequest(Method.POST);
                request.AddJsonBody(data);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string responseBody = response.Content;
                    PackageModel responseObject = JsonConvert.DeserializeObject<PackageModel>(responseBody);
                    if (responseObject == null)
                    {
                        return 0;
                    }

                    return responseObject.id;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool Edit(int id, string id_externo, int id_cliente, double peso, string dir_envio, string estado)
        {
            try
            {
                var data = new { IdExterno = id_externo, IdCliente = id_cliente, peso, DirEnvio = dir_envio, estado };
                RestClient client = new RestClient($"{apiUrl}/package/{id}");
                RestRequest request = new RestRequest(Method.PUT);
                request.AddJsonBody(data);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return true;
                }
                return false; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                RestClient client = new RestClient($"{apiUrl}/package/{id}");
                RestRequest request = new RestRequest(Method.DELETE);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
