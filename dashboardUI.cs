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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtPrint.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 0));
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                //making a recipt
                rtPrint.Clear();
                rtPrint.AppendText("\t" + "\t" + "Daily Report" + "\n");
                rtPrint.AppendText("date" + "\t" + "\t" + "\t" + "\t" + dateTimePicker1.Text + "\n");
                rtPrint.AppendText("number of total apartments" + "\t" + "\t" + "\t" + txtnumApt.Text + "\n");
                rtPrint.AppendText("number of total occupied apartments" + "\t" + "\t" + "\t"  + txtnumOccu.Text + "\n");
                rtPrint.AppendText("number of total parkings" + "\t" + "\t" + "\t" + txtnumPark.Text + "\n");
                rtPrint.AppendText("number of occupird parking" + "\t" + "\t" + "\t" + txtNumOccPark.Text + "\n");
                rtPrint.AppendText("number of reidents" + "\t" + "\t" + "\t" + "\t" + txtTotResi.Text + "\n");
                rtPrint.AppendText("number of reservations" + "\t" + "\t" + "\t" + txtNumRes.Text + "\n");
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
