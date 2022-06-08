namespace Registro_Pacientes
{
    partial class FormClients
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
            this.grbo_Users = new System.Windows.Forms.GroupBox();
            this.bton_Borrar = new System.Windows.Forms.Button();
            this.dt_combox = new System.Windows.Forms.DateTimePicker();
            this.bton_Cancelar = new System.Windows.Forms.Button();
            this.bton_Guardar = new System.Windows.Forms.Button();
            this.lbl_Creationdate = new System.Windows.Forms.Label();
            this.combox_Genero = new System.Windows.Forms.ComboBox();
            this.lbl_Usertype = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Fullname = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.dtgv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.grbo_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // grbo_Users
            // 
            this.grbo_Users.Controls.Add(this.bton_Borrar);
            this.grbo_Users.Controls.Add(this.dt_combox);
            this.grbo_Users.Controls.Add(this.bton_Cancelar);
            this.grbo_Users.Controls.Add(this.bton_Guardar);
            this.grbo_Users.Controls.Add(this.lbl_Creationdate);
            this.grbo_Users.Controls.Add(this.combox_Genero);
            this.grbo_Users.Controls.Add(this.lbl_Usertype);
            this.grbo_Users.Controls.Add(this.txt_Apellido);
            this.grbo_Users.Controls.Add(this.lbl_Password);
            this.grbo_Users.Controls.Add(this.txt_Telefono);
            this.grbo_Users.Controls.Add(this.lbl_Fullname);
            this.grbo_Users.Controls.Add(this.txt_Nombre);
            this.grbo_Users.Controls.Add(this.lbl_User);
            this.grbo_Users.Controls.Add(this.txt_ID);
            this.grbo_Users.Controls.Add(this.lbl_ID);
            this.grbo_Users.Font = new System.Drawing.Font("Gadugi", 11F);
            this.grbo_Users.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbo_Users.Location = new System.Drawing.Point(3, 108);
            this.grbo_Users.Name = "grbo_Users";
            this.grbo_Users.Size = new System.Drawing.Size(354, 575);
            this.grbo_Users.TabIndex = 0;
            this.grbo_Users.TabStop = false;
            this.grbo_Users.Text = "Create Appointments:";
            // 
            // bton_Borrar
            // 
            this.bton_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_Borrar.Location = new System.Drawing.Point(235, 500);
            this.bton_Borrar.Name = "bton_Borrar";
            this.bton_Borrar.Size = new System.Drawing.Size(107, 36);
            this.bton_Borrar.TabIndex = 9;
            this.bton_Borrar.Text = "Delete";
            this.bton_Borrar.UseVisualStyleBackColor = true;
            this.bton_Borrar.Click += new System.EventHandler(this.bton_Borrar_Click);
            // 
            // dt_combox
            // 
            this.dt_combox.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dt_combox.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dt_combox.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dt_combox.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dt_combox.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dt_combox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_combox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.dt_combox.Location = new System.Drawing.Point(39, 449);
            this.dt_combox.MaxDate = new System.DateTime(2034, 12, 31, 0, 0, 0, 0);
            this.dt_combox.MinDate = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            this.dt_combox.Name = "dt_combox";
            this.dt_combox.Size = new System.Drawing.Size(289, 32);
            this.dt_combox.TabIndex = 6;
            this.dt_combox.Value = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            // 
            // bton_Cancelar
            // 
            this.bton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_Cancelar.Location = new System.Drawing.Point(122, 500);
            this.bton_Cancelar.Name = "bton_Cancelar";
            this.bton_Cancelar.Size = new System.Drawing.Size(107, 36);
            this.bton_Cancelar.TabIndex = 8;
            this.bton_Cancelar.Text = "Cancelar";
            this.bton_Cancelar.UseVisualStyleBackColor = true;
            this.bton_Cancelar.Click += new System.EventHandler(this.bton_Cancelar_Click);
            // 
            // bton_Guardar
            // 
            this.bton_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_Guardar.Location = new System.Drawing.Point(9, 500);
            this.bton_Guardar.Name = "bton_Guardar";
            this.bton_Guardar.Size = new System.Drawing.Size(107, 36);
            this.bton_Guardar.TabIndex = 7;
            this.bton_Guardar.Text = "Guardar";
            this.bton_Guardar.UseVisualStyleBackColor = true;
            this.bton_Guardar.Click += new System.EventHandler(this.bton_Guardar_Click);
            // 
            // lbl_Creationdate
            // 
            this.lbl_Creationdate.AutoSize = true;
            this.lbl_Creationdate.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_Creationdate.Location = new System.Drawing.Point(35, 426);
            this.lbl_Creationdate.Name = "lbl_Creationdate";
            this.lbl_Creationdate.Size = new System.Drawing.Size(49, 20);
            this.lbl_Creationdate.TabIndex = 10;
            this.lbl_Creationdate.Text = "Date:";
            // 
            // combox_Genero
            // 
            this.combox_Genero.Font = new System.Drawing.Font("Gadugi", 10F);
            this.combox_Genero.FormattingEnabled = true;
            this.combox_Genero.Items.AddRange(new object[] {
            "Men",
            "Woman",
            "Prefer not said"});
            this.combox_Genero.Location = new System.Drawing.Point(39, 368);
            this.combox_Genero.Name = "combox_Genero";
            this.combox_Genero.Size = new System.Drawing.Size(239, 28);
            this.combox_Genero.TabIndex = 5;
            // 
            // lbl_Usertype
            // 
            this.lbl_Usertype.AutoSize = true;
            this.lbl_Usertype.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_Usertype.Location = new System.Drawing.Point(35, 345);
            this.lbl_Usertype.Name = "lbl_Usertype";
            this.lbl_Usertype.Size = new System.Drawing.Size(69, 20);
            this.lbl_Usertype.TabIndex = 8;
            this.lbl_Usertype.Text = "Gender:";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Font = new System.Drawing.Font("Gadugi", 10F);
            this.txt_Apellido.Location = new System.Drawing.Point(39, 218);
            this.txt_Apellido.MaxLength = 20;
            this.txt_Apellido.Multiline = true;
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(239, 29);
            this.txt_Apellido.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_Password.Location = new System.Drawing.Point(35, 195);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(90, 20);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Last Name";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Gadugi", 10F);
            this.txt_Telefono.Location = new System.Drawing.Point(39, 292);
            this.txt_Telefono.MaxLength = 20;
            this.txt_Telefono.Multiline = true;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(239, 29);
            this.txt_Telefono.TabIndex = 4;
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.AutoSize = true;
            this.lbl_Fullname.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_Fullname.Location = new System.Drawing.Point(35, 269);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.Size = new System.Drawing.Size(62, 20);
            this.lbl_Fullname.TabIndex = 4;
            this.lbl_Fullname.Text = "Phone:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Gadugi", 10F);
            this.txt_Nombre.Location = new System.Drawing.Point(39, 143);
            this.txt_Nombre.MaxLength = 20;
            this.txt_Nombre.Multiline = true;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(239, 29);
            this.txt_Nombre.TabIndex = 2;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_User.Location = new System.Drawing.Point(35, 120);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(90, 20);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "Full Name:";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Gadugi", 10F);
            this.txt_ID.Location = new System.Drawing.Point(39, 69);
            this.txt_ID.MaxLength = 20;
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(239, 29);
            this.txt_ID.TabIndex = 1;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbl_ID.Location = new System.Drawing.Point(35, 46);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(28, 20);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Id:";
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgv_ID,
            this.dtgv_Name,
            this.Last_Name,
            this.dtgv_Phone,
            this.dtgv_Gender,
            this.dtgv_Date});
            this.DGV.Location = new System.Drawing.Point(363, 164);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(834, 519);
            this.DGV.TabIndex = 0;
            // 
            // dtgv_ID
            // 
            this.dtgv_ID.HeaderText = "Id";
            this.dtgv_ID.MaxInputLength = 2;
            this.dtgv_ID.MinimumWidth = 6;
            this.dtgv_ID.Name = "dtgv_ID";
            this.dtgv_ID.ReadOnly = true;
            this.dtgv_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_ID.Width = 125;
            // 
            // dtgv_Name
            // 
            this.dtgv_Name.HeaderText = "Name";
            this.dtgv_Name.MaxInputLength = 20;
            this.dtgv_Name.MinimumWidth = 6;
            this.dtgv_Name.Name = "dtgv_Name";
            this.dtgv_Name.ReadOnly = true;
            this.dtgv_Name.Width = 125;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.MaxInputLength = 20;
            this.Last_Name.MinimumWidth = 6;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 125;
            // 
            // dtgv_Phone
            // 
            this.dtgv_Phone.HeaderText = "Phone";
            this.dtgv_Phone.MinimumWidth = 6;
            this.dtgv_Phone.Name = "dtgv_Phone";
            this.dtgv_Phone.Width = 125;
            // 
            // dtgv_Gender
            // 
            this.dtgv_Gender.HeaderText = "Gender";
            this.dtgv_Gender.MinimumWidth = 6;
            this.dtgv_Gender.Name = "dtgv_Gender";
            this.dtgv_Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtgv_Gender.Width = 125;
            // 
            // dtgv_Date
            // 
            this.dtgv_Date.HeaderText = "Date";
            this.dtgv_Date.MinimumWidth = 6;
            this.dtgv_Date.Name = "dtgv_Date";
            this.dtgv_Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dtgv_Date.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(363, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "View Appointments:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Appointments Clients";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lbl_Info.ForeColor = System.Drawing.Color.White;
            this.lbl_Info.Location = new System.Drawing.Point(966, 108);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 24);
            this.lbl_Info.TabIndex = 5;
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1209, 695);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.grbo_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.grbo_Users.ResumeLayout(false);
            this.grbo_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbo_Users;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox combox_Genero;
        private System.Windows.Forms.Label lbl_Usertype;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label lbl_Fullname;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button bton_Cancelar;
        private System.Windows.Forms.Button bton_Guardar;
        private System.Windows.Forms.Label lbl_Creationdate;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DateTimePicker dt_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bton_Borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgv_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgv_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgv_Date;
        private System.Windows.Forms.Label lbl_Info;
    }
}