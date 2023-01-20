using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eapartments
{
    class ApartmentLeaseCRUD
    {
        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public ApartmentLeaseEntity ApartmentLease { get; set; }


        public List<ApartmentLeaseEntity> GetList()
        {
            try
            {


                string query = "SELECT * FROM tbl_ApartmentLeasing";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ApartmentLeaseEntity> apartmentLeaseEntities = new List<ApartmentLeaseEntity>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    apartmentLeaseEntities.Add(new ApartmentLeaseEntity()
                    {
                        apartmentLeaseID = int.Parse(data[0].ToString()),
                        buildinigID = int.Parse(data[1].ToString()),
                        apartmentID = int.Parse(data[2].ToString()),
                        classID = int.Parse(data[3].ToString()),
                        leaseSignedDate = data[4].ToString(),
                        leaseEndDate = data[5].ToString(),
                        refundDeposit = float.Parse(data[6].ToString()),
                        monthlyPayment = float.Parse(data[7].ToString()),
                    });
                };

                return apartmentLeaseEntities;

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ApartmentLeaseEntity>();

            }
        }


        internal bool InsertRecord()
        {
            try
            {
                string query = "INSERT INTO tbl_ApartmentLeasing(apartment_Lease_ID, building_ID, occupant_ID, apartment_ID, class_ID, lease_Signed_Date, lease_End_Date, refund_Deposit, monthly_Payment ) " +
                    "VALUES ('" + ApartmentLease.apartmentLeaseID + "','" + ApartmentLease.buildinigID + "','" + ApartmentLease.occupantID + "','" + ApartmentLease.apartmentID + "','" + ApartmentLease.classID + "'," +
                    "'" + ApartmentLease.leaseSignedDate + "', '" + ApartmentLease.leaseEndDate + "', '"+ ApartmentLease.refundDeposit + "','" + ApartmentLease.monthlyPayment + "')";
                string query2 = "INSERT INTO tbl_ApartmentLeasing(apartment_Lease_ID, building_ID, occupant_ID, apartment_ID, class_ID, lease_Signed_Date, lease_End_Date, refund_Deposit, monthly_Payment )" +
                    " Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                string FinalQuery = string.Format(query2, ApartmentLease.apartmentLeaseID, ApartmentLease.buildinigID, ApartmentLease.occupantID, ApartmentLease.apartmentID, ApartmentLease.classID,
                    ApartmentLease.leaseSignedDate, ApartmentLease.leaseEndDate, ApartmentLease.refundDeposit, ApartmentLease.monthlyPayment);


                com = new SqlCommand(FinalQuery, con);


                int updatedRecords = com.ExecuteNonQuery();
                if (updatedRecords > 0) return true; else return false;

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return false;
            }

            finally
            {
                con.Close();
            }
        }

        internal object GetApartmentLease(int leaseID)
        {
            try
            {
                string query = "SELECT * FROM tbl_ApartmentLeasing WHERE apartment_Lease_ID LIKE '%" + leaseID + "%'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ApartmentLeaseEntity> apartmentLeaseEntities = new List<ApartmentLeaseEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    apartmentLeaseEntities.Add(new ApartmentLeaseEntity()
                    {
                        apartmentLeaseID = int.Parse(data[0].ToString()),
                        buildinigID = int.Parse(data[1].ToString()),
                        apartmentID = int.Parse(data[2].ToString()),
                        classID = int.Parse(data[3].ToString()),
                        leaseSignedDate = data[4].ToString(),
                        leaseEndDate = data[5].ToString(),
                        refundDeposit = float.Parse(data[6].ToString()),
                        monthlyPayment = float.Parse(data[7].ToString()),


                    });
                };
                return apartmentLeaseEntities;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ApartmentLeaseEntity>();

            }
        }


        internal bool UpdateApartmentLease()
        {
            string query = "UPDATE tbl_ApartmentLeasing SET " +

                " building_ID='" + ApartmentLease.buildinigID + "', " +
                "occupant_ID='" + ApartmentLease.occupantID + "'," +
                " apartment_ID='" + ApartmentLease.apartmentID + "', " +
                "class_ID='" + ApartmentLease.classID + "'," +
                " lease_Signed_Date='" + ApartmentLease.leaseSignedDate + "'," +
                " lease_End_Date='" + ApartmentLease.leaseEndDate + "'," +
                " refund_Deposit='" + ApartmentLease.refundDeposit + "'," +
                " monthly_Payment='" + ApartmentLease.monthlyPayment + "' WEHERE  " +
                "apartment_Lease_ID = '" + ApartmentLease.apartmentLeaseID + "',";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;

        }

        internal bool DeleteBuilding()

        {
            string query = "DELETE tbl_ApartmentLeasing WHERE apartment_Lease_ID ='" + ApartmentLease.apartmentLeaseID + "'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;

        }

    }





    class ApartmentLeaseEntity
    {
        public int apartmentLeaseID { get; set; }
        public int buildinigID { get; set; }
        public int apartmentID { get; set; }
        public int occupantID { get; set; }
        public int classID { get; set; }
        public string leaseSignedDate { get; set; }
        public string leaseEndDate { get; set; }
        public float refundDeposit { get; set; }
        public float monthlyPayment { get; set; }



    }

}
