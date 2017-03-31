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

namespace PrivateBrowser
{   
    public partial class ResetForm : Form
    {
       
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj Haraniya\documents\visual studio 2015\Projects\PrivateBrowser\PrivateBrowser\ClickDB.mdf;Integrated Security=True");
        int X, Y;
        public ResetForm()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs position = (MouseEventArgs)e;
            X = position.X;
            Y = position.Y;
            clickImage.Visible = true;
            clickImage.Location = new Point(X+122-10,Y+24-10);
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }

        private void ResetForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Resetting the password will remove everything from History and Favourites !","Caution !",MessageBoxButtons.OK);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ClickDB SET X="+X+",Y="+Y+" WHERE POS=101;",cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Your Picture Password(click) saved successfully","Done !",MessageBoxButtons.OK);
            saveButton.Visible = false;

            cn.Open();
            SqlCommand hcmd = new SqlCommand("DELETE FROM History",cn);
            hcmd.ExecuteNonQuery();
            cn.Close();

            cn.Open();
            SqlCommand fcmd = new SqlCommand("DELETE FROM Fav", cn);
            fcmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
