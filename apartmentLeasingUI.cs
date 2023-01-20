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
    public partial class frmApartmentLeasing : Form
    {
        public frmApartmentLeasing()
        {
            InitializeComponent();
        }

        private void apartmentLeasingUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eApartmentsDataSet.tbl_building' table. You can move, or remove it, as needed.
            this.tbl_buildingTableAdapter.Fill(this.eApartmentsDataSet.tbl_building);

        }
    }
}
