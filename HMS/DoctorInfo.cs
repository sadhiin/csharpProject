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

namespace HMS
{
    public partial class DoctorInfo : Form
    {
        public DoctorInfo()
        {
            InitializeComponent();
        }
//SQL connection
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9KAR832;Initial Catalog=hopitalMS;User ID=sa;Password=123456789");
        SqlCommand cmd;
        void openConnetion()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            else
                return;
        }
        void closeConnetion()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            else
                return;
        }
        void execuiteQuery(string query)
        {
            try
            {
                cmd = new SqlCommand(query, connection);
                openConnetion();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed Sussessfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closeConnetion();
                }
                else
                {
                    MessageBox.Show("Query not Executed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    closeConnetion();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Something wentwrong in ExcutedQueryFunction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnetion();
            }
        }
        void showData()
        {
            try
            {
                string myquery= "SELECT doc_id AS ID, doc_name AS Name, doc_gender AS Gender , doc_address AS Address , doc_email AS Email , doc_nid AS NID, doc_phone AS Phone , doc_schedule AS Schedule FROM Doctor_Table";
                cmd = new SqlCommand(myquery, connection);
                openConnetion();
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                closeConnetion();
                dataGridView_docInfo.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at ShowData", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnetion();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage adminpage = new AdminPage();
            adminpage.Show();
        }

        private void DoctorInfo_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Doctor_Table(doc_id,doc_name,doc_gender,doc_address,doc_phone,doc_email,doc_nid,doc_schedule) VALUES(@id,@name,@gender,@address,@phone,@email,@nid,@schedule)";
                cmd = new SqlCommand(insertQuery, connection);
                //"INSERT INTO sqcwT1(ID,Name,Contract,Age,DoB,Gender,Email,Address,NID,Country,Team) VALUES(@id,@name,@contract,@age,@dob,@gender,@email,@address,@nid,@country,@team)"
                cmd.Parameters.AddWithValue("@id", int.Parse(textBox_docID.Text));
                cmd.Parameters.AddWithValue("@name", textBox_docName.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox_docGender.Text);
                cmd.Parameters.AddWithValue("@address", textBox_docAddress.Text);
                cmd.Parameters.AddWithValue("@phone", textBox_docPhone.Text);
                cmd.Parameters.AddWithValue("@email", textBox_docEmail.Text);
                cmd.Parameters.AddWithValue("@nid", textBox_docNID.Text);
                cmd.Parameters.AddWithValue("@schedule", comboBox_docSchedule.Text);
                
                openConnetion();
                cmd.ExecuteNonQuery();
                closeConnetion();
                showData();
                MessageBox.Show("Successfully Data inserted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Something wentwrong in Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnetion();
            }
        }

        private void ClearText()
        {
            textBox_docID.Clear();
            textBox_docName.Clear();
            textBox_docEmail.Clear();
            comboBox_docGender.ResetText();
            textBox_docNID.Clear();
            textBox_docPhone.Clear();
            textBox_docAddress.Clear();
            comboBox_docSchedule.ResetText();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_docID.Text))
            {
                try
                {
                    string updatQuery = "UPDAT Doctor_Table SET doc_name=@name,doc_gender=@gender, doc_address=@address, doc_phone=@phone,doc_email=@email,doc_nid=@nid,doc_schedule=@schedule WHERE doc_id=@id";
                    cmd = new SqlCommand(updatQuery,connection);

                    cmd.Parameters.AddWithValue("@id", int.Parse(textBox_docID.Text));
                    cmd.Parameters.AddWithValue("@name", textBox_docName.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox_docGender.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_docAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", textBox_docPhone.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_docEmail.Text);
                    cmd.Parameters.AddWithValue("@nid", textBox_docNID.Text);
                    cmd.Parameters.AddWithValue("@schedule", comboBox_docSchedule.Text);
                    openConnetion();
                    cmd.ExecuteNonQuery();
                    closeConnetion();
                    showData();
                    MessageBox.Show("Successfully Data Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Something wentwrong in Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    closeConnetion();
                }
            }
            else
            {
                MessageBox.Show("Please Select any rows to update OR Inser an ID","Missing info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_docID.Text))
            {
                try
                {
                    cmd = new SqlCommand("DELETE Doctor_Table WHERE doc_id=@id ", connection);
                    cmd.Parameters.AddWithValue("@id", textBox_docID.Text);
                    openConnetion();
                    cmd.ExecuteNonQuery();
                    closeConnetion();
                    showData();
                    MessageBox.Show("Successfully Data Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Something wentwrong in Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    closeConnetion();
                }
            }
            else
            {
                MessageBox.Show("Unspacipied ID", "ID not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM sqcwT1 WHERE ID=@id", connection);
                cmd.Parameters.AddWithValue("@id", textBox_docID.Text);
                openConnetion();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                dataGridView_docInfo.DataSource = dt;
                closeConnetion();
                MessageBox.Show("Data Found..", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Something wentwrong in Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnetion();
            }
        }
    }
}
