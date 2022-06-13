namespace Sistema_gestor_de_Citas_Barberia
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.bton_Ingresar = new System.Windows.Forms.Button();
            this.bton_Minimizar = new System.Windows.Forms.PictureBox();
            this.bton_Close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bton_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bton_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.lbl_Hora);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 576);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_Hora.Location = new System.Drawing.Point(21, 525);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 23);
            this.lbl_Hora.TabIndex = 1;
            this.lbl_Hora.Click += new System.EventHandler(this.lbl_Hora_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_gestor_de_Citas_Barberia.Properties.Resources.png_transparent_logo_brand_product_design_label_barber_men_label_logo_industry_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-46, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(499, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(499, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 5);
            this.panel3.TabIndex = 4;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_Usuario.Location = new System.Drawing.Point(495, 185);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(114, 23);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.lbl_Contraseña.Location = new System.Drawing.Point(495, 331);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(153, 23);
            this.lbl_Contraseña.TabIndex = 6;
            this.lbl_Contraseña.Text = "Contraseña:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.Font = new System.Drawing.Font("NSimSun", 13.8F);
            this.txt_Usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_Usuario.Location = new System.Drawing.Point(499, 246);
            this.txt_Usuario.Multiline = true;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(477, 30);
            this.txt_Usuario.TabIndex = 7;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contraseña.Font = new System.Drawing.Font("NSimSun", 13.8F);
            this.txt_Contraseña.ForeColor = System.Drawing.Color.Black;
            this.txt_Contraseña.Location = new System.Drawing.Point(499, 373);
            this.txt_Contraseña.Multiline = true;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(477, 30);
            this.txt_Contraseña.TabIndex = 8;
            this.txt_Contraseña.TextChanged += new System.EventHandler(this.txt_Contraseña_TextChanged);
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Font = new System.Drawing.Font("NSimSun", 25F, System.Drawing.FontStyle.Bold);
            this.lbl_Bienvenido.Location = new System.Drawing.Point(492, 62);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(414, 42);
            this.lbl_Bienvenido.TabIndex = 9;
            this.lbl_Bienvenido.Text = "Bienvenido usuario";
            // 
            // bton_Ingresar
            // 
            this.bton_Ingresar.FlatAppearance.BorderSize = 0;
            this.bton_Ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.bton_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(202)))), ((int)(((byte)(193)))));
            this.bton_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_Ingresar.Font = new System.Drawing.Font("NSimSun", 13.8F, System.Drawing.FontStyle.Bold);
            this.bton_Ingresar.Location = new System.Drawing.Point(614, 475);
            this.bton_Ingresar.Name = "bton_Ingresar";
            this.bton_Ingresar.Size = new System.Drawing.Size(236, 46);
            this.bton_Ingresar.TabIndex = 3;
            this.bton_Ingresar.Text = "Ingresar";
            this.bton_Ingresar.UseVisualStyleBackColor = true;
            this.bton_Ingresar.Click += new System.EventHandler(this.bton_Ingresar_Click);
            // 
            // bton_Minimizar
            // 
            this.bton_Minimizar.Image = global::Sistema_gestor_de_Citas_Barberia.Properties.Resources.minus;
            this.bton_Minimizar.Location = new System.Drawing.Point(1010, 5);
            this.bton_Minimizar.Name = "bton_Minimizar";
            this.bton_Minimizar.Size = new System.Drawing.Size(35, 40);
            this.bton_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bton_Minimizar.TabIndex = 2;
            this.bton_Minimizar.TabStop = false;
            this.bton_Minimizar.Click += new System.EventHandler(this.bton_Minimizar_Click);
            // 
            // bton_Close
            // 
            this.bton_Close.Image = global::Sistema_gestor_de_Citas_Barberia.Properties.Resources.close;
            this.bton_Close.Location = new System.Drawing.Point(1057, 12);
            this.bton_Close.Name = "bton_Close";
            this.bton_Close.Size = new System.Drawing.Size(22, 22);
            this.bton_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bton_Close.TabIndex = 1;
            this.bton_Close.TabStop = false;
            this.bton_Close.Click += new System.EventHandler(this.bton_Close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1091, 570);
            this.Controls.Add(this.bton_Ingresar);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bton_Minimizar);
            this.Controls.Add(this.bton_Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lbl_Hora_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bton_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bton_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.PictureBox bton_Close;
        private System.Windows.Forms.PictureBox bton_Minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_Bienvenido;
        private System.Windows.Forms.Button bton_Ingresar;
    }
}

