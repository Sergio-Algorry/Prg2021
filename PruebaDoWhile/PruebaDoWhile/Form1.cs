using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMover_Click(object sender, EventArgs e)
        {
            do
            {
                AR.Left = AR.Left + 1;
                AZ.Left = AZ.Left - 1;

                this.Refresh();

            } while (AR.Left+AR.Width !=  AZ.Left);
        }
    }
}
