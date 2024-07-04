using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C14_FormBD
{
    public partial class Form1 : Form
    {
        FormProductos fp;

        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fp = new FormProductos();   
            fp.ShowDialog();
        }
    }
}
