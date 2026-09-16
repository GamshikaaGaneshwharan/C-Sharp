using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp2.DAL
{
    public class Grades_DAL
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM grades",
                conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                $"Error retrieving grade data: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetById(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                "SELECT * FROM grades WHERE id = @id",
                conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                $"Error retrieving grade data: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            } 
        }
    }
}
