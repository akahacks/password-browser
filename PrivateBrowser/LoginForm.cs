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
    public partial class LoginForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj Haraniya\documents\visual studio 2015\Projects\PrivateBrowser\PrivateBrowser\ClickDB.mdf;Integrated Security=True");
        int loginX, loginY;
        int X, Y;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetForm rf = new ResetForm();
            rf.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs position = (MouseEventArgs)e;
            loginX = position.X;
            loginY = position.Y;
            clickImageLogin.Visible = true;
            clickImageLogin.Location = new Point(loginX + 122 - 10, loginY + 24 - 10);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            SqlCommand fetchX = new SqlCommand("SELECT X FROM ClickDB", cn);
            SqlDataReader drX = fetchX.ExecuteReader();
            while (drX.Read())
            {
                X = int.Parse(drX[0].ToString());
            }
            cn.Close();

            cn.Open();
            SqlCommand fetchY = new SqlCommand("SELECT Y FROM ClickDB", cn);
            SqlDataReader drY = fetchY.ExecuteReader();
            while (drY.Read())
            {
                Y = int.Parse(drY[0].ToString());
            }
            cn.Close();

            if(X-10 < loginX && loginX < X+10 && Y-10 < loginY && loginY < Y+10)
            {
                this.Hide();
                WebBrowser wb = new WebBrowser();
                wb.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed !");
            }
            
        }
    }
}
