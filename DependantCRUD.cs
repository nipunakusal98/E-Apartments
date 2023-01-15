using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eapartments
{
    class DependantCRUD
    {
        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public DependantEntity Dependant { get; set; }


        public List<DependantEntity> GetList()
        {
            try
            {
                string query = "SELECT * FROM tbl_Dependant";
                da = new SqlDataAdapter();
                dt = new DataTable();
                da.Fill(dt);

                List<DependantEntity> dependantEntities = new List<DependantEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    dependantEntities.Add(new DependantEntity()
                    {
                        dependantID = int.Parse(data[0].ToString()),
                        occupantID = int.Parse(data[1].ToString()),
                        dependantFirstName = data[2].ToString(),
                        dependantLastName = data[3].ToString(),
                        dependacyToOccupant = data[4].ToString(),
                        dependantTelephone = data[5].ToString(),
                        dependantEmail = data[6].ToString(),
                        



                    });
                };
                return dependantEntities;

            }
            
           catch (Exception er)
            {

                MessageBox.Show("Error Occured" + er.Message);
                return new List<DependantEntity>();
            }
        }

        internal bool InsertRecord()
        {
            try
            {
                string query = "INSERT INTO tbl_Dependant(occupant_ID,dependant_First_Name,dependant_Last_Name,dependancy_To_Occupant,dependant_Telephone,dependat_Email) VALUES ('" + Dependant.occupantID + "','" + Dependant.dependantFirstName + "','" + Dependant.dependantLastName + "','" + Dependant.dependacyToOccupant + "','" + Dependant.dependantTelephone + "','" + Dependant.dependantEmail+ "')";
                string query2 = "INSERT INTO tbl_Dependant (occupant_ID,dependant_First_Name,dependant_Last_Name,dependancy_To_Occupant,dependant_Telephone,dependat_Email) VALUES('{0}','{1}','{2}','{3}','{4}',{5})";
                string FinalQuery = string.Format(query2, Dependant.occupantID, Dependant.dependantFirstName, Dependant.dependantLastName, Dependant.dependacyToOccupant, Dependant.dependantTelephone, Dependant.dependantEmail);


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


        internal object GetDependant(string text) 
        {
            try
            {
                string query = "SELECT * FROM tbl_Dependant WHERE occupant_ID LIKE '%" + text + "%' OR dependant_First_Name LIKE '%" + text + "%' ";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<DependantEntity> dependantEntities = new List<DependantEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    dependantEntities.Add(new DependantEntity()
                    {
                        dependantID = int.Parse(data[0].ToString()),
                        occupantID = int.Parse(data[1].ToString()),
                        dependantFirstName = data[2].ToString(),
                        dependantLastName = data[3].ToString(),
                        dependacyToOccupant = data[4].ToString(),
                        dependantTelephone = data[5].ToString(),
                        dependantEmail = data[6].ToString(),


                    });
                };
                return dependantEntities;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<DependantEntity>();

            }


        }

        internal bool UpdateOccupant()
        {
            try
            { 
            string query = "UPDATE tbl_Dependant SET dependant_First_Name ='" + Dependant.dependantFirstName + "',dependant_Last_Name='" + Dependant.dependantLastName + "',dependancy_To_Occupant='" + Dependant.dependacyToOccupant + "',dependant_Telephone='" + Dependant.dependantTelephone + "',dependant_Email='" + Dependant.dependantEmail + "' WHERE dependant_ID ='" + Dependant.dependantID + "' ";
            

            com = new SqlCommand(query, con);

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


        internal bool DeleteOccupant()
        {
            string query = "DELETE tbl_Depenant WHERE dependant_ID ='" + Dependant.dependantID + "'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
        }




    }

    class DependantEntity
    {
        public int dependantID { get; set; }
        public int occupantID { get; set; }
        public string dependantFirstName { get; set; }
        public string dependantLastName { get; set; }
        public string dependacyToOccupant { get; set; }
        public string dependantTelephone { get; set; }
        public string dependantEmail { get; set; }


    }
}
