using System;
using System.Collections.Generic;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{
    public class WareHouseModel
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string calle { get; set; }
        public string nropuerta { get; set; }
        public string codpostal { get; set; }
        public int capacidad { get; set; }
        public string departamento { get; set; }

        public WareHouseModel()
        {

        }

        public WareHouseModel(int id, string descripcion, string calle, string nropuerta, string codpostal, int capacidad, string departamento) : this()
        {
            this.id = id;
            this.descripcion = descripcion;
            this.calle = calle;
            this.nropuerta = nropuerta;
            this.codpostal = codpostal;
            this.capacidad = capacidad;
            this.departamento = departamento;
        }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public List<WareHouseModel> GetAll()
        {
            List<WareHouseModel> data = new List<WareHouseModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/warehouse");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    List<WareHouseModel> responseBody = JsonConvert.DeserializeObject<List<WareHouseModel>>(response.Content);

                    foreach (WareHouseModel item in responseBody)
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
