using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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
                var output = connection.Query<T>(sql_query, new DynamicParameters()).ToList();
                cb.DataSource = output;
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
            }

            Pal[] pals = new Pal[arrayNumber];

            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                var output = connection.Query<Pal>(sql_query2).ToArray();
                pals = output;
            }
            return pals;
        }




    }
}
