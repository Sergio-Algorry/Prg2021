
namespace PruebaFor
{
    partial class PruebaFor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btArranque = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btArranque
            // 
            this.btArranque.Location = new System.Drawing.Point(700, 39);
            this.btArranque.Name = "btArranque";
            this.btArranque.Size = new System.Drawing.Size(75, 23);
            this.btArranque.TabIndex = 0;
            this.btArranque.Text = "Arranque";
            this.btArranque.UseVisualStyleBackColor = true;
            this.btArranque.Click += new System.EventHandler(this.btArranque_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(0, 59);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(20, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Visible = false;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(3, 23);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(691, 20);
            this.txtX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Posición Inicial";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(691, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(691, 20);
            this.textBox2.TabIndex = 5;
            // 
            // PruebaFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btArranque);
            this.Name = "PruebaFor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btArranque;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

