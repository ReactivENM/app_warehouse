using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Configuration;
using Models;

namespace Models
{
    public class TruckLotModel
    {
        public int id { get; set; }
        public int id_camion { get; set; }
        public int id_lote { get; set; }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public TruckLotModel()
        {

        }

        public TruckLotModel(int id, int id_camion, int id_lote) : this()
        {
            this.id = id;
            this.id_camion = id_camion;
            this.id_lote = id_lote;
        }

        public List<LotModel> GetAllLots()
        {
            List<LotModel> data = new List<LotModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/lot/unassigned");
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

        public List<LotModel> GetTruckLots(int id_camion)
        {
            List<LotModel> data = new List<LotModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/lot/assigned/{id_camion}");
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

        public bool AssignToTruck(int id_camion, int id_lote)
        {
            try
            {
                var data = new { IdCamion = id_camion, IdLote = id_lote };
                RestClient client = new RestClient($"{apiUrl}/lot/assign");
                RestRequest request = new RestRequest(Method.POST);
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

        public bool UnassignFromTruck(int id_lote)
        {
            try
            {
                RestClient client = new RestClient($"{apiUrl}/lot/unassign/{id_lote}");
                RestRequest request = new RestRequest(Method.POST);
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
