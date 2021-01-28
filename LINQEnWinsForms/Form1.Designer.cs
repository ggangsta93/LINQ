namespace LINQEnWinsForms
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
            this.txtXML = new System.Windows.Forms.TextBox();
            this.Adicion = new System.Windows.Forms.GroupBox();
            this.Busqueda = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtAdicionar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.Adicion.SuspendLayout();
            this.Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(12, 12);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXML.Size = new System.Drawing.Size(647, 189);
            this.txtXML.TabIndex = 0;
            // 
            // Adicion
            // 
            this.Adicion.Controls.Add(this.txtAdicionar);
            this.Adicion.Controls.Add(this.label3);
            this.Adicion.Controls.Add(this.txtCalificacion);
            this.Adicion.Controls.Add(this.label2);
            this.Adicion.Controls.Add(this.txtCurso);
            this.Adicion.Controls.Add(this.label1);
            this.Adicion.Controls.Add(this.txtNombre);
            this.Adicion.Location = new System.Drawing.Point(12, 207);
            this.Adicion.Name = "Adicion";
            this.Adicion.Size = new System.Drawing.Size(200, 164);
            this.Adicion.TabIndex = 1;
            this.Adicion.TabStop = false;
            this.Adicion.Text = "Adicion";
            // 
            // Busqueda
            // 
            this.Busqueda.Controls.Add(this.btnBuscar);
            this.Busqueda.Controls.Add(this.label4);
            this.Busqueda.Controls.Add(this.txtBusqueda);
            this.Busqueda.Location = new System.Drawing.Point(218, 207);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(200, 164);
            this.Busqueda.TabIndex = 2;
            this.Busqueda.TabStop = false;
            this.Busqueda.Text = "Busqueda";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(94, 60);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCurso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Calificacion:";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(94, 86);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Curso:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(94, 34);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 9;
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(94, 135);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(100, 23);
            this.txtAdicionar.TabIndex = 3;
            this.txtAdicionar.Text = "Adicionar";
            this.txtAdicionar.UseVisualStyleBackColor = true;
            this.txtAdicionar.Click += new System.EventHandler(this.txtAdicionar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(94, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(436, 241);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 23);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 383);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.Adicion);
            this.Controls.Add(this.txtXML);
            this.Name = "Form1";
            this.Text = "XML ";
            this.Adicion.ResumeLayout(false);
            this.Adicion.PerformLayout();
            this.Busqueda.ResumeLayout(false);
            this.Busqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.GroupBox Adicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox Busqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button txtAdicionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCargar;
    }
}

