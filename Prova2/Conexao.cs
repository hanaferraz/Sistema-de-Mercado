using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Prova2
{
    public static class Conexao
    {
        // String de conexão (certifique-se de que os detalhes estão corretos)
        private static readonly string ConnectionString =
            
            "Data Source=DESKTOP-J99EN1R;Initial Catalog=parcial2;Integrated Security=True;TrustServerCertificate=True";
        // Método para abrir uma conexão com o banco de dados
        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                // Lança uma exceção mais específica para problemas de SQL
                throw new Exception("Erro ao conectar ao banco de dados SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Lança uma exceção genérica para outros erros
                throw new Exception("Erro inesperado ao conectar ao banco de dados: " + ex.Message);
            }
        }

        // Método para executar comandos que não retornam dados (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log ou tratamento adicional pode ser adicionado aqui
                        throw new Exception("Erro ao executar comando no banco de dados: " + ex.Message);
                    }
                }
            }
        }

        // Método para executar comandos que retornam um único valor (ex.: COUNT, SUM, etc.)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        // Log ou tratamento adicional pode ser adicionado aqui
                        throw new Exception("Erro ao executar comando Scalar no banco de dados: " + ex.Message);
                    }
                }
            }
        }

        // Método para executar SELECT e retornar uma tabela de dados
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log ou tratamento adicional pode ser adicionado aqui
                        throw new Exception("Erro ao executar consulta no banco de dados: " + ex.Message);
                    }
                }
            }
        }
    }
}