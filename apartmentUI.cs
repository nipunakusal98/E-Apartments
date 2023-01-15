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
    public partial class frmApartments : Form
    {
        public frmApartments()
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
            txtApartmentID.Clear();
            txtClassID.Clear();
            txtFloorID.Clear();
            txtAvalibility.Clear();
        }



        public void LoadData()
        {
            ApartmentCRUD apartmentCRUD = new ApartmentCRUD();
            var data = apartmentCRUD.GetList();

            dgvApartment.DataSource = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void frmApartments_Load(object sender, EventArgs e)
        {
            LoadData();
            InitMode();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApartmentCRUD apartmentCRUD = new ApartmentCRUD();
            var data = apartmentCRUD.GetApartment(txtApartmentID.Text);

            dgvApartment.DataSource = data;

        }

        private void txtApartmentID_TextChanged(object sender, EventArgs e)
        {

            ApartmentCRUD apartmentCRUD = new ApartmentCRUD();
            var data = apartmentCRUD.GetApartment(txtApartmentID.Text);

            dgvApartment.DataSource = data;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ApartmentCRUD apartmentCRUD = new ApartmentCRUD();

            apartmentCRUD.Apartment = new ApartmentEntity()
            {
                //buildingID = txtBuildingID.Text, ---->not working Error Occcurs
                //classID = int.Parse(txtClassID.Text),

            };

            bool status = apartmentCRUD.InsertRecord();
            if (status)
                MessageBox.Show("Record Inserted");
            else
                MessageBox.Show("Record insertion failed.");

            LoadData();
            InitMode();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ApartmentCRUD apartmentCRUD = new ApartmentCRUD();

            apartmentCRUD.Apartment = new ApartmentEntity()
            {
                
            };

            bool status = apartmentCRUD.UpdateApartment();
            if (status)
                MessageBox.Show("Record Updated");
            else
                MessageBox.Show("Record Update failed.");

            LoadData();
            InitMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApartmentCRUD apartmentCRUD = new ApartmentCRUD();

            apartmentCRUD.Apartment = new ApartmentEntity()
            {
                apartmentID = int.Parse(txtApartmentID.Text)
            };

            bool status = apartmentCRUD.DeleteApartment();
            if (status)
                MessageBox.Show("Record Deleted");
            else
                MessageBox.Show("Record Deletion failed.");

            LoadData();
            InitMode();
        }
    }
}
