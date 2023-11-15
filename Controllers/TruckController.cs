using System.Collections.Generic;
using Models;

namespace Controllers.TruckController
{
    public class TruckController
    {
        private TruckModel model;

        public TruckController()
        {
            TruckModel whModel = new TruckModel();
            model = whModel;
        }

        public List<TruckModel> GetAll()
        {
            return model.GetAll();
        }
    }
}
