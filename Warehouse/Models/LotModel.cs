using System;
using System.Configuration;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace Models
{
    public class LotModel
    {
        public int id { get; set; }
        public int id_almacen { get; set; }
        public string estado { get; set; }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public LotModel()
        {

        }

        public LotModel(int id, int id_almacen, string estado) : this()
        {
            this.id = id;
            this.id_almacen = id_almacen;
            this.estado = estado;
        }

        public List<LotModel> GetAll()
        {
            List<LotModel> data = new List<LotModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/lot");
                RestRequest request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    List<LotModel> responseBody = JsonConvert.DeserializeObject<List<LotModel>>(response.Content);

                    foreach (LotModel item in responseBody)
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

        public int Create(int id_almacen, string estado)
        {
            try
            {
                var data = new { IdAlmacen = id_almacen, estado };
                RestClient client = new RestClient($"{apiUrl}/lot");
                RestRequest request = new RestRequest(Method.POST);
                request.AddJsonBody(data);
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    string responseBody = response.Content;
                    LotModel responseObject = JsonConvert.DeserializeObject<LotModel>(responseBody);
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

        public bool Edit(int id, int id_almacen, string estado)
        {
            try
            {
                var data = new { IdAlmacen = id_almacen, Estado = estado };
                RestClient client = new RestClient($"{apiUrl}/lot/{id}");
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
                RestClient client = new RestClient($"{apiUrl}/lot/{id}");
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