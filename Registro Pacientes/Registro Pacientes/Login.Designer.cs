namespace Registro_Pacientes
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
            this.bton_Acceder = new System.Windows.Forms.Button();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.bton_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bton_Acceder
            // 
            this.bton_Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bton_Acceder.Font = new System.Drawing.Font("Gadugi", 11.2F);
            this.bton_Acceder.ForeColor = System.Drawing.Color.White;
            this.bton_Acceder.Location = new System.Drawing.Point(111, 485);
            this.bton_Acceder.Name = "bton_Acceder";
            this.bton_Acceder.Size = new System.Drawing.Size(112, 40);
            this.bton_Acceder.TabIndex = 3;
            this.bton_Acceder.Text = "Acceder";
            this.bton_Acceder.UseVisualStyleBackColor = false;
            this.bton_Acceder.Click += new System.EventHandler(this.bton_Acceder_Click);
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Gadugi", 13.2F);
            this.lbl_Usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Usuario.Location = new System.Drawing.Point(85, 224);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(90, 26);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contraseña.Font = new System.Drawing.Font("Gadugi", 13.2F);
            this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contraseña.Location = new System.Drawing.Point(85, 332);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(126, 26);
            this.lbl_contraseña.TabIndex = 0;
            this.lbl_contraseña.Text = "Contraseña:";
            // 
            // bton_Cancelar
            // 
            this.bton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bton_Cancelar.Font = new System.Drawing.Font("Gadugi", 11.2F);
            this.bton_Cancelar.ForeColor = System.Drawing.Color.White;
            this.bton_Cancelar.Location = new System.Drawing.Point(244, 485);
            this.bton_Cancelar.Name = "bton_Cancelar";
            this.bton_Cancelar.Size = new System.Drawing.Size(112, 40);
            this.bton_Cancelar.TabIndex = 4;
            this.bton_Cancelar.Text = "Cancelar";
            this.bton_Cancelar.UseVisualStyleBackColor = false;
            this.bton_Cancelar.Click += new System.EventHandler(this.bton_Cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(90, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 3);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(90, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 3);
            this.panel2.TabIndex = 9;
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Gadugi", 11.2F);
            this.txt_User.ForeColor = System.Drawing.Color.White;
            this.txt_User.Location = new System.Drawing.Point(90, 268);
            this.txt_User.Margin = new System.Windows.Forms.Padding(5);
            this.txt_User.MaxLength = 20;
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(332, 20);
            this.txt_User.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Gadugi", 11.2F);
            this.txt_Password.ForeColor = System.Drawing.Color.White;
            this.txt_Password.Location = new System.Drawing.Point(93, 380);
            this.txt_Password.MaxLength = 20;
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(332, 22);
            this.txt_Password.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Registro_Pacientes.Properties.Resources.logo_intec_lnin73;
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(513, 571);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bton_Cancelar);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.bton_Acceder);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bton_Acceder;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Button bton_Cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
    }
}