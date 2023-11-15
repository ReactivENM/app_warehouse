using System;
using Models;

namespace Controllers.UserController
{
    public class UserController
    {
        private UserModel model;

        public UserController()
        {
            UserModel userModel = new UserModel();
            model = userModel;
        }

        public (bool success, string msg, UserModel user) Login(string correo, string contrasena)
        {
            return model.Login(correo, contrasena);
        }
    }
}
