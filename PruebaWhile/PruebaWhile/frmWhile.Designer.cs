﻿
namespace PruebaWhile
{
    partial class frmWhile
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
            this.btPosicion = new System.Windows.Forms.Button();
            this.ActorRojo = new System.Windows.Forms.Label();
            this.ActorAzul = new System.Windows.Forms.Label();
            this.btMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPosicion
            // 
            this.btPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPosicion.Location = new System.Drawing.Point(155, 12);
            this.btPosicion.Name = "btPosicion";
            this.btPosicion.Size = new System.Drawing.Size(100, 40);
            this.btPosicion.TabIndex = 0;
            this.btPosicion.Text = "Acomodar";
            this.btPosicion.UseVisualStyleBackColor = true;
            this.btPosicion.Click += new System.EventHandler(this.btPosicion_Click);
            // 
            // ActorRojo
            // 
            this.ActorRojo.BackColor = System.Drawing.Color.Red;
            this.ActorRojo.Location = new System.Drawing.Point(195, 100);
            this.ActorRojo.Name = "ActorRojo";
            this.ActorRojo.Size = new System.Drawing.Size(60, 60);
            this.ActorRojo.TabIndex = 1;
            this.ActorRojo.Visible = false;
            // 
            // ActorAzul
            // 
            this.ActorAzul.BackColor = System.Drawing.Color.Blue;
            this.ActorAzul.Location = new System.Drawing.Point(669, 26);
            this.ActorAzul.Name = "ActorAzul";
            this.ActorAzul.Size = new System.Drawing.Size(100, 30);
            this.ActorAzul.TabIndex = 2;
            this.ActorAzul.Visible = false;
            // 
            // btMover
            // 
            this.btMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMover.Location = new System.Drawing.Point(502, 12);
            this.btMover.Name = "btMover";
            this.btMover.Size = new System.Drawing.Size(100, 40);
            this.btMover.TabIndex = 3;
            this.btMover.Text = "Mover";
            this.btMover.UseVisualStyleBackColor = true;
            this.btMover.Click += new System.EventHandler(this.btMover_Click);
            // 
            // frmWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 205);
            this.Controls.Add(this.btMover);
            this.Controls.Add(this.ActorAzul);
            this.Controls.Add(this.ActorRojo);
            this.Controls.Add(this.btPosicion);
            this.Name = "frmWhile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPosicion;
        private System.Windows.Forms.Label ActorRojo;
        private System.Windows.Forms.Label ActorAzul;
        private System.Windows.Forms.Button btMover;
    }
}
