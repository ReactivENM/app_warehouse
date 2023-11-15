using System;
using System.Windows.Forms;
using Controllers.UserController;
using Models;
using Models;

namespace Warehouse
{
    public partial class Login : Form
    {
        private UserModel user;
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool passedValidation = validateFields();
            if (!passedValidation) return;

            bool validCredentials = validateCredentials();
            if (!validCredentials) return;

            Hide();
            new Warehouse(user).Show();
        }

        private bool validateCredentials()
        {
            string correo = inputEmail.Text;
            string contrasena = inputPassword.Text;

            UserController controller = new UserController();
            var res = controller.Login(correo, contrasena);
            if(!res.success)
            {
                ThrowErrorMessage(res.msg, "Error de validación");
                return false;
            }

            user = res.user;
            return true;
        }

        private bool validateFields()
        {
            if (inputEmail.Text.Length == 0)
            {
                ThrowErrorMessage("Debes escribir un nombre de usuario!", "Error de validación");
                return false;
            }
            if (inputPassword.Text.Length == 0)
            {
                ThrowErrorMessage("Debes escribir una contraseña!", "Error de validación");
                return false;
            }

            return true;
        }

        private static void ThrowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
