using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kalki
{
    public partial class employee_mgmt : UserControl
    {
        public static int id = 0;
        private static employee_mgmt obj1;

        public static employee_mgmt Instance
        {
            get
            {
                if (obj1 == null)
                    obj1 = new employee_mgmt();
                return obj1;
            }
        }
        public employee_mgmt()
        {
            InitializeComponent();
        }

       /* private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-29L8K3O\\SQLEXPRESS;Initial Catalog=kalki_project;Integrated Security=True");

            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "")  //validating the fields whether the fields or empty or not  
            {
                if (bunifuMaterialTextbox2.Text.ToString().Trim().ToLower() == bunifuMaterialTextbox3.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    
                    string UserName = bunifuMaterialTextbox1.Text;
                    string Password = encode.Encrypt(bunifuMaterialTextbox2.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    con.Open();
                    SqlCommand insert = new SqlCommand("insert into user_login(user_id,username,password)values('" + UserName + "','" + Password + "')", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
            }

        }*/

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-29L8K3O\\SQLEXPRESS;Initial Catalog=kalki_project;Integrated Security=True");

            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "" && bunifuMaterialTextbox3.Text != "")  //validating the fields whether the fields or empty or not  
            {
                //insert a verification form
                if (bunifuMaterialTextbox2.Text.ToString().Trim().ToLower() == bunifuMaterialTextbox3.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {

                    string UserName = bunifuMaterialTextbox1.Text;
                    string Password = encode.Encrypt(bunifuMaterialTextbox2.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    con.Open();
                    SqlCommand insert = new SqlCommand("insert into user_login(username,password)values('" + UserName + "','" + Password + "')", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
            }
        }
    }
}
