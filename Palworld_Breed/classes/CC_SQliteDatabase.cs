using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Palworld_Breed.classes
{
    public class CC_SQliteDatabase
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        
        public static void InsertImage(int ID, Image image)
        {
            byte[] imageBytes = CC_Converter.ImageToByteArray(image);

            using (IDbConnection conn = new SQLiteConnection(_connectionString))
            {
                try
                {
                    string sqlQuery = "UPDATE Pals SET Picture = @ImageData WHERE ID = @Id";

                    //var parameters = new { ImageName = imageName, ImageData = imageBytes };
                    var parameters = new { Id = ID, ImageData = imageBytes };
                    conn.Execute(sqlQuery, parameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static List<Pal> listOfPals()
        {
            string sql_query = "Select * from pals";

            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                List<Pal> allPals = connection.Query<Pal>(sql_query).ToList().OrderBy(item => item.Combi_Rank).ToList();

                //allPals.Sort((m1, m2) => -string.Compare(m1.Name, m2.Name));
                //allPals = allPals.OrderBy(item => item.Combi_Rank).ToList();

                return allPals;
            }                
        } 
    }
}
