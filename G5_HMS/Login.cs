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

namespace G5_HMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MyConnection DB = new MyConnection();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("role_login", DB.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    DB.connection.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBox_LoginID.Text));
                    cmd.Parameters.AddWithValue("@pass", textBox_LoginPassword.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        MessageBox.Show("Redirecting to you Account 😊", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rd.Read();
                        if (rd[2].ToString() == "1")
                        {
                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();
                            this.Hide();
                        }
                        else if (rd[2].ToString() == "2")
                        {
                            //user is doctor
                            MessageBox.Show("Redirecting to you Account 😊 \n\r You must be the doctor", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rd.Read();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credential", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Something wentwrong in Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.connection.Close();
                }
            }
            
        }

        private void textBox_LoginID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LoginID.Text))
            {
                e.Cancel = true;
                textBox_LoginID.Focus();
                errorProvider1.SetError(textBox_LoginID, "ID is missing");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_LoginID, null);
            }
        }

        private void textBox_LoginPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_LoginPassword.Text))
            {
                e.Cancel = true;
                textBox_LoginPassword.Focus();
                errorProvider2.SetError(textBox_LoginPassword, "Password is missing");
            }
            else
            {
                //e.Cancel = false;
                errorProvider2.SetError(textBox_LoginPassword, null);
            }
        }
    }
}
