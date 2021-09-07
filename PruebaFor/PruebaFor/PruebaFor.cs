using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaFor
{
    public partial class PruebaFor : Form
    {
        private int pepe = 0;
        public PruebaFor()
        {
            InitializeComponent();

            Prueba vari = new Prueba();

            txtX.Text =$"pepe de vari(clase Prueba)= {vari.pepe.ToString()} \r\n pepe de PruebaFor = {this.pepe}";
            vari.Incrementa();
            textBox1.Text = $"pepe de vari(clase Prueba)= {vari.pepe.ToString()}";

            textBox2.Text = $"Resultado Metodo Decrementa(clase Prueba)= {vari.Decrementa().ToString()}";
        }

        private void btArranque_Click(object sender, EventArgs e)
        {
            int x = System.Convert.ToInt32( txtX.Text);
            lbl.Visible = true;

            for (  ; ; )
            {
                lbl.Left = x;
                x = x + 2;
                this.Refresh();
                if(x >= 500)
                {
                    break;
                }
            }

            //for (; x < 500;)
            //{
            //    lbl.Left = x;
            //    x = x + 2;
            //    this.Refresh();
            //}

            //for ( ; x < 500; x++)
            //{
            //    lbl.Left = x;
            //    this.Refresh();
            //}

            //for (int i = x; i < 500; i++)
            //{
            //    lbl.Left = i;
            //    this.Refresh();
            //}

            //for (int i = 0; i < 500; i++)
            //{
            //    lbl.Left = i;
            //    this.Refresh();
            //}
        }
    }

    public class Prueba
    {
        public int pepe;
        public Prueba()
        {
            pepe = 100;
        }

        public void Incrementa()
        {
            pepe = pepe + 800;
        }

        public int Decrementa()
        {
            int y = pepe - 400;
            return y;
            //return pepe - 400;
        }
    }
}
