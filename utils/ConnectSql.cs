using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Machine_vision_GUI.utils
{
    public class ConnectSql
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string str = @"Data Source=DESKTOP-GRDVNF6\SQLEXPRESS;Initial Catalog=SQLITEM;Integrated Security=True";
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable dt = null;
        private object dateTime;

        public ConnectSql()
        {
            // Khởi tạo đối tượng SqlConnection
            connection = new SqlConnection(str);
        }

        // Phương thức mở kết nối
        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        // Phương thức đóng kết nối
        private void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // Phương thức tải dữ liệu
        public DataTable LoadData()
        {
            dt = new DataTable();
            OpenConnection();

            using (command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM ItemDb";
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);
            }

            CloseConnection();
            return dt;
        }
        public void AddData(string itemName, DateTime datetime, string status)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                // Get the current maximum ID from the database
                string getMaxIdQuery = "SELECT ISNULL(MAX(ID), 0) + 1 FROM ItemDb";
                using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection))
                {
                    int newId = (int)getMaxIdCommand.ExecuteScalar();

                    // Insert the new record with the new ID
                    string insertQuery = "INSERT INTO ItemDb (ID, ItemName, Time, Status) VALUES (@ID, @ItemName, @Time, @Status)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ID", newId);
                        insertCommand.Parameters.AddWithValue("@ItemName", itemName);
                        insertCommand.Parameters.AddWithValue("@Time", datetime);
                        insertCommand.Parameters.AddWithValue("@Status", status);

                        insertCommand.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }
        public void UpdateDataGridView(DataGridView dataGridView)
        {
            DataTable dt = LoadData();
            dataGridView.DataSource = dt;
        }
    }
}

