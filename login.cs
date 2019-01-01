using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kalki
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection("");
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-29L8K3O\\SQLEXPRESS;Initial Catalog=kalki_project;Integrated Security=True");
        
            string Password = "";
            bool IsExist = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from user_login where UserName='" + bunifuMaterialTextbox1.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(2);  //get the user password from db if the user name is exist in that.  
                IsExist = true;
            }
            con.Close();
            if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
            {
                if (encode.Decrypt(Password).Equals(bunifuMaterialTextbox2.Text))
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else  //showing the error message if user credential is wrong  
            {
                MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
            
        }
    }

