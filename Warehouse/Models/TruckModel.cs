using System;
using System.Configuration;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{

    public class TruckModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string matricula { get; set; }
        public double capacidad { get; set; }

        public TruckModel()
        {

        }

        public TruckModel(int id, string marca, string modelo, string matricula, string capacidad) : this()
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.capacidad = double.Parse(capacidad);
        }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public List<TruckModel> GetAll()
        {
            List<TruckModel> data = new List<TruckModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/truck");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    List<TruckModel> responseBody = JsonConvert.DeserializeObject<List<TruckModel>>(response.Content);

                    foreach (TruckModel item in responseBody)
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
