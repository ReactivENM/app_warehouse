using System;
using System.Drawing;
using System.Windows.Forms;
using Warehouse.Forms;
using Models;

namespace Warehouse
{
    public partial class Warehouse : Form
    {
        // Fields
        private Button currentButton;
        private Form activeForm;
        private UserModel user;

        public Warehouse(UserModel user)
        {
            InitializeComponent();
            this.FormClosing += onCloseBackoffice;
            this.user = user;
            OpenChildForm(new FormLot(user), btnLotes);
            ActivateButton(btnLotes);
        }

        private void onCloseBackoffice(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#D8D8D8");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLot(user), sender);
            ActivateButton(sender);
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPackage(), sender);
            ActivateButton(sender);
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTruck(), sender);
            ActivateButton(sender);
        }
    }
}
