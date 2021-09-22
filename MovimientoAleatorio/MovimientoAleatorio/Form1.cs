using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoAleatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            int sentidoV = 1;
            int sentidoH = 1;
            int pasoV = 1;
            int pasoH = 1;

            Random randoPaso = new Random();
            Random randoSentido = new Random();
            int j = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i > 10 * j)
                {
                    sentidoH = randoSentido.Next(-1, 2);
                    sentidoV = randoSentido.Next(-1, 2);
                    j = j + 1;
                }
                pasoH = randoPaso.Next(0, 3);
                pasoV = randoPaso.Next(0, 3);

                lbl.Left = lbl.Left + (pasoH * sentidoH);
                lbl.Top = lbl.Top + (pasoV * sentidoV);
                this.Refresh();
            }
        }
    }
}
