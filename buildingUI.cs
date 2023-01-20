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
    public partial class frmBuildings : Form
    {
        public frmBuildings()
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
            txtBuildingName.Clear();
            txtBuildingLocation.Clear();
            txtNumOfFloors.Clear();
            txtNumofApartments.Clear();
            txtNumOfParkingSpaces.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
        }

        

        public void LoadData() 
        {
            BuildingCRUD buildingCRUD = new BuildingCRUD();
            var data = buildingCRUD.GetList();

            dgvBuilding.DataSource = data;
        }


        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmBuildings_Load(object sender, EventArgs e)
        {
          

            LoadData();
            InitMode();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtBuildingName_TextChanged(object sender, EventArgs e)
        {
            BuildingCRUD buildingCRUD = new BuildingCRUD();
            var data = buildingCRUD.GetBuilding(txtBuildingName.Text);

            dgvBuilding.DataSource = data;
        }

        private void dgvBuilding_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //txtBuildingID.Text = dgvBuilding.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtBuildingName.Text = dgvBuilding.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtBuildingLocation.Text = dgvBuilding.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtNumOfFloors.Text = dgvBuilding.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtNumofApartments.Text = dgvBuilding.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtNumOfParkingSpaces.Text = dgvBuilding.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txtTelephone.Text = dgvBuilding.Rows[e.RowIndex].Cells[6].Value.ToString();
            //txtEmail.Text = dgvBuilding.Rows[e.RowIndex].Cells[7].Value.ToString();

            UpdateMode();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuildingCRUD buildingCRUD = new BuildingCRUD();

            buildingCRUD.Building = new BuildingEntity()
            {
                buildingName = txtBuildingName.Text,
                buildingLocation = txtBuildingLocation.Text,
                numOfFloors = int.Parse(txtNumOfFloors.Text),
                numOfApartments = int.Parse(txtNumofApartments.Text),
                numOfParkingSpaces = int.Parse(txtNumOfParkingSpaces.Text),
                telephoneNumber = txtTelephone.Text,
                emailAddress = txtEmail.Text
            };

            bool status = buildingCRUD.InsertRecord();
            if (status)
                MessageBox.Show("Record Inserted");
            else
                MessageBox.Show("Record insertion failed.");

            LoadData();
            InitMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BuildingCRUD buildingCRUD = new BuildingCRUD();

            buildingCRUD.Building = new BuildingEntity()
            {
                buildingID = int.Parse(txtBuildingID.Text),
                buildingName = txtBuildingName.Text,
                buildingLocation = txtBuildingLocation.Text,
                numOfFloors = int.Parse(txtNumOfFloors.Text),
                numOfApartments = int.Parse(txtNumofApartments.Text),
                numOfParkingSpaces = int.Parse(txtNumOfParkingSpaces.Text),
                telephoneNumber = txtTelephone.Text,
                emailAddress = txtEmail.Text
            };

            bool status = buildingCRUD.UpdateBuilding();
            if (status)
                MessageBox.Show("Record Updated");
            else
                MessageBox.Show("Record Update failed.");

            LoadData();
            InitMode();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BuildingCRUD buildingCRUD = new BuildingCRUD();

            buildingCRUD.Building = new BuildingEntity()
            {
                buildingID = int.Parse(txtBuildingID.Text)
            };

            bool status = buildingCRUD.DeleteBuilding();
            if (status)
                MessageBox.Show("Record Deleted");
            else
                MessageBox.Show("Record Deletion failed.");

            LoadData();
            InitMode();

        }

        private void dgvBuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuildingID.Text = dgvBuilding.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBuildingName.Text = dgvBuilding.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBuildingLocation.Text = dgvBuilding.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumOfFloors.Text = dgvBuilding.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumofApartments.Text = dgvBuilding.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNumOfParkingSpaces.Text = dgvBuilding.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTelephone.Text = dgvBuilding.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = dgvBuilding.Rows[e.RowIndex].Cells[7].Value.ToString();

            UpdateMode();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuildingID.Text = "";
            txtBuildingName.Text = "";
            txtBuildingLocation.Text = "";
            txtNumOfFloors.Text = "";
            txtNumofApartments.Text = "";
            txtNumOfParkingSpaces.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
        }
    }
}
