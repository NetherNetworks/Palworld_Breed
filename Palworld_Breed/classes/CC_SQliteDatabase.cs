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

        public static void LoadCB<T>(ComboBox cb)
        {
            string sql_query = "Select * from pals order by Combi_Rank";

            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                var output = connection.Query<T>(sql_query).ToList();
                cb.DataSource = output;
            }
        }

        public static List<ParentChild> listOfPals()
        {
            string sql_query = "Select * from pals";

            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                List<ParentChild> allPals = connection.Query<ParentChild>(sql_query).ToList();

                //allPals.Sort((m1, m2) => -string.Compare(m1.Name, m2.Name));

                allPals = allPals.OrderBy(item => item.Name).ToList();

                allPals = allPals.OrderByDescending(A => A.Combi_Rank).ToList();

                //allPals.

                return allPals;
            }                
        }

        public static Pal[] PalArray()
        {
            string sql_query1 = "Select count(*) from pals";
            string sql_query2 = "Select * from pals";
            int arrayNumber;            

            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                arrayNumber = connection.ExecuteScalar<int>(sql_query1);
                Pal[] pals = new Pal[arrayNumber];
                pals = connection.Query<Pal>(sql_query2).ToArray();

                pals = pals.OrderBy(item => item.Combi_Rank).ToArray();
                
                return pals;
            }            
        }

     


    }
}
