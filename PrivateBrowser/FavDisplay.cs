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
    public partial class FavDisplay : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj Haraniya\documents\visual studio 2015\Projects\PrivateBrowser\PrivateBrowser\ClickDB.mdf;Integrated Security=True");
        
        public FavDisplay()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FavDisplay_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand fav = new SqlCommand("SELECT Fav FROM Fav", cn);
            SqlDataReader fv = fav.ExecuteReader();
            while (fv.Read())
            {
                richTextBox1.Text += fv[0].ToString() + "\n";
            }
            cn.Close();
        }
    }
}
