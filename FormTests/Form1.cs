using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.panel1.Controls.Add(this.secondpanel);
            //this.firstpanel.Dock = System.Windows.Forms.DockStyle.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.panel1.Controls.Contains(firstpanel))
            {
                panel1.Controls.Remove(secondpanel);
                panel1.Controls.Add(firstpanel);
                //panel1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.panel1.Controls.Contains(secondpanel))
            {
                panel1.Controls.Remove(firstpanel);
                panel1.Controls.Add(secondpanel);
                //panel1.Refresh();
            }
        }
    }
}
