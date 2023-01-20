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
    class ParkingCRUD
    {
        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public ParkingEntity parking { get; set; }

        public List<ParkingEntity> GetList()
        {
            try
            {


                string query = "update [tbl_ParkingSpace]" +
                    " SET [avalibility] = [pl].[avalibility]" +
                    " FROM [tbl_ParkingLeasing] AS[pl]" +
                    "WHERE[pl].[parking_Space_ID] =[tbl_ParkingSpace].[parking_Space_ID]  " +
                    "SELECT * FROM tbl_ParkingSpace";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ParkingEntity> parkingEntities = new List<ParkingEntity>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    parkingEntities.Add(new ParkingEntity()
                    {
                        
                        parkingSpaceID = int.Parse(data[0].ToString()),
                        buildingID = int.Parse(data[1].ToString()),
                        avalibility = data[2].ToString(),
                        
                    });
                };

                return parkingEntities;

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ParkingEntity>();

            }
        }

        internal bool InsertRecord()
        {
            try
            {
                con.Open();
                string query = "INSERT INTO tbl_ParkingSpace( building_ID, avalibility ) " +
                    "VALUES ('" + parking.buildingID + "','" + parking.avalibility + ")";
                string query2 = "INSERT INTO tbl_ParkingSpace(building_ID, avalibility  )" +
                    " Values('{0}','{1}')";
                string FinalQuery = string.Format(query2, parking.buildingID, parking.avalibility);


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

        internal object GetParking(string text)
        {
            try
            {
                string query = "SELECT * FROM tbl_parkingSpace WHERE parking_Space_ID LIKE '%" + text + "%' OR avalibility LIKE '%" + text + "%'  ";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ParkingEntity> parkingEntities = new List<ParkingEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    parkingEntities.Add(new ParkingEntity()
                    {
                        parkingSpaceID = int.Parse(data[0].ToString()),
                        buildingID = int.Parse(data[1].ToString()),
                       avalibility = data[2].ToString()


                    });
                };
                return parkingEntities;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ParkingEntity>();

            }
        }

        internal bool UpdateParking()
        {
            string query = "UPDATE tbl_ParkingSpace SET building_ID='" + parking.buildingID + "', avalibility='" + parking.avalibility + "' WHERE parking_Space_ID='" + parking.parkingSpaceID + "' ";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
            
        }

        internal bool DeleteParking()

        {
            string query = "DELETE tbl_building WHERE building_ID ='" + parking.parkingSpaceID + "'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;

        }

    }

    class ParkingEntity 
    {
        public int parkingSpaceID { get; set; }
        public int buildingID { get; set; }
        public string avalibility { get; set; }
    }
}
