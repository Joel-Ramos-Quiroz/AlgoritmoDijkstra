namespace AGENTE_UTILIDAD
{
    partial class AGENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGENTE));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MOVER_ROBOT = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnModificarDistancias = new System.Windows.Forms.Button();
            this.PictRobot = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtglistado = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictRobot)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "INICIO";
            // 
            // cmbInicio
            // 
            this.cmbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I"});
            this.cmbInicio.Location = new System.Drawing.Point(73, 13);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbInicio.TabIndex = 9;
            this.cmbInicio.SelectedIndexChanged += new System.EventHandler(this.cmbInicio_SelectedIndexChanged);
            // 
            // cmbFin
            // 
            this.cmbFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFin.FormattingEnabled = true;
            this.cmbFin.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I"});
            this.cmbFin.Location = new System.Drawing.Point(73, 40);
            this.cmbFin.Name = "cmbFin";
            this.cmbFin.Size = new System.Drawing.Size(121, 21);
            this.cmbFin.TabIndex = 11;
            this.cmbFin.SelectedIndexChanged += new System.EventHandler(this.cmbFin_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "FIN";
            // 
            // MOVER_ROBOT
            // 
            this.MOVER_ROBOT.Tick += new System.EventHandler(this.MOVER_Robot_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.btnModificarDistancias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 73);
            this.panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbInicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(385, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIniciar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Image = global::AGENTE_UTILIDAD.Properties.Resources.cronometro;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(12, 10);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(169, 44);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "RECORRER";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnModificarDistancias
            // 
            this.btnModificarDistancias.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarDistancias.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDistancias.ForeColor = System.Drawing.Color.Black;
            this.btnModificarDistancias.Image = global::AGENTE_UTILIDAD.Properties.Resources.editar;
            this.btnModificarDistancias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarDistancias.Location = new System.Drawing.Point(907, 3);
            this.btnModificarDistancias.Name = "btnModificarDistancias";
            this.btnModificarDistancias.Size = new System.Drawing.Size(191, 58);
            this.btnModificarDistancias.TabIndex = 12;
            this.btnModificarDistancias.Text = "Editar Distancias";
            this.btnModificarDistancias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarDistancias.UseVisualStyleBackColor = false;
            this.btnModificarDistancias.Visible = false;
            // 
            // PictRobot
            // 
            this.PictRobot.BackColor = System.Drawing.Color.Transparent;
            this.PictRobot.Image = global::AGENTE_UTILIDAD.Properties.Resources.vacuum_cleaner;
            this.PictRobot.Location = new System.Drawing.Point(50, 162);
            this.PictRobot.Name = "PictRobot";
            this.PictRobot.Size = new System.Drawing.Size(50, 41);
            this.PictRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictRobot.TabIndex = 4;
            this.PictRobot.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1012, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 29);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "LISTADO DE PESOS POR NODOS";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(1123, 45);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 27);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "ALEATORIO";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // dtglistado
            // 
            this.dtglistado.AllowUserToAddRows = false;
            this.dtglistado.AllowUserToDeleteRows = false;
            this.dtglistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistado.Location = new System.Drawing.Point(1026, 78);
            this.dtglistado.Name = "dtglistado";
            this.dtglistado.ReadOnly = true;
            this.dtglistado.Size = new System.Drawing.Size(262, 381);
            this.dtglistado.TabIndex = 21;
            // 
            // AGENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 554);
            this.Controls.Add(this.dtglistado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictRobot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AGENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EJERCICIO ASPIRADORA";
            this.Load += new System.EventHandler(this.AGENTE_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictRobot)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        internal System.Windows.Forms.PictureBox PictRobot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.ComboBox cmbFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer MOVER_ROBOT;
        private System.Windows.Forms.Button btnModificarDistancias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtglistado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

