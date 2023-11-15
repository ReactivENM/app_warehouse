using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers.TruckLotController;
using ComponentFactory.Krypton.Toolkit;
using Warehouse.Dictionary;

namespace Warehouse.Forms.Truck
{
    public partial class TruckLot : Form
    {
        List<LotModel> truckLotData = new List<LotModel>();
        List<LotModel> allLotsData = new List<LotModel>();
        private float lotWeight = 0;
        private int truck;

        public TruckLot(int truck)
        {
            this.truck = truck;
            initializeFormAsync();
        }

        public async void initializeFormAsync()
        {
            InitializeComponent();
            lotsInTruck.SelectedIndexChanged += lotsInTruck_SelectedItem;
            lotsWithoutTruck.SelectedIndexChanged += lotsWithoutTruck_SelectedItem;

            await fetchData();
        }

        public async Task fetchData()
        {
            TruckLotController controller = new TruckLotController();
            List<LotModel> truckLots = controller.GetTruckLots(truck);
            List<LotModel> allLots = controller.GetAllLots();
            foreach (LotModel lot in truckLots)
            {
                truckLotData.Add(lot);
            }
            foreach (LotModel lot in allLots)
            {
                allLotsData.Add(lot);
            }
            UpdateListBox(lotsInTruck, truckLotData);
            UpdateListBox(lotsWithoutTruck, allLotsData);
        }

        private void btnMoteToLot_Click(object sender, EventArgs e)
        {
            if (lotsWithoutTruck.SelectedItem != null)
            {
                var selectedLot = lotsWithoutTruck.SelectedItem as dynamic;

                LotModel lot = allLotsData.Find(l => l.id == selectedLot.LoteId);
                truckLotData.Add(lot);
                allLotsData.Remove(lot);

                UpdateListBox(lotsInTruck, truckLotData);
                UpdateListBox(lotsWithoutTruck, allLotsData);

                TruckLotController controller = new TruckLotController();
                controller.AssignToTruck(truck, lot.id);

                btnMoveToTruck.Enabled = (lotsWithoutTruck.SelectedItem != null || lotsWithoutTruck.Items.Count > 0);
                btnRemoveFromTruck.Enabled = (lotsInTruck.SelectedItem != null || lotsInTruck.Items.Count > 0);
            }
        }

        private void btnRemoveFromLot_Click(object sender, EventArgs e)
        {
            if (lotsInTruck.SelectedItem != null)
            {
                var selectedLot = lotsInTruck.SelectedItem as dynamic;
                
                LotModel lot = truckLotData.Find(l => l.id == selectedLot.LoteId);
                allLotsData.Add(lot);
                truckLotData.Remove(lot);

                UpdateListBox(lotsInTruck, truckLotData);
                UpdateListBox(lotsWithoutTruck, allLotsData);

                TruckLotController controller = new TruckLotController();
                controller.UnassignFromTruck(lot.id);

                btnMoveToTruck.Enabled = (lotsWithoutTruck.SelectedItem != null || lotsWithoutTruck.Items.Count > 0);
                btnRemoveFromTruck.Enabled = (lotsInTruck.SelectedItem != null || lotsInTruck.Items.Count > 0);
            }
        }

        public class LoteItem
        {
            public string DisplayText { get; set; }
            public int LoteId { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void UpdateListBox(KryptonListBox listBox, List<LotModel> lots)
        {
            Dictionaries dictionaries = new Dictionaries();
            Dictionary<string, string> warehouseSelect = dictionaries.DepartmentByWarehouseID();

            listBox.Items.Clear();
            foreach (LotModel lot in lots)
            {
                listBox.Items.Add(new LoteItem
                {
                    DisplayText = $"Lote #{lot.id} - A.Destino: {warehouseSelect[lot.id_almacen.ToString()]}",
                    LoteId = lot.id
                });
            }
            listBox.SelectedItem = null;
        }

        private void lotsInTruck_SelectedItem(object sender, EventArgs e)
        {
            btnRemoveFromTruck.Enabled = (lotsInTruck.SelectedItem != null);
        }

        private void lotsWithoutTruck_SelectedItem(object sender, EventArgs e)
        {
            btnMoveToTruck.Enabled = (lotsWithoutTruck.SelectedItem != null);
        }
    }
}
