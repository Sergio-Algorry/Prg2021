
namespace EjemploListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.btMostrar = new System.Windows.Forms.Button();
            this.txtNac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btFiltro = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btCargar
            // 
            this.btCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargar.Location = new System.Drawing.Point(425, 34);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(88, 30);
            this.btCargar.TabIndex = 3;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(27, 410);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(72, 31);
            this.lblLista.TabIndex = 3;
            this.lblLista.Text = "Lista";
            // 
            // btMostrar
            // 
            this.btMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrar.Location = new System.Drawing.Point(425, 108);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(88, 30);
            this.btMostrar.TabIndex = 4;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // txtNac
            // 
            this.txtNac.Location = new System.Drawing.Point(255, 40);
            this.txtNac.Name = "txtNac";
            this.txtNac.Size = new System.Drawing.Size(62, 20);
            this.txtNac.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año Nac.";
            // 
            // btFiltro
            // 
            this.btFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltro.Location = new System.Drawing.Point(519, 108);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(127, 30);
            this.btFiltro.TabIndex = 7;
            this.btFiltro.Text = "Mostrar con Filtro";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(519, 71);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(86, 31);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(425, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(517, 34);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(88, 30);
            this.btBorrar.TabIndex = 10;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(33, 77);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(386, 150);
            this.dg.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.txtNac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.TextBox txtNac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.DataGridView dg;
    }
}

