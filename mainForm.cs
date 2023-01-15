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
    public partial class frmmainForm : Form
    {
        public frmmainForm()
        {
            InitializeComponent();
        }

        private void buildingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form fb1 in Application.OpenForms) 
            {
                if (fb1.Text == "Buildings") 
                {
                    IsOpen = true;
                    fb1.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmBuildings frmbuilding = new frmBuildings();
                frmbuilding.MdiParent = this;
                frmbuilding.Dock = DockStyle.Fill;
                frmbuilding.Show();
            }



        }

        private void apartmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)

        {
            bool IsOpen = false;

            foreach (Form fb2 in Application.OpenForms) 
            {
                if (fb2.Text == "Apartments") 
                {
                    IsOpen = true;
                    fb2.Focus();
                    break;
                }
            }

            if (IsOpen == false) 
            {
                frmApartments frmapartment = new frmApartments();
                frmapartment.MdiParent = this;
                frmapartment.Dock = DockStyle.Fill;
                frmapartment.Show();
            }
            

        }

        private void occupantDetialsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;

            foreach (Form fb3 in Application.OpenForms)
            {
                if (fb3.Text == "Occupant")
                {
                    IsOpen = true;
                    fb3.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmOccupant frmoccupant = new frmOccupant();
                frmoccupant.MdiParent = this;
                frmoccupant.Dock = DockStyle.Fill;
                frmoccupant.Show();
            }

        }

        private void dependantDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form fb4 in Application.OpenForms)
            {
                if (fb4.Text == "Dependant")
                {
                    IsOpen = true;
                    fb4.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmDependant frmdependant = new frmDependant();
                frmdependant.MdiParent = this;
                frmdependant.Dock = DockStyle.Fill;
                frmdependant.Show();
            }
        }
    }
}
