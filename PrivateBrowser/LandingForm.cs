using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateBrowser
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By : Raj Haraniya \nVersion : 1.0","Private Browser v1.0",MessageBoxButtons.OK);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetForm rf = new ResetForm();
            rf.ShowDialog();
            this.Close();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LandingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
