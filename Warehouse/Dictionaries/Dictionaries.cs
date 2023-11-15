﻿using System.Collections.Generic;
using Models;
using Controllers.WareHouseController;
using Controllers.ClientController;

namespace Warehouse.Dictionary
{
    class Dictionaries
    {
        public Dictionary<string, string> Departments()
        {
            Dictionary<string, string> departments = new Dictionary<string, string>();
            departments.Add("montevideo", "Montevideo");
            departments.Add("canelones", "Canelones");
            departments.Add("maldonado", "Maldonado");
            departments.Add("lavalleja", "Lavalleja");
            departments.Add("florida", "Florida");
            departments.Add("san_jose", "San José");
            departments.Add("colonia", "Colonia");
            departments.Add("flores", "Flores");
            departments.Add("rio_negro", "Rio Negro");
            departments.Add("paysandu", "Paysandu");
            departments.Add("salto", "Salto");
            departments.Add("tacuarembo", "Tacuarembo");
            departments.Add("cerro_largo", "Cerro Largo");
            departments.Add("durazno", "Durazno");

            return departments;
        }

        public Dictionary<string, string> DepartmentByWarehouseID()
        {
            Dictionary<string, string> departments = new Dictionary<string, string>();
            departments.Add("montevideo", "Montevideo");
            departments.Add("canelones", "Canelones");
            departments.Add("maldonado", "Maldonado");
            departments.Add("lavalleja", "Lavalleja");
            departments.Add("florida", "Florida");
            departments.Add("san_jose", "San José");
            departments.Add("colonia", "Colonia");
            departments.Add("flores", "Flores");
            departments.Add("rio_negro", "Rio Negro");
            departments.Add("paysandu", "Paysandu");
            departments.Add("salto", "Salto");
            departments.Add("tacuarembo", "Tacuarembo");
            departments.Add("cerro_largo", "Cerro Largo");
            departments.Add("durazno", "Durazno");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            WareHouseController controller = new WareHouseController();
            List<WareHouseModel> warehouses = controller.GetAll();
            foreach (WareHouseModel warehouse in warehouses)
            {
                dictionary.Add(warehouse.id.ToString(), departments.ContainsKey(warehouse.departamento) ? departments[warehouse.departamento] : warehouse.departamento);
            }

            return dictionary;
        }

        public Dictionary<string, string> PackageStatus()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("en_espera", "En espera");
            dictionary.Add("en_viaje", "En viaje");
            dictionary.Add("entregado", "Entregado");

            return dictionary;
        }

        public Dictionary<string, string> ClientName()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            ClientController controller = new ClientController();
            List<ClientModel> clients = controller.GetAll();
            dictionary.Add("", "Sin seleccionar");
            foreach (ClientModel client in clients)
            {
                dictionary.Add(client.id.ToString(), client.nombre);
            }

            return dictionary;
        }
    }
}
