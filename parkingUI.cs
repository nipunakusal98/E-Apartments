using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eapartments
{
    public partial class frmParking : Form
    {
        public frmParking()
        {
            InitializeComponent();
        }


        public void UpdateMode()
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        public void InitMode()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtBuildingID.Clear();
            txtParkingID.Clear();
            
           
        }
        public void LoadData()
        {
            ParkingCRUD parkingCRUD = new ParkingCRUD();
            var data = parkingCRUD.GetList();

            dgvParking.DataSource = data;
        }
        private void frmParking_Load(object sender, EventArgs e)
        {
            LoadData();
            InitMode();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ParkingCRUD parkingCRUD = new ParkingCRUD();
            var data = parkingCRUD.GetParking(txtParkingID.Text);

            dgvParking.DataSource = data;
        }

        private void txtParkingID_TextChanged(object sender, EventArgs e)
        {
            ParkingCRUD parkingCRUD = new ParkingCRUD();
            var data = parkingCRUD.GetParking(txtParkingID.Text);
           
            dgvParking.DataSource = data;

        }

        private void cmbAvalibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ParkingCRUD parkingCRUD = new ParkingCRUD();
            //var data = parkingCRUD.GetParking(cmbAvalibility.Text);

           // dgvParking.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ParkingCRUD parkingCRUD = new ParkingCRUD();
            parkingCRUD.parking = new ParkingEntity()
            {
                buildingID = int.Parse(txtBuildingID.Text),
                avalibility = cmbAvalibility.Text
            };

            bool status = parkingCRUD.InsertRecord();
            if (status)
                MessageBox.Show("Record Inserted");
            else
                MessageBox.Show("Record insertion failed.");

            LoadData();
            InitMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ParkingCRUD parkingCRUD = new ParkingCRUD();
            parkingCRUD.parking = new ParkingEntity()
            {
                parkingSpaceID = int.Parse(txtParkingID.Text),
                buildingID = int.Parse(txtBuildingID.Text),
                avalibility = cmbAvalibility.Text
            };

            bool status = parkingCRUD.UpdateParking();
            if (status)
                MessageBox.Show("Record Updated");
            else
                MessageBox.Show("Record Updation failed.");

            LoadData();
            InitMode();
        }

        private void dgvParking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtParkingID.Text = dgvParking.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBuildingID.Text = dgvParking.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbAvalibility.Text = dgvParking.Rows[e.RowIndex].Cells[2].Value.ToString();

            UpdateMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ParkingCRUD parkingCRUD = new ParkingCRUD();
            parkingCRUD.parking = new ParkingEntity()
            {
                parkingSpaceID = int.Parse(txtParkingID.Text)
            };

            bool status = parkingCRUD.DeleteParking();
            if (status)
                MessageBox.Show("Record Deleted");
            else
                MessageBox.Show("Record Deletion failed.");

            LoadData();
            InitMode();
        }
    }
}
