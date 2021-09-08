
namespace PruebaDoWhile
{
    partial class Form1
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
            this.btMover = new System.Windows.Forms.Button();
            this.AR = new System.Windows.Forms.Label();
            this.AZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMover
            // 
            this.btMover.Location = new System.Drawing.Point(318, 13);
            this.btMover.Name = "btMover";
            this.btMover.Size = new System.Drawing.Size(75, 23);
            this.btMover.TabIndex = 0;
            this.btMover.Text = "Mover";
            this.btMover.UseVisualStyleBackColor = true;
            this.btMover.Click += new System.EventHandler(this.btMover_Click);
            // 
            // AR
            // 
            this.AR.BackColor = System.Drawing.Color.Red;
            this.AR.Location = new System.Drawing.Point(60, 75);
            this.AR.Name = "AR";
            this.AR.Size = new System.Drawing.Size(100, 100);
            this.AR.TabIndex = 1;
            // 
            // AZ
            // 
            this.AZ.BackColor = System.Drawing.Color.Blue;
            this.AZ.Location = new System.Drawing.Point(710, 103);
            this.AZ.Name = "AZ";
            this.AZ.Size = new System.Drawing.Size(40, 40);
            this.AZ.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 199);
            this.Controls.Add(this.AZ);
            this.Controls.Add(this.AR);
            this.Controls.Add(this.btMover);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMover;
        private System.Windows.Forms.Label AR;
        private System.Windows.Forms.Label AZ;
    }
}

