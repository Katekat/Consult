namespace WindowsFormsApplication2
{
    partial class frmPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Guardar = new System.Windows.Forms.ToolStripButton();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Salir = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCedula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTlf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ocupación = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dependencias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 79);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Guardar,
            this.Buscar,
            this.Editar,
            this.toolStripSeparator1,
            this.Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 75);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Guardar
            // 
            this.Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(104, 37);
            this.Guardar.Text = "Guardar";
            // 
            // Buscar
            // 
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(86, 37);
            this.Buscar.Text = "Buscar";
            // 
            // Editar
            // 
            this.Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(104, 37);
            this.Editar.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // Salir
            // 
            this.Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(104, 37);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(365, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(564, 158);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar por:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNombre,
            this.cApellido,
            this.cCedula,
            this.cTlf,
            this.Ocupación,
            this.cFecha,
            this.Dependencias});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 243);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(789, 271);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre";
            this.cNombre.Width = 127;
            // 
            // cApellido
            // 
            this.cApellido.Text = "Apellido";
            this.cApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cApellido.Width = 110;
            // 
            // cCedula
            // 
            this.cCedula.Text = "Cedula";
            this.cCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCedula.Width = 85;
            // 
            // cTlf
            // 
            this.cTlf.Text = "Tlf";
            this.cTlf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cTlf.Width = 86;
            // 
            // Ocupación
            // 
            this.Ocupación.Text = "Ocupación";
            this.Ocupación.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ocupación.Width = 98;
            // 
            // cFecha
            // 
            this.cFecha.Text = "Fecha Nac";
            this.cFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cFecha.Width = 111;
            // 
            // Dependencias
            // 
            this.Dependencias.Text = "Dependencias";
            this.Dependencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dependencias.Width = 177;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 541);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 35);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usuario: ";
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(821, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaciente";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Guardar;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cApellido;
        private System.Windows.Forms.ColumnHeader cCedula;
        private System.Windows.Forms.ColumnHeader cTlf;
        private System.Windows.Forms.ColumnHeader Ocupación;
        private System.Windows.Forms.ColumnHeader cFecha;
        private System.Windows.Forms.ColumnHeader Dependencias;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;

    }
}