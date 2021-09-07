
namespace Operadoes
{
    partial class frmInicial
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblVariable = new System.Windows.Forms.Label();
            this.btOpLog = new System.Windows.Forms.Button();
            this.btCorto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(43, 23);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(164, 45);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar ++";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(61, 93);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 31);
            this.lblResultado.TabIndex = 1;
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariable.Location = new System.Drawing.Point(61, 152);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(0, 31);
            this.lblVariable.TabIndex = 2;
            // 
            // btOpLog
            // 
            this.btOpLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btOpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpLog.Location = new System.Drawing.Point(231, 23);
            this.btOpLog.Name = "btOpLog";
            this.btOpLog.Size = new System.Drawing.Size(164, 45);
            this.btOpLog.TabIndex = 3;
            this.btOpLog.Text = "Op. lógica";
            this.btOpLog.UseVisualStyleBackColor = true;
            this.btOpLog.Click += new System.EventHandler(this.btOpLog_Click);
            // 
            // btCorto
            // 
            this.btCorto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCorto.Location = new System.Drawing.Point(416, 23);
            this.btCorto.Name = "btCorto";
            this.btCorto.Size = new System.Drawing.Size(198, 45);
            this.btCorto.TabIndex = 4;
            this.btCorto.Text = "Op. Y Corto";
            this.btCorto.UseVisualStyleBackColor = true;
            this.btCorto.Click += new System.EventHandler(this.btCorto_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 221);
            this.Controls.Add(this.btCorto);
            this.Controls.Add(this.btOpLog);
            this.Controls.Add(this.lblVariable);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btAceptar);
            this.Name = "frmInicial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Button btOpLog;
        private System.Windows.Forms.Button btCorto;
    }
}

