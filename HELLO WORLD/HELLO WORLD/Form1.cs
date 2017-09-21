using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FRMHELLOWORLD : Form
    {
        public FRMHELLOWORLD()
        {
            InitializeComponent();
        }

        private void BTNSHOW_Click(object sender, EventArgs e)
        {
            LBLHELLOWORLD.Text = "HELLO WORLD !";
        }
    }
}
