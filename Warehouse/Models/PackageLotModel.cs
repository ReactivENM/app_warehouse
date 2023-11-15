using System;
using System.Globalization;
using System.Collections.Generic;
using Models;
using RestSharp;
using Newtonsoft.Json;
using System.Configuration;

namespace Models
{
    public class PackageLotModel
    {
        public string id_externo_paquete { get; set; }
        public int id_lote { get; set; }
        public string usuario { get; set; }
        public string fecha_hora { get; set; }

        private string apiUrl = $"{ConfigurationSettings.AppSettings["WAREHOUSE_URI"]}";

        public PackageLotModel()
        {

        }

        public PackageLotModel(string id_externo_paquete, int id_lote, string usuario, string fecha_hora) : this()
        {
            this.id_externo_paquete = id_externo_paquete;
            this.id_lote = id_lote;
            this.usuario = usuario;
            this.fecha_hora = fecha_hora;
        }

        public List<PackageModel> GetAllPackages()
        {
            List<PackageModel> data = new List<PackageModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/package/unassigned");
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
                Console.WriteLine(ex);
                return null;
            }
        }

        public List<PackageModel> GetLotPackages(int id_lote)
        {
            List<PackageModel> data = new List<PackageModel>();

            try
            {
                RestClient client = new RestClient($"{apiUrl}/lot/packages/{id_lote}");
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
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool AssignToLot(string id_externo_paquete, int id_lote, int id_usuario)
        {
            try
            {
                var data = new { IdPaquete = id_externo_paquete, IdLote = id_lote, IdUsuario = id_usuario };
                RestClient client = new RestClient($"{apiUrl}/package/assign");
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

        public bool UnassignFromLot(string id_externo_paquete)
        {
            try
            {
                RestClient client = new RestClient($"{apiUrl}/package/unassign/{id_externo_paquete}");
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
