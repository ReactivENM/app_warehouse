using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers.TruckController;

namespace Warehouse.Forms
{
    public partial class FormTruck : Form
    {
        List<TruckModel> truckData = new List<TruckModel>();
        private int truckLength = 0;
        private const int rowsPerPage = 10;

        private int lastPage = 1;
        private int actualPage = 1;

        private bool isRowSelected = false;
        TruckModel selectedTruck = null;

        public FormTruck()
        {
            initializeFormAsync();
        }

        public async void initializeFormAsync()
        {
            InitializeComponent();

            await fetchTruckData();

            int lastPageRes = (int)Math.Ceiling((double)truckLength / rowsPerPage);
            lastPage = Convert.ToInt32(lastPageRes);
            lblPage.Text = actualPage.ToString() + "/" + lastPage.ToString();

            // Load mock data on dataGrid
            showRows(actualPage);
            // On double click dataGrid row
            dataGridView.CellClick += new DataGridViewCellEventHandler(handleClickRow);
        }

        public async Task fetchTruckData()
        {
            TruckController controller = new TruckController();
            List<TruckModel> trucks = controller.GetAll();
            foreach (TruckModel truck in trucks)
            {
                truckData.Add(truck);
            }
            truckLength = trucks.Count;
        }

        private void showRows(int page)
        {
            dataGridView.Rows.Clear();
            for (int i = (page - 1) * rowsPerPage; i < (page * rowsPerPage > truckLength ? truckLength : page * rowsPerPage); i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView, truckData[i].id, truckData[i].matricula, truckData[i].marca, truckData[i].modelo, truckData[i].capacidad);
                dataGridView.Rows.Add(newRow);
            }
        }

        private void handleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isRowSelected = true;

                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                object id = row.Cells["id"].Value;
                TruckModel wh = truckData.Find(d => d.id == Convert.ToInt32(id));
                selectedTruck = wh;
                btnLot.Enabled = true;
                btnEditTruck.Enabled = true;
                btnDeleteTruck.Enabled = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (truckLength == 0) return;
            if (actualPage == 1) return;

            actualPage = actualPage - 1;
            lblPage.Text = actualPage.ToString() + "/" + lastPage;
            showRows(actualPage);

            // Disable buttons and unselect actual warehouse
            selectedTruck = null;
            btnLot.Enabled = false;
            btnEditTruck.Enabled = false;
            btnDeleteTruck.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (truckLength == 0) return;
            if (actualPage == lastPage) return;

            actualPage = actualPage + 1;
            lblPage.Text = actualPage.ToString() + "/" + lastPage;
            showRows(actualPage);

            // Disable buttons and unselect actual warehouse
            selectedTruck = null;
            btnLot.Enabled = false;
            btnEditTruck.Enabled = false;
            btnDeleteTruck.Enabled = false;
        }

        private void btnLot_Click(object sender, EventArgs e)
        {
            new Forms.Truck.TruckLot(selectedTruck.id).ShowDialog();
        }
    }
}
