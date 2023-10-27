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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ID;
        private void btn_connecter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-F1RSPUR\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=123456");
            cn.Open();

            SqlCommand com = new SqlCommand("select * from Utilisateur where loginUser='" +txt_login.Text + "'", cn);
            SqlDataReader dr = com.ExecuteReader();
            bool passport = false;
            if (dr.Read())
            {
                if (dr["passwdUser"].ToString() == txt_password.Text)
                {
                    passport = true;
                    ID = Convert.ToInt32(dr["ident"].ToString());
                }
            }
            if (passport)
            {
                this.Hide();
                Form2 f = new Form2(ID);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("login ou mot de pass est incorrect", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
