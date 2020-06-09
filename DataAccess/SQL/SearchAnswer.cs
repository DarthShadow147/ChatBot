using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQL
{
    public class SearchAnswer:ConnectionToSQL
    {
        string respuesta;
        public string Search(string question)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_FIND_RESPONSE";
                    command.Parameters.AddWithValue("@question", question);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        respuesta = (string) reader["Respuesta"];
                        command.Parameters.Clear();
                    }
                    reader.Close();
                    return respuesta;
                }
            }   
        }
    }
}
