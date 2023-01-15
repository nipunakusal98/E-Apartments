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
    public partial class frmOccupant : Form
    {
        

        public frmOccupant()
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

            txtOccupantID.Clear();
            txtOccupantFirstName.Clear();
            txtOccuapntLastName.Clear();
            txtOccupantAddress.Clear();
            txtTelephoneNo.Clear();
            txtEmailAddress.Clear();
            txtOccupantNICPassportID.Clear();
            
        }


        public void LoadData()
        {
            OccupantCRUD occupantCRUD = new OccupantCRUD();
            var data = occupantCRUD.GetList();

            dgvOccupant.DataSource = data;
        }


        private void frmOccupant_Load(object sender, EventArgs e)
        {


            LoadData();
            InitMode();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OccupantCRUD occupantCRUD = new OccupantCRUD();
            var data = occupantCRUD.GetOccupant(txtOccupantFirstName.Text);

            dgvOccupant.DataSource = data;
        }

        private void txtOccupantFirstName_TextChanged(object sender, EventArgs e)
        {
            OccupantCRUD occupantCRUD = new OccupantCRUD();
            var data = occupantCRUD.GetOccupant(txtOccupantFirstName.Text);

            dgvOccupant.DataSource = data;
        }

        private void dgvOccupant_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOccupantID.Text = dgvOccupant.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOccupantFirstName.Text = dgvOccupant.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOccuapntLastName.Text = dgvOccupant.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtOccupantAddress.Text = dgvOccupant.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTelephoneNo.Text = dgvOccupant.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmailAddress.Text = dgvOccupant.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOccupantNICPassportID.Text = dgvOccupant.Rows[e.RowIndex].Cells[6].Value.ToString();

            UpdateMode();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OccupantCRUD occupantCRUD = new OccupantCRUD();
            occupantCRUD.Occupant = new OccupantEntity()
            {
             occupantFirstName = txtOccupantFirstName.Text,
             occupantLastName = txtOccuapntLastName.Text,
             occupantAddress = txtOccupantAddress.Text,
             occupantEmail = txtEmailAddress.Text,
             occupantTelephone = txtTelephoneNo.Text,
             occupantNICPassport = txtOccupantNICPassportID.Text

            };

            bool status = occupantCRUD.InsertRecord();
            if (status)
                MessageBox.Show("Record Inserted");
            else
                MessageBox.Show("Record insertion failed.");

            LoadData();
            InitMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            OccupantCRUD occupantCRUD = new OccupantCRUD();
            occupantCRUD.Occupant = new OccupantEntity()
            {
                occupantID =int.Parse(txtOccupantID.Text),
                occupantFirstName = txtOccupantFirstName.Text,
                occupantLastName = txtOccuapntLastName.Text,
                occupantAddress = txtOccupantAddress.Text,
                occupantEmail = txtEmailAddress.Text,
                occupantTelephone = txtTelephoneNo.Text,
                occupantNICPassport = txtOccupantNICPassportID.Text

            };
            bool status = occupantCRUD.UpdateOccupant();
            if (status)
                MessageBox.Show("Record Updated");
            else
                MessageBox.Show("Record Update failed.");

            LoadData();
            InitMode();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OccupantCRUD occupantCRUD = new OccupantCRUD();
            occupantCRUD.Occupant = new OccupantEntity()
            {
                occupantID = int.Parse(txtOccupantID.Text)
            };

            bool status = occupantCRUD.DeleteOccupant();
            if (status)
                MessageBox.Show("Record Deleted");
            else
                MessageBox.Show("Record Deletion failed.");

            LoadData();
            InitMode();

        }
    }
}
