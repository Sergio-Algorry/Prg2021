using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWhile
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void btPosicion_Click(object sender, EventArgs e)
        {
            ActorRojo.Top = 70;
            ActorAzul.Top = 70;
            ActorRojo.Visible = true;
            ActorAzul.Visible = true;
        }

        private void btMover_Click(object sender, EventArgs e)
        {
            while ((ActorRojo.Left + ActorRojo.Width) != ActorAzul.Left)
            {
                ActorRojo.Left = ActorRojo.Left + 1;
                ActorAzul.Left = ActorAzul.Left - 1;
                this.Refresh();

                
            }


            //while (true)
            //{
            //    ActorRojo.Left = ActorRojo.Left + 1;
            //    ActorAzul.Left = ActorAzul.Left - 1;

            //    this.Refresh();

            //    if((ActorRojo.Left+ActorRojo.Width) == ActorAzul.Left)
            //    {
            //        break;
            //    }
            //}
        }

        private void btPosicion_MouseMove(object sender, MouseEventArgs e)
        {
            btPosicion.Left = btPosicion.Left + 50;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
