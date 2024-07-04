using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14_ConexionBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=INSTANCIA; Initial Catalog=Northwind; Integrated Security=true";

            //llamamos a la consulta de productos
            selectProduct(connectionString, 150);
        }

        public static void selectProduct(string conS, int precio) {
            string queryString = 
                "SELECT ProductId, ProductName, UnitPrice FROM dbo.Products " +
                "WHERE UnitPrice > @pricePoint "+
                "ORDER BY UnitPrice DESC;";

            using (SqlConnection connection = new SqlConnection(conS)) {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", precio);
                try
                {
                    //hacemos la conexion
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //mostramos los resultados de la consulta
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close(); 
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally { 
                    connection.Close();
                }
                Console.ReadLine();
            }
        }
    }
}
