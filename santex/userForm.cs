using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace santex
{
    public partial class userForm : Form
    {
        DBconnector connector = new DBconnector();
        private void loadDataUsers()
        {
            connector.OpenConnection();
            string cmd = "SELECT * FROM tasks";
            SqlCommand com = new SqlCommand(cmd, connector.getConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter adpter = new SqlDataAdapter(com);
            adpter.Fill(dt);
            TaskData.DataSource = dt;
            connector.CloseConnection();
        }
        public userForm()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
                connector.OpenConnection();
            if (TaskData.SelectedCells.Count != 0)
            {
                int row = TaskData.CurrentRow.Index;
                int id = Convert.ToInt32(TaskData.Rows[row].Cells["id"].Value);
                string cmd = "UPDATE tasks SET status = @status WHERE id = @id";
                SqlCommand com = new SqlCommand(cmd, connector.getConnection());
                com.Parameters.AddWithValue("@status", changeStatus.Text);
                com.Parameters.AddWithValue("@id", id);
                com.ExecuteNonQuery();
                connector.CloseConnection();
                loadDataUsers();
            }
                
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            loadDataUsers();
        }
    }
}
