using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int ident;
        public Form2(int ident)
        {
            InitializeComponent();
            this.ident = ident;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = ident.ToString();
        }
    }
}
