namespace Sistema_gestor_de_Citas_Barberia
{
    partial class Citas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bton_Minimizar = new System.Windows.Forms.PictureBox();
            this.bton_Close = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Combox_Barbero = new System.Windows.Forms.ComboBox();
            this.DateTime_HoraC = new System.Windows.Forms.DateTimePicker();
            this.DateTime_Citas = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ApellidoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bton_Agregar = new System.Windows.Forms.Button();
            this.bton_visualizar = new System.Windows.Forms.Button();
            this.bton_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barberia = new Sistema_gestor_de_Citas_Barberia.Barberia();
            this.citasTableAdapter = new Sistema_gestor_de_Citas_Barberia.BarberiaTableAdapters.CitasTableAdapter();
            this.toolTipq = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bton_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bton_Close)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberia)).BeginInit();
            this.SuspendLayout();
            // 
            // bton_Minimizar
            // 
            this.bton_Minimizar.Image = global::Sistema_gestor_de_Citas_Barberia.Properties.Resources.minus;
            this.bton_Minimizar.Location = new System.Drawing.Point(1161, 0);
            this.bton_Minimizar.Name = "bton_Minimizar";
            this.bton_Minimizar.Size = new System.Drawing.Size(35, 40);
            this.bton_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bton_Minimizar.TabIndex = 12;
            this.bton_Minimizar.TabStop = false;
            this.bton_Minimizar.Click += new System.EventHandler(this.bton_Minimizar_Click);
            this.bton_Minimizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bton_Minimizar_MouseClick);
            // 
            // bton_Close
            // 
            this.bton_Close.Image = global::Sistema_gestor_de_Citas_Barberia.Properties.Resources.close;
            this.bton_Close.Location = new System.Drawing.Point(1208, 7);
            this.bton_Close.Name = "bton_Close";
            this.bton_Close.Size = new System.Drawing.Size(22, 22);
            this.bton_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bton_Close.TabIndex = 11;
            this.bton_Close.TabStop = false;
            this.bton_Close.Click += new System.EventHandler(this.bton_Close_Click);
            this.bton_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bton_Close_MouseClick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Combox_Barbero);
            this.groupBox.Controls.Add(this.DateTime_HoraC);
            this.groupBox.Controls.Add(this.DateTime_Citas);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.panel6);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.panel5);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.panel4);
            this.groupBox.Controls.Add(this.txt_Telefono);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.panel3);
            this.groupBox.Controls.Add(this.txt_ApellidoC);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Controls.Add(this.txt_Usuario);
            this.groupBox.Controls.Add(this.lbl_Usuario);
            this.groupBox.Controls.Add(this.panel2);
            this.groupBox.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(370, 647);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Gestor de Citas";
            // 
            // Combox_Barbero
            // 
            this.Combox_Barbero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Combox_Barbero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combox_Barbero.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combox_Barbero.FormattingEnabled = true;
            this.Combox_Barbero.Items.AddRange(new object[] {
            "Pedro",
            "Chepe",
            "Gus",
            "Manuel"});
            this.Combox_Barbero.Location = new System.Drawing.Point(10, 412);
            this.Combox_Barbero.Name = "Combox_Barbero";
            this.Combox_Barbero.Size = new System.Drawing.Size(288, 28);
            this.Combox_Barbero.TabIndex = 4;
            // 
            // DateTime_HoraC
            // 
            this.DateTime_HoraC.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_HoraC.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTime_HoraC.Location = new System.Drawing.Point(10, 595);
            this.DateTime_HoraC.MaxDate = new System.DateTime(2029, 12, 25, 21, 0, 0, 0);
            this.DateTime_HoraC.MinDate = new System.DateTime(2022, 6, 13, 9, 0, 0, 0);
            this.DateTime_HoraC.Name = "DateTime_HoraC";
            this.DateTime_HoraC.Size = new System.Drawing.Size(288, 30);
            this.DateTime_HoraC.TabIndex = 6;
            this.DateTime_HoraC.Value = new System.DateTime(2022, 6, 13, 9, 0, 0, 0);
            // 
            // DateTime_Citas
            // 
            this.DateTime_Citas.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Citas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTime_Citas.Location = new System.Drawing.Point(10, 506);
            this.DateTime_Citas.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.DateTime_Citas.MinDate = new System.DateTime(2022, 6, 24, 0, 0, 0, 0);
            this.DateTime_Citas.Name = "DateTime_Citas";
            this.DateTime_Citas.Size = new System.Drawing.Size(288, 30);
            this.DateTime_Citas.TabIndex = 5;
            this.DateTime_Citas.Value = new System.DateTime(2022, 6, 27, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NSimSun", 11.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora Cita:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(10, 623);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 5);
            this.panel6.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 11.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha Cita:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(10, 534);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 5);
            this.panel5.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 11.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Barbero:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 438);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 5);
            this.panel4.TabIndex = 17;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefono.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_Telefono.Location = new System.Drawing.Point(10, 313);
            this.txt_Telefono.MaxLength = 13;
            this.txt_Telefono.Multiline = true;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(288, 30);
            this.txt_Telefono.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 11.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefono";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 5);
            this.panel3.TabIndex = 14;
            // 
            // txt_ApellidoC
            // 
            this.txt_ApellidoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.txt_ApellidoC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ApellidoC.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApellidoC.ForeColor = System.Drawing.Color.Black;
            this.txt_ApellidoC.Location = new System.Drawing.Point(10, 210);
            this.txt_ApellidoC.MaxLength = 20;
            this.txt_ApellidoC.Multiline = true;
            this.txt_ApellidoC.Name = "txt_ApellidoC";
            this.txt_ApellidoC.Size = new System.Drawing.Size(288, 30);
            this.txt_ApellidoC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 11.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellido Cliente:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 5);
            this.panel1.TabIndex = 11;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_Usuario.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_Usuario.Location = new System.Drawing.Point(10, 112);
            this.txt_Usuario.MaxLength = 20;
            this.txt_Usuario.Multiline = true;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(288, 30);
            this.txt_Usuario.TabIndex = 1;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("NSimSun", 11.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_Usuario.Location = new System.Drawing.Point(6, 76);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(174, 20);
            this.lbl_Usuario.TabIndex = 9;
            this.lbl_Usuario.Text = "Nombre Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 5);
            this.panel2.TabIndex = 8;
            // 
            // bton_Agregar
            // 
            this.bton_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bton_Agregar.FlatAppearance.BorderSize = 0;
            this.bton_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(202)))), ((int)(((byte)(193)))));
            this.bton_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_Agregar.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.bton_Agregar.Location = new System.Drawing.Point(948, 111);
            this.bton_Agregar.Name = "bton_Agregar";
            this.bton_Agregar.Size = new System.Drawing.Size(129, 46);
            this.bton_Agregar.TabIndex = 13;
            this.bton_Agregar.Text = "Agregar";
            this.bton_Agregar.UseVisualStyleBackColor = false;
            this.bton_Agregar.Click += new System.EventHandler(this.bton_Agregar_Click);
            // 
            // bton_visualizar
            // 
            this.bton_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bton_visualizar.FlatAppearance.BorderSize = 0;
            this.bton_visualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_visualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(202)))), ((int)(((byte)(193)))));
            this.bton_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_visualizar.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.bton_visualizar.Location = new System.Drawing.Point(388, 108);
            this.bton_visualizar.Name = "bton_visualizar";
            this.bton_visualizar.Size = new System.Drawing.Size(418, 46);
            this.bton_visualizar.TabIndex = 14;
            this.bton_visualizar.Text = "Ver datos actualizados:";
            this.bton_visualizar.UseVisualStyleBackColor = false;
            this.bton_visualizar.Click += new System.EventHandler(this.bton_visualizar_Click);
            // 
            // bton_Eliminar
            // 
            this.bton_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_Eliminar.FlatAppearance.BorderSize = 0;
            this.bton_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(202)))), ((int)(((byte)(193)))));
            this.bton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_Eliminar.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.bton_Eliminar.Location = new System.Drawing.Point(1083, 111);
            this.bton_Eliminar.Name = "bton_Eliminar";
            this.bton_Eliminar.Size = new System.Drawing.Size(147, 46);
            this.bton_Eliminar.TabIndex = 15;
            this.bton_Eliminar.Tag = "Para eliminar llene el nombre con un nombre de algun cliente";
            this.bton_Eliminar.Text = "Eliminar";
            this.toolTipq.SetToolTip(this.bton_Eliminar, "Para eliminar una fila llene el campo Nombre Cliente");
            this.bton_Eliminar.UseVisualStyleBackColor = false;
            this.bton_Eliminar.Click += new System.EventHandler(this.bton_Eliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("NSimSun", 10.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.citasBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(399, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 472);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre_Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre_Cliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 163;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellidos_Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellidos_Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefono";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 109;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Barbero";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Barbero";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha_Cita";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha_Cita";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 127;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hora_Cita";
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Hora_Cita";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 118;
            // 
            // citasBindingSource
            // 
            this.citasBindingSource.DataMember = "Citas";
            this.citasBindingSource.DataSource = this.barberia;
            // 
            // barberia
            // 
            this.barberia.DataSetName = "Barberia";
            this.barberia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citasTableAdapter
            // 
            this.citasTableAdapter.ClearBeforeFill = true;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1268, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bton_Eliminar);
            this.Controls.Add(this.bton_visualizar);
            this.Controls.Add(this.bton_Agregar);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.bton_Minimizar);
            this.Controls.Add(this.bton_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bton_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bton_Close)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barberia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bton_Minimizar;
        private System.Windows.Forms.PictureBox bton_Close;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DateTime_HoraC;
        private System.Windows.Forms.DateTimePicker DateTime_Citas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_ApellidoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Combox_Barbero;
        private System.Windows.Forms.Button bton_Agregar;
        private System.Windows.Forms.Button bton_visualizar;
        private System.Windows.Forms.Button bton_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Barberia barberia;
        private System.Windows.Forms.BindingSource citasBindingSource;
        private BarberiaTableAdapters.CitasTableAdapter citasTableAdapter;
        private System.Windows.Forms.ToolTip toolTipq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}