namespace ExcelLinq
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ss_Principal = new System.Windows.Forms.StatusStrip();
            this.sl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_Empresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.tt_Descripcion = new System.Windows.Forms.ToolTip(this.components);
            this.ms_Principal = new System.Windows.Forms.MenuStrip();
            this.ts_Sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_reiniciarsesion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Acerca = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ss_Principal.SuspendLayout();
            this.ms_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(35, 149);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 351);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Datos";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(243, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sueldo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(297, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Datos";
            this.groupBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(206, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Buscar";
            this.tt_Descripcion.SetToolTip(this.button2, "Buscar registro ");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(81, 33);
            this.txtbuscar.MaxLength = 30;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Buscar:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Buscar";
            // 
            // ss_Principal
            // 
            this.ss_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl_usuario,
            this.sl_Empresa,
            this.sl_fecha,
            this.sl_hora});
            this.ss_Principal.Location = new System.Drawing.Point(0, 532);
            this.ss_Principal.Name = "ss_Principal";
            this.ss_Principal.Padding = new System.Windows.Forms.Padding(2, 0, 32, 0);
            this.ss_Principal.Size = new System.Drawing.Size(784, 30);
            this.ss_Principal.TabIndex = 10;
            this.ss_Principal.Text = "statusStrip1";
            // 
            // sl_usuario
            // 
            this.sl_usuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sl_usuario.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_usuario.Name = "sl_usuario";
            this.sl_usuario.Size = new System.Drawing.Size(187, 25);
            this.sl_usuario.Spring = true;
            this.sl_usuario.Text = "Usuario :";
            // 
            // sl_Empresa
            // 
            this.sl_Empresa.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sl_Empresa.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sl_Empresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_Empresa.Name = "sl_Empresa";
            this.sl_Empresa.Size = new System.Drawing.Size(187, 25);
            this.sl_Empresa.Spring = true;
            this.sl_Empresa.Text = "Control de Permisos";
            // 
            // sl_fecha
            // 
            this.sl_fecha.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sl_fecha.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sl_fecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_fecha.Name = "sl_fecha";
            this.sl_fecha.Size = new System.Drawing.Size(187, 25);
            this.sl_fecha.Spring = true;
            this.sl_fecha.Text = "Fecha:";
            // 
            // sl_hora
            // 
            this.sl_hora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sl_hora.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.sl_hora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_hora.Name = "sl_hora";
            this.sl_hora.Size = new System.Drawing.Size(187, 25);
            this.sl_hora.Spring = true;
            this.sl_hora.Text = "Hora:";
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // ms_Principal
            // 
            this.ms_Principal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ms_Principal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Sistema,
            this.ts_Mantenimiento});
            this.ms_Principal.Location = new System.Drawing.Point(0, 0);
            this.ms_Principal.Name = "ms_Principal";
            this.ms_Principal.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.ms_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ms_Principal.Size = new System.Drawing.Size(784, 39);
            this.ms_Principal.TabIndex = 11;
            this.ms_Principal.Text = "menuStrip1";
            // 
            // ts_Sistema
            // 
            this.ts_Sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_reiniciarsesion,
            this.toolStripSeparator3,
            this.ts_Acerca,
            this.toolStripSeparator4,
            this.ts_Salir});
            this.ts_Sistema.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Sistema.ForeColor = System.Drawing.Color.Black;
            this.ts_Sistema.Name = "ts_Sistema";
            this.ts_Sistema.Size = new System.Drawing.Size(87, 29);
            this.ts_Sistema.Text = "Sistema";
            // 
            // ts_reiniciarsesion
            // 
            this.ts_reiniciarsesion.ForeColor = System.Drawing.Color.Black;
            this.ts_reiniciarsesion.Image = global::ExcelLinq.Properties.Resources.Tatice_Cristal_Intense_Reload;
            this.ts_reiniciarsesion.Name = "ts_reiniciarsesion";
            this.ts_reiniciarsesion.Size = new System.Drawing.Size(212, 30);
            this.ts_reiniciarsesion.Text = "&Reiniciar Sesión";
            this.ts_reiniciarsesion.ToolTipText = "Vuelve a la pantalla de login";
            this.ts_reiniciarsesion.Click += new System.EventHandler(this.ts_reiniciarsesion_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // ts_Acerca
            // 
            this.ts_Acerca.ForeColor = System.Drawing.Color.Black;
            this.ts_Acerca.Image = global::ExcelLinq.Properties.Resources.Hopstarter_Gloss_Mac_Get_Info;
            this.ts_Acerca.Name = "ts_Acerca";
            this.ts_Acerca.Size = new System.Drawing.Size(212, 30);
            this.ts_Acerca.Text = "&Acerca de...";
            this.ts_Acerca.ToolTipText = "Informacion del sistema";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // ts_Salir
            // 
            this.ts_Salir.ForeColor = System.Drawing.Color.Black;
            this.ts_Salir.Image = global::ExcelLinq.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_window_close;
            this.ts_Salir.Name = "ts_Salir";
            this.ts_Salir.Size = new System.Drawing.Size(212, 30);
            this.ts_Salir.Text = "&Salir";
            this.ts_Salir.ToolTipText = "Salir del sistema";
            this.ts_Salir.Click += new System.EventHandler(this.ts_Salir_Click);
            // 
            // ts_Mantenimiento
            // 
            this.ts_Mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.nuevoRegistroToolStripMenuItem});
            this.ts_Mantenimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Mantenimiento.ForeColor = System.Drawing.Color.Black;
            this.ts_Mantenimiento.Name = "ts_Mantenimiento";
            this.ts_Mantenimiento.Size = new System.Drawing.Size(90, 29);
            this.ts_Mantenimiento.Text = "Registro";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::ExcelLinq.Properties.Resources.Hopstarter_Soft_Scraps_Button_Upload;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.usuariosToolStripMenuItem.Text = "&Cargar Lista";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.Image = global::ExcelLinq.Properties.Resources.Hopstarter_Button_Button_Add;
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.nuevoRegistroToolStripMenuItem.Text = "&Nuevo Registro";
            this.nuevoRegistroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRegistroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ms_Principal);
            this.Controls.Add(this.ss_Principal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Control de Permisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ss_Principal.ResumeLayout(false);
            this.ss_Principal.PerformLayout();
            this.ms_Principal.ResumeLayout(false);
            this.ms_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip ss_Principal;
        private System.Windows.Forms.ToolStripStatusLabel sl_usuario;
        private System.Windows.Forms.ToolStripStatusLabel sl_Empresa;
        private System.Windows.Forms.ToolStripStatusLabel sl_fecha;
        private System.Windows.Forms.ToolStripStatusLabel sl_hora;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.ToolTip tt_Descripcion;
        private System.Windows.Forms.MenuStrip ms_Principal;
        private System.Windows.Forms.ToolStripMenuItem ts_Sistema;
        private System.Windows.Forms.ToolStripMenuItem ts_reiniciarsesion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ts_Acerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ts_Salir;
        private System.Windows.Forms.ToolStripMenuItem ts_Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
    }
}

