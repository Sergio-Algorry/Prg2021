using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btConversion_Click(null, null);
        }

        private void btConversion_Click(object sender, System.EventArgs e)
        {
            string CadenaResultado;
            int Posicion;

            lblOrigen.Text = txtDatoCadena.Text;

            Posicion = txtDatoCadena.Text.IndexOf("Pepe");

            CadenaResultado = System.Convert.ToString(Posicion);

            lblResultado.Text = CadenaResultado;
        }
    }
}
