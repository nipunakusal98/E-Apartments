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
    class OccupantCRUD
    {


        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public OccupantEntity Occupant { get; set; }


        public List<OccupantEntity> GetList()
        {
            try
            {
                string query = "SELECT * FROM tbl_Occupant";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<OccupantEntity> occupantEntities = new List<OccupantEntity>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    occupantEntities.Add(new OccupantEntity()
                    {
                        occupantID = int.Parse(data[0].ToString()),
                        occupantFirstName = data[1].ToString(),
                        occupantLastName = data[2].ToString(),
                        occupantAddress = data[3].ToString(),
                        occupantTelephone = data[4].ToString(),
                        occupantEmail= data[5].ToString(),
                        occupantNICPassport = data[6].ToString(),
                       
                    });
                };
                return occupantEntities;


            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<OccupantEntity>();

            }
        }


        internal bool InsertRecord()
        {
            try
            {
                string query = "INSERT INTO tbl_Occupant(occupant_First_Name,occupant_Last_Name,occupant_address,occupant_Telephone,occupant_Email,occupant_NICPassport) VALUES ('" + Occupant.occupantFirstName + "','" + Occupant.occupantLastName + "','" + Occupant.occupantAddress + "','" + Occupant.occupantTelephone + "','" + Occupant.occupantEmail + "','" + Occupant.occupantNICPassport + "')";
                string query2 = "INSERT INTO tbl_Occupant (occupant_First_Name,occupant_Last_Name,occupant_address,occupant_Telephone,occupant_Email,occupant_NICPassport) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
                string FinalQuery = string.Format(query2, Occupant.occupantFirstName,Occupant.occupantLastName,Occupant.occupantAddress,Occupant.occupantTelephone,Occupant.occupantEmail,Occupant.occupantNICPassport);


                com = new SqlCommand(FinalQuery, con);

                con.Open();
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


        internal object GetOccupant(string text)
        {
            try
            {
                string query = "SELECT * FROM tbl_Occupant WHERE occupant_First_Name LIKE '%" + text + "%'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<OccupantEntity> occupantEntities = new List<OccupantEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    occupantEntities.Add(new OccupantEntity()
                    {
                        occupantID = int.Parse(data[0].ToString()),
                        occupantFirstName = data[1].ToString(),
                        occupantLastName = data[2].ToString(),
                        occupantAddress = data[3].ToString(),
                        occupantTelephone = data[4].ToString(),
                        occupantEmail = data[5].ToString(),
                        occupantNICPassport = data[6].ToString()
                       


                    });
                };
                return occupantEntities;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<OccupantEntity>();

            }


        }

        internal bool UpdateOccupant()
        {
            string query = "UPDATE tbl_Occupant set occupant_First_Name ='"+ Occupant.occupantFirstName + "',occupant_Last_Name='"+Occupant.occupantLastName+"',occupant_address='"+Occupant.occupantAddress+"',occupant_Telephone='"+Occupant.occupantTelephone+"',occupant_Email='"+Occupant.occupantEmail+"',occupant_NICPassport='"+Occupant.occupantNICPassport+"' WHERE occupant_ID ='" + Occupant.occupantID + "' ";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
         
        }


        internal bool DeleteOccupant()
        {
            string query = "DELETE tbl_Occipant WHERE occupant_ID ='" + Occupant.occupantID + "'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
        }
    }

    

    class OccupantEntity
    {
        public int occupantID { get; set; }
        public string occupantFirstName { get; set; }
        public string occupantLastName { get; set; }
        public string occupantAddress { get; set; }
        public string occupantTelephone { get; set; }
        public string occupantEmail { get; set; }
        public string occupantNICPassport { get; set; }

    }

}
