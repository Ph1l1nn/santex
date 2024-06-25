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

namespace santex
{
    public partial class adminForm : Form
    { 
        DBconnector connector = new DBconnector();
        private int iduser;
        public adminForm(int id)
        {
            InitializeComponent();
            iduser = id;
        }
        private void loadDataUsers()
        {
            connector.OpenConnection();
            string cmd = "SELECT * FROM users";
            SqlCommand com = new SqlCommand(cmd, connector.getConnection());
            DataTable dt = new DataTable();
            SqlDataAdapter adpter = new SqlDataAdapter(com);
            adpter.Fill(dt); 
            UserData.DataSource = dt;
            connector.CloseConnection();
        }
        private void adminForm_Load(object sender, EventArgs e)
        {
            loadDataUsers();
            loadTasks();
            label1.Text = iduser.ToString();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            connector.OpenConnection();
            string cmd = "INSERT INTO users([user],password,user_role) VALUES(@user, @password, @role)";
            SqlCommand com = new SqlCommand(cmd, connector.getConnection());
            com.Parameters.AddWithValue("@user", name.Text);
            com.Parameters.AddWithValue("@password", pass.Text);
            com.Parameters.AddWithValue("@role", role.Text);
            com.ExecuteNonQuery();
            connector.CloseConnection();
            loadDataUsers() ;
        }

        private void del_Click(object sender, EventArgs e)
        {
            connector.OpenConnection();
            if (UserData.SelectedCells.Count != 0)
            {
                int row = UserData.CurrentRow.Index;
                int id = Convert.ToInt32(UserData.Rows[row].Cells["user_id"].Value);
                UserData.Rows.RemoveAt(row);
                SqlCommand com = new SqlCommand("DELETE FROM users WHERE user_id = @click", connector.getConnection());
                com.Parameters.AddWithValue("@click", id);
                com.ExecuteNonQuery();

                

            }
            connector.CloseConnection();
        }
        private void loadTasks()
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

        private void TaskData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            connector.OpenConnection();
            string cmd = "INSERT INTO Tasks([user_id],[task],price,status,comm) VALUES(@user_id, @task, @price, @status, @comm)";
            SqlCommand com = new SqlCommand(cmd, connector.getConnection());
            com.Parameters.AddWithValue("@task", task.Text);
            com.Parameters.AddWithValue("@price", price.Text);
            com.Parameters.AddWithValue("@status", Status.Text);
            com.Parameters.AddWithValue("@user_id", iduser);
            com.Parameters.AddWithValue("@comm", comment.Text);
            com.ExecuteNonQuery();
            connector.CloseConnection();
            loadTasks();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        
                Form1 loginn = new Form1();
                loginn.Show();
                this.Close();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
