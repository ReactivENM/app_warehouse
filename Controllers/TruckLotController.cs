using System.Collections.Generic;
using Models;

namespace Controllers.TruckLotController
{
    public class TruckLotController
    {
        private TruckLotModel model;

        public TruckLotController()
        {
            TruckLotModel packageModel = new TruckLotModel();
            model = packageModel;
        }

        public List<LotModel> GetAllLots()
        {
            return model.GetAllLots();
        }

        public List<LotModel> GetTruckLots(int id_truck)
        {
            return model.GetTruckLots(id_truck);
        }

        public bool AssignToTruck(int id_camion, int id_lote)
        {
            return model.AssignToTruck(id_camion, id_lote);
        }

        public bool UnassignFromTruck(int id_lote)
        {
            return model.UnassignFromTruck(id_lote);
        }
    }
}
