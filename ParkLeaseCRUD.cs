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
    class ParkLeaseCRUD
    {
        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public ParkLeaseEntity parkLease  { get; set; }

        public List<ParkLeaseEntity> GetList()
        {
            try
            {


                string query = "SELECT * FROM tbl_ParkingLeasing";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ParkLeaseEntity> parkLeaseEntities = new List<ParkLeaseEntity>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    parkLeaseEntities.Add(new ParkLeaseEntity()
                    {
                        parkingLeaseID = int.Parse(data[0].ToString()),
                        parkingSpaceID = int.Parse(data[1].ToString()),
                        buildingID = int.Parse(data[2].ToString()),
                        occupantID = int.Parse(data[3].ToString()),
                        leaseSignedDate = data[4].ToString(),
                        leaseEndDate = data[5].ToString(),
                        avalibility = data[6].ToString(),
                        refundDeposit = float.Parse(data[7].ToString()),
                        monthlyPayment = float.Parse(data[8].ToString()),
                    });
                };

                return parkLeaseEntities;

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ParkLeaseEntity>();

            }
        }

        internal bool InsertRecord()
        {
            try
            {
                string query = "INSERT INTO tbl_ParkingLeasing(parking_Space_ID, building_ID, occupant_ID, avalibility, lease_Signed_Date, lease_End_Date, refund_Deposit, monthly_Payment  ) " +
                    "VALUES ('" + parkLease.parkingSpaceID + "','" + parkLease.buildingID + "','" + parkLease.occupantID + "','" + parkLease.avalibility + "','" + parkLease.leaseSignedDate + "', '" + parkLease.leaseEndDate + "', '" + parkLease.refundDeposit + "','" + parkLease.monthlyPayment + "')";
                string query2 = "INSERT INTO tbl_ParkingLeasing( parking_Space_ID, building_ID, occupant_ID, avalibility, lease_Signed_Date, lease_End_Date, refund_Deposit, monthly_Payment)" +
                    " Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                string FinalQuery = string.Format(query2, parkLease.parkingSpaceID, parkLease.buildingID, parkLease.occupantID, parkLease.avalibility
                    ,parkLease.leaseSignedDate, parkLease.leaseEndDate, parkLease.refundDeposit, parkLease.monthlyPayment);


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

        internal object GetParkingLease(int parkingLeaseID)
        {
            try
            {
                string query = "SELECT * FROM tbl_ParkingLeasing WHERE parking_Lease_ID LIKE '%" + parkingLeaseID + "%'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ParkLeaseEntity> parkLeaseEntities = new List<ParkLeaseEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    parkLeaseEntities.Add(new ParkLeaseEntity()
                    {
                        parkingLeaseID = int.Parse(data[0].ToString()),
                        parkingSpaceID = int.Parse(data[1].ToString()),
                        buildingID = int.Parse(data[2].ToString()),
                        occupantID = int.Parse(data[3].ToString()),
                        leaseSignedDate = data[4].ToString(),
                        leaseEndDate = data[5].ToString(),
                        avalibility = data[6].ToString(),
                        refundDeposit = float.Parse(data[7].ToString()),
                        monthlyPayment = float.Parse(data[8].ToString()),


                    });
                };
                return parkLeaseEntities;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ParkLeaseEntity>();

            }
        }

        internal bool UpdateParkingLease()
        {
            string query = "UPDATE tbl_ParkingLeasing SET " +

                " building_ID='" + parkLease.parkingSpaceID + "', " +
                "occupant_ID='" + parkLease.buildingID + "'," +
                " apartment_ID='" + parkLease.occupantID + "', " +
                " avalibility='" + parkLease.avalibility + "', " +
                " lease_Signed_Date='" + parkLease.leaseSignedDate + "'," +
                " lease_End_Date='" + parkLease.leaseEndDate + "'," +
                " refund_Deposit='" + parkLease.refundDeposit + "'," +
                " monthly_Payment='" + parkLease.monthlyPayment + "' WEHERE  " +
                "parking_Lease_ID = '" + parkLease.parkingLeaseID + "',";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;

        }

        internal bool DeleteParkingLease()

        {
            string query = "DELETE tbl_ParkingLeasing WHERE parking_Lease_ID='" + parkLease.parkingLeaseID + "'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;

        }
    }



    class ParkLeaseEntity 
    {
        public int parkingLeaseID { get; set; }
        public int parkingSpaceID { get; set; }
        public int buildingID { get; set; }
        public int occupantID { get; set; }
        public string avalibility { get; set; }
        public string leaseSignedDate { get; set; }
        public string leaseEndDate { get; set; }
        public float refundDeposit { get; set; }
        public float monthlyPayment { get; set; }
    }



}
