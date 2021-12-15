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
    public partial class updatePass : Form
    {
        public updatePass()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool checkOldpass()
        {
            MyConnection DB = new MyConnection();
            SqlCommand cmd;
            int ans = -1;
            try
            {
                cmd = new SqlCommand("SELECT COUNT(*) FROM user_table WHERE user_id=@id AND user_pass=@currPass", DB.connection);
                DB.connection.Open();
                cmd.Parameters.AddWithValue("@id", MyConnection.CurrentUserID);
                cmd.Parameters.AddWithValue("@currPass", textBox1.Text);
                SqlDataReader sdr = cmd.ExecuteReader();
                ans =int.Parse(sdr.GetValue(0).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.connection.Close();
            }
            if (ans == 1)
                return true;
            else
                return false;
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            MyConnection DB = new MyConnection();
            //SqlCommand cmd;
            try
            {
                string updatepass = "UPDATE user_table SET user_pass=@newpass WHERE user_id=@id";
                DB.connection.Open();
                SqlCommand newcmd = new SqlCommand(updatepass, DB.connection);
                newcmd.Parameters.AddWithValue("@id", MyConnection.CurrentUserID);
                newcmd.Parameters.AddWithValue("@newpass", textBox2.Text);
                newcmd.ExecuteNonQuery();
                DB.connection.Close();
                MessageBox.Show("Password Updated");                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.connection.Close();
            }
        }
    }
}
