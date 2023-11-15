using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers.PackageLotController;
using ComponentFactory.Krypton.Toolkit;

namespace Warehouse.Forms.Package
{
    public partial class PackageLot : Form
    {
        List<PackageModel> packageLotData = new List<PackageModel>();
        List<PackageModel> allPackagesData = new List<PackageModel>();
        private float lotWeight = 0;
        private int lote;
        private string loteStatus;
        private int userId;

        public PackageLot(LotModel lote, int userId)
        {
            this.lote = lote.id;
            this.loteStatus = lote.estado;
            this.userId = userId;
            initializeFormAsync();
        }

        public async void initializeFormAsync()
        {
            InitializeComponent();

            packagesInLot.SelectedIndexChanged += packagesInLot_SelectedItem;
            packagesWithoutLot.SelectedIndexChanged += packagesWithoutLot_SelectedItem;

            await fetchData();
        }

        public async Task fetchData()
        {
            PackageLotController controller = new PackageLotController();
            List<PackageModel> lotPackages = controller.GetLotPackages(lote);
            List<PackageModel> allPackages = controller.GetAllPackages(lote);
            foreach (PackageModel package in lotPackages)
            {
                packageLotData.Add(package);
            }
            foreach (PackageModel package in allPackages)
            {
                allPackagesData.Add(package);
            }
            UpdateListBox(packagesInLot, packageLotData);
            UpdateListBox(packagesWithoutLot, allPackagesData);
        }

        private void btnMoteToLot_Click(object sender, EventArgs e)
        {
            if (packagesWithoutLot.SelectedItem != null)
            {
                string selectedPackage = (string)packagesWithoutLot.SelectedItem;

                string package_id = selectedPackage.Split(new char[] { '-' })[0].Trim();
                PackageModel package = allPackagesData.Find(p => p.id_externo == package_id);
                packageLotData.Add(package);
                allPackagesData.Remove(package);

                UpdateListBox(packagesInLot, packageLotData);
                UpdateListBox(packagesWithoutLot, allPackagesData);

                PackageLotController controller = new PackageLotController();
                controller.AssignToLot(package_id, lote, userId);

                btnMoveToLot.Enabled = (packagesWithoutLot.SelectedItem != null || packagesWithoutLot.Items.Count > 0);
                btnRemoveFromLot.Enabled = (packagesInLot.SelectedItem != null || packagesInLot.Items.Count > 0);
            }
        }

        private void btnRemoveFromLot_Click(object sender, EventArgs e)
        {
            if (packagesInLot.SelectedItem != null)
            {
                string selectedPackage = (string)packagesInLot.SelectedItem;

                string package_id = selectedPackage.Split(new char[] { '-' })[0].Trim();
                PackageModel package = packageLotData.Find(p => p.id_externo == package_id);
                allPackagesData.Add(package);
                packageLotData.Remove(package);

                UpdateListBox(packagesInLot, packageLotData);
                UpdateListBox(packagesWithoutLot, allPackagesData);

                PackageLotController controller = new PackageLotController();
                controller.UnassignFromLot(package_id);

                btnMoveToLot.Enabled = (packagesWithoutLot.SelectedItem != null || packagesWithoutLot.Items.Count > 0);
                btnRemoveFromLot.Enabled = (packagesInLot.SelectedItem != null || packagesInLot.Items.Count > 0);
            }
        }

        private void UpdateListBox(KryptonListBox listBox, List<PackageModel> packages)
        {
            if(listBox.Name == "packagesInLot")
            {
                lotWeight = 0;
                foreach(PackageModel p in packages)
                {
                    lotWeight += float.Parse(p.peso);
                }
                lotPackagesTitle.Text = $"Paquetes en lote ({lotWeight}Kg)";
            }

            listBox.Items.Clear();
            foreach (PackageModel package in packages)
            {
                listBox.Items.Add($"{package.id_externo} - {package.peso}kg");
            }
            listBox.SelectedItem = null;
            if (loteStatus != "en_espera") listBox.SelectionMode = SelectionMode.None;
        }

        private void packagesInLot_SelectedItem(object sender, EventArgs e)
        {
            btnRemoveFromLot.Enabled = (packagesInLot.SelectedItem != null);
        }

        private void packagesWithoutLot_SelectedItem(object sender, EventArgs e)
        {
            btnMoveToLot.Enabled = (packagesWithoutLot.SelectedItem != null);
        }
    }
}
