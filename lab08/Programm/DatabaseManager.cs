using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class DatabaseManager
    {
        private static string connectionString = "Data Source=(localdb)\\localdb01;Initial Catalog=SampleDB;Integrated Security=True";

        public static void Create(string First_name, string Last_name, string Email, string Phone)
        {
            string query = "insert into clients (First_name, Last_name, Email, Phone, Registration_date) values (@First_name, @Last_name, @Email, @Phone, getdate())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@First_name", First_name);
                    command.Parameters.AddWithValue("@Last_name", Last_name);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);

                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"{rowsAffected} row(s) inserted");
                }
            }
        }
        public static List<string> Read()
        {
            string query = "select id, First_name, Last_name from clients";
            List<string> result = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string First_name = reader.GetString(1);
                            string Last_name = reader.GetString(2);
                            result.Add($"id: {id}\t\tFirst name: {First_name}\t\tLast name: {Last_name}");
                        }
                    }
                }
            }

            return result;
        }
        public static void Update(int id, int attribute, string data)
        {
            string attribute_name;
            string attribute_variable;
            switch (attribute)
            {
                case 1:
                    attribute_name = "First_name";
                    attribute_variable = "@First_name";
                    break;
                case 2:
                    attribute_name = "Last_name";
                    attribute_variable = "@Last_name";
                    break;
                case 3:
                    attribute_name = "Email";
                    attribute_variable = "@Email";
                    break;
                case 4:
                    attribute_name = "Phone";
                    attribute_variable = "@Phone";
                    break;
                default:
                    throw new Exception("Wrong attribute number");
            }

            string query = $"update clients set {attribute_name} = {attribute_variable} where id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue(attribute_variable, data);

                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"{rowsAffected} row(s) updated");
                }
            }
        }
        public static void Delete(int id)
        {
            string query = "delete from clients where id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"{rowsAffected} row(s) deleted");
                }
            }
        }
        public static List<string> Search(int attribute, string data)
        {
            string attribute_name;
            string attribute_variable;
            switch (attribute)
            {
                case 1:
                    attribute_name = "First_name";
                    attribute_variable = "@First_name";
                    break;
                case 2:
                    attribute_name = "Last_name";
                    attribute_variable = "@Last_name";
                    break;
                case 3:
                    attribute_name = "Email";
                    attribute_variable = "@Email";
                    break;
                case 4:
                    attribute_name = "Phone";
                    attribute_variable = "@Phone";
                    break;
                default:
                    throw new Exception("Wrong attribute number");
            }

            string query = $"select id, First_name, Last_name, Email, Phone from Clients where {attribute_name} = {attribute_variable}";
            List<string> result = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(attribute_variable, data);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string First_name = reader.GetString(1);
                            string Last_name = reader.GetString(2);
                            string Email = reader.GetString(3);
                            string Phone = reader.GetString(4);
                            result.Add($"id: {id}\t\tFirst name: {First_name}\t\tLast name: {Last_name}\n\nEmail: {Email}\t\tPhone: {Phone}\n");
                        }
                    }
                }
            }
            return result;
        }
    }
}
