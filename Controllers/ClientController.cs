using System.Collections.Generic;
using Models;

namespace Controllers.ClientController
{
    public class ClientController
    {
        private ClientModel model;

        public ClientController()
        {
            ClientModel whModel = new ClientModel();
            model = whModel;
        }

        public List<ClientModel> GetAll()
        {
            return model.GetAll();
        }
    }
}
