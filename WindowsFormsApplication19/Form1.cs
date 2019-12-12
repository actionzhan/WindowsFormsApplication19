using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {

        List<int>[] TT;
        public Form1()
        {
            InitializeComponent();
            TT = new List<int>[1] {new List<int>()};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TT[0] == null)
            {
                MessageBox.Show("NULL");
            }
            else
            {
                MessageBox.Show("OK");
            }
        }

        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("11");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();//123
        }
    }
}
