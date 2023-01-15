using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eapartments
{
    class ApartmentCRUD
    {


        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public ApartmentEntity Apartment { get; set; }


        public List<ApartmentEntity> GetList()
        {
            try
            {
                string query = "SELECT * FROM tbl_Apartment";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ApartmentEntity> apartmentEntities = new List<ApartmentEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    apartmentEntities.Add(new ApartmentEntity()
                    {
                        apartmentID = int.Parse(data[0].ToString()),
                        buildingID =  int.Parse(data[1].ToString()),
                        classID = int.Parse(data[2].ToString()),
                        floorID = int.Parse(data[3].ToString()),
                        apartmentAvalibility = data[4].ToString()
                        
                        
                    });
                };

                return apartmentEntities;

            }
            catch (Exception err)
            {

                MessageBox.Show("Error Occured" + err.Message);
                return new List<ApartmentEntity>();
            }
        }


        internal bool InsertRecord()
        {
            try
            {
                string query = "INSERT INTO tbl_Apartment(apartment_ID, building_ID, class_ID, floor_ID,avalibility) VALUES('" + Apartment.apartmentID + "','" + Apartment.buildingID + "','" + Apartment.classID + "','" + Apartment.floorID + "','"+Apartment.apartmentAvalibility+"')";
                string query2 = "INSERT INTO tbl_Apartment(apartment_ID, building_ID, class_ID, floor_ID) VALUES('{0}','{1}','{2}','{3}','{4}')";
                string FinalQuery = string.Format(query2, Apartment.apartmentID, Apartment.buildingID, Apartment.classID, Apartment.floorID, Apartment.apartmentAvalibility);


                com = new SqlCommand(FinalQuery, con);

                con.Open();
                int updateRecords = com.ExecuteNonQuery();
                if (updateRecords > 0) return true; else return false;
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

        internal object GetApartment(string text) 
        {
            try
            {
                string query = "SELECT * FROM tbl_Apartment WHERE apartment_ID LIKE '%" + text + "%'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<ApartmentEntity> apartmentEntities = new List<ApartmentEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    apartmentEntities.Add(new ApartmentEntity() 
                    {
                        apartmentID = int.Parse(data[0].ToString()),
                        buildingID = int.Parse(data[1].ToString()),
                        classID = int.Parse(data[2].ToString()),
                        floorID = int.Parse(data[3].ToString()),
                        apartmentAvalibility = data[4].ToString()
                    });
                };
                return apartmentEntities;
            }
            catch (Exception er) 
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<ApartmentEntity>();
            }
        }

        internal bool UpdateApartment()
        {
            string query = "UPDATE tbl_Apartment SET building_ID='" + Apartment.buildingID + "', class_ID='" + Apartment.classID + "', floor_ID='" + Apartment.floorID + "', avalibility ='" + Apartment.apartmentAvalibility + "' WHERE apartmant_ID = '"+Apartment.apartmentID+"' ";
            con.Open();
            int updateRecords = com.ExecuteNonQuery();
            if (updateRecords > 0) return true; else return false;

        }

        internal bool DeleteApartment()
        {
            string query = "DELETE tbl_Apartment WHERE apartment_ID ='" + Apartment.apartmentID + "'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
        }


    }

    class ApartmentEntity 
    {
        public int apartmentID { get; set; }
        public int buildingID { get; set; }
        public int classID { get; set; }
        public int floorID { get; set; }
        public string apartmentAvalibility { get; set; }
    }
}
