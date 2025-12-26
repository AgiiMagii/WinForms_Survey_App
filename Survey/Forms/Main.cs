using Survey.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btn_toTestMng_Click(object sender, EventArgs e)
        {
            TestManagement testManagement = new TestManagement(this);
            testManagement.Show();
            testManagement.Location = this.Location;
            testManagement.Size = this.Size;
            this.Hide();

        }
    }
}
