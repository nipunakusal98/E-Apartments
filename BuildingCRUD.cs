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

    class BuildingCRUD {
        SqlConnection con = dbCon.connection;
        SqlCommand com;
        DataTable dt;
        SqlDataAdapter da;
        SqlDataReader dr;

        public BuildingEntity Building { get; set; }


        public List<BuildingEntity> GetList() {
            try
            {
               

                string query = "SELECT * FROM tbl_building";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<BuildingEntity> buildingEntities = new List<BuildingEntity>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    buildingEntities.Add(new BuildingEntity()
                    {
                        buildingID = int.Parse(data[0].ToString()),
                        buildingName = data[1].ToString(),
                        buildingLocation = data[2].ToString(),
                        numOfFloors = int.Parse(data[3].ToString()),
                        numOfApartments = int.Parse(data[4].ToString()),
                        numOfParkingSpaces = int.Parse(data[5].ToString()),
                        telephoneNumber = data[6].ToString(),
                        emailAddress = data[7].ToString()
                    });
                };

                return buildingEntities;

            }
            catch (Exception er)
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<BuildingEntity>();

            }
           

        }

        internal bool InsertRecord()
        {
            try
            {
                string query = "INSERT INTO tbl_building(building_Name,building_Location,num_Of_Floors,num_Of_Apartments,num_Of_Parking_Spaces,telephone_Number,email_Address) VALUES ('" + Building.buildingName + "','" + Building.buildingLocation + "','" + Building.numOfFloors + "','" + Building.numOfApartments + "','" + Building.numOfParkingSpaces + "','" + Building.telephoneNumber + "','" + Building.emailAddress + "',)";
                string query2 = "INSERT INTO tbl_building (building_Name,building_Location,num_Of_Floors,num_Of_Apartments,num_Of_Parking_Spaces,telephone_Number,email_Address) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                string FinalQuery = string.Format(query2, Building.buildingName, Building.buildingLocation, Building.numOfFloors, Building.numOfApartments, Building.numOfParkingSpaces, Building.telephoneNumber, Building.emailAddress);

                
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
                
            }
        }

        internal object GetBuilding(string text)
        {
            try
            {
                string query = "SELECT * FROM tbl_building WHERE building_Name LIKE '%" + text + "%'";
                da = new SqlDataAdapter(query, con);
                dt = new DataTable();
                da.Fill(dt);

                List<BuildingEntity> buildingEntities = new List<BuildingEntity>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var data = dt.Rows[i].ItemArray;
                    buildingEntities.Add(new BuildingEntity()
                    {
                        buildingID = int.Parse(data[0].ToString()),
                        buildingName = data[1].ToString(),
                        buildingLocation = data[2].ToString(),
                        numOfFloors = int.Parse(data[3].ToString()),
                        numOfApartments = int.Parse(data[4].ToString()),
                        numOfParkingSpaces = int.Parse(data[5].ToString()),
                        telephoneNumber = data[6].ToString(),
                        emailAddress = data[7].ToString()


                    }) ;
                };
                return buildingEntities;
            }
            catch (Exception er) 
            {
                MessageBox.Show("Error Occured" + er.Message);
                return new List<BuildingEntity>();

            }
        }

        internal bool UpdateBuilding() 
        {
            string query = "UPDATE tbl_building set building_Name='"+Building.buildingName+ "', building_Location='" + Building.buildingLocation + "',num_Of_Floors ='"+Building.numOfFloors+ "',num_Of_Apartments='" + Building.numOfApartments + "',num_Of_Parking_Spaces='" + Building.numOfParkingSpaces + "',telephone_Number='" + Building.telephoneNumber+ "',email_Address='" + Building.emailAddress + "' WHERE building_ID ='"+Building.buildingID+"' ";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
            
        }

        internal bool DeleteBuilding()
        {
            string query = "DELETE tbl_building WHERE building_ID ='"+Building.buildingID+"'";
            com = new SqlCommand(query, con);

            con.Open();
            int updatedRecords = com.ExecuteNonQuery();
            if (updatedRecords > 0) return true; else return false;
            
        }

    
    
    
    
    
    
    
    }
    class BuildingEntity
    {
        public int buildingID { get; set; }
        public string buildingName { get; set; }
        public string buildingLocation { get; set; }
        public int numOfFloors { get; set; }
        public int numOfApartments { get; set; }
        public int numOfParkingSpaces { get; set; }
        public string telephoneNumber { get; set; }
        public string emailAddress { get; set; }
    }
}
