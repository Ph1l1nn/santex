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
    public partial class Form1 : Form
    {
        string user_role;
        int user_id;
        public Form1()
        {
            InitializeComponent();
        }
        DBconnector connection = new DBconnector();

        private string getRole()
        {
            string loginin = login.Text;
            string passwordin = password.Text;
            connection.OpenConnection();
            string com = "SELECT user_role,user_id FROM users WHERE [user]=@log AND [password]=@pass";
            SqlCommand cmd = new SqlCommand(com, connection.getConnection());
            cmd.Parameters.AddWithValue("@log", loginin);
            cmd.Parameters.AddWithValue("@pass", passwordin);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user_role = reader["user_role"].ToString();
                user_id = Convert.ToInt32(reader["user_id"].ToString());
            }
            reader.Close();
            connection.CloseConnection();
            return user_role;
        }


        private void login_TextChanged(object sender, EventArgs e)
        {




        }

        private void tonext_Click(object sender, EventArgs e)
        {
            string user = "";
            user = getRole();
           if (user == "admin")
            {
                adminForm admin = new adminForm(user_id);
                admin.Show();
                this.Hide();
            }
           else if (user == "user")
            {
                userForm userr = new userForm();
                userr.Show(); 
                this.Hide();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
