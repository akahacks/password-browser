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
    public partial class HistoryDisplay : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Raj Haraniya\documents\visual studio 2015\Projects\PrivateBrowser\PrivateBrowser\ClickDB.mdf;Integrated Security=True");
        public HistoryDisplay()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HistoryDisplay_Load(object sender, EventArgs e)
        {
           
            cn.Open();
            SqlCommand history = new SqlCommand("SELECT History FROM History",cn);
            SqlDataReader hs = history.ExecuteReader();
            while (hs.Read())
            {
                listBox1.Items.Add(hs[0].ToString() + "\n");
            }
            cn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand hcmd = new SqlCommand("DELETE FROM History", cn);
            hcmd.ExecuteNonQuery();
            cn.Close();
            listBox1.Items.Clear();
        }
    }
}
