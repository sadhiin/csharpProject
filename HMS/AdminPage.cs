using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button_Doctor_Click(object sender, EventArgs e)
        {
            DoctorInfo doctorInfo = new DoctorInfo();
            this.Hide();
            doctorInfo.Show();
        }
    }
}
