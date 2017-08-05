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
namespace Login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Student\Documents\database.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From login where Username='" + user_text + "' and Password = '" + pass_text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();

                Mainmenu ss = new Mainmenu();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Check your Username And Password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
