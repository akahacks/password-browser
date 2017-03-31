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
    public partial class WebBrowser : Form
    {
        HistoryDisplay hd = new HistoryDisplay();
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj Haraniya\documents\visual studio 2015\Projects\PrivateBrowser\PrivateBrowser\ClickDB.mdf;Integrated Security=True");
        public WebBrowser()
        {
            InitializeComponent();
        }

        public void goButton_Click(object sender, EventArgs e)
        {
            browserWindow.Navigate(comboBox1.Text);
            comboBox1.Items.Add(comboBox1.Text);
            cn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO History (History) VALUES ('"+comboBox1.Text+"')", cn);
            cmd.ExecuteNonQuery();
            cn.Close();

           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            browserWindow.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            browserWindow.GoForward();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            hd.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            browserWindow.Navigate("https://www.google.co.in/#q=+"+textBox1.Text+"+");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand addfv = new SqlCommand("INSERT INTO Fav (Fav) VALUES ('"+comboBox1.Text+"')",cn);
            addfv.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Successfully Added To Fav's ","Done",MessageBoxButtons.OK);
        }

        private void Favourite_Click(object sender, EventArgs e)
        {
            FavDisplay fd = new FavDisplay();
            fd.ShowDialog();
        }
    }
}
