using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            #region codigo de If
            //if (txtOperacion.Text == "+")
            //{
            //    int op1 = System.Convert.ToInt32(txtOp1.Text);
            //    int op2 = System.Convert.ToInt32(txtOp2.Text);
            //    int res = op1 + op2;

            //    txtResultado.Text = res.ToString();
            //}
            //else if (txtOperacion.Text == "-")
            //{
            //    int op1 = System.Convert.ToInt32(txtOp1.Text);
            //    int op2 = System.Convert.ToInt32(txtOp2.Text);
            //    int res = op1 - op2;

            //    txtResultado.Text = res.ToString();
            //}
            //else
            //{
            //    txtResultado.Text="ERROR";
            //}
            #endregion

            #region SWITCH
            //int op1;
            //int op2;
            //int res;
            decimal op2;
            decimal res;
            decimal op1;
            op1 = System.Convert.ToInt32(txtOp1.Text);
            op2 = System.Convert.ToInt32(txtOp2.Text);

            switch (txtOperacion.Text)
            {
                case "+":
                    res = op1 + op2;
                    break;
                case "-":
                    res = op1 - op2;
                    break;
                case "*":
                    res = op1 * op2;
                    break;
                case "/":
                    res = op1 / op2;
                    break;
                default:
                    res = -99999999;
                    //txtResultado.Text = "ERROR";
                    break;
            }
            if(res == -99999999)
            {
                txtResultado.Text = "ERROR";
            }
            else
            {
                txtResultado.Text = res.ToString();
            }
            #endregion
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "CLICK";
        }
    }
}
