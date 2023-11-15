using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers.WareHouseController
{

    public class WareHouseController
    {
        private WareHouseModel model;
        
        public WareHouseController()
        {
            WareHouseModel whModel = new WareHouseModel();
            model = whModel;
        }

        public List<WareHouseModel> GetAll()
        {
            return model.GetAll();
        }
    }

}
