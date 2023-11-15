using System.Collections.Generic;
using Models;

namespace Controllers.PackageLotController
{
    public class PackageLotController
    {
        private PackageLotModel model;

        public PackageLotController()
        {
            PackageLotModel packageModel = new PackageLotModel();
            model = packageModel;
        }

        public List<PackageModel> GetAllPackages(int id_lote)
        {
            return model.GetAllPackages();
        }

        public List<PackageModel> GetLotPackages(int id_lote)
        {
            return model.GetLotPackages(id_lote);
        }

        public bool AssignToLot(string id_externo_paquete, int id_lote, int id_usuario)
        {
            return model.AssignToLot(id_externo_paquete, id_lote, id_usuario);
        }

        public bool UnassignFromLot(string id_paquete)
        {
            return model.UnassignFromLot(id_paquete);
        }
    }
}
