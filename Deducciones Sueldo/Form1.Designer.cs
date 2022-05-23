namespace Deducciones_Sueldo
{
    partial class Form1
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
            this.bton_Calcular = new System.Windows.Forms.Button();
            this.txt_SueldoB = new System.Windows.Forms.TextBox();
            this.lbl_Bienvenidos = new System.Windows.Forms.Label();
            this.lbl_Sueldo = new System.Windows.Forms.Label();
            this.lbl_AFP = new System.Windows.Forms.Label();
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.lbl_SFS = new System.Windows.Forms.Label();
            this.txt_SFS = new System.Windows.Forms.TextBox();
            this.lbl_ISR = new System.Windows.Forms.Label();
            this.txt_ISR = new System.Windows.Forms.TextBox();
            this.lbl_Descuentos = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SueldoN = new System.Windows.Forms.TextBox();
            this.lbl_SueldoN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bton_Calcular
            // 
            this.bton_Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bton_Calcular.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_Calcular.Location = new System.Drawing.Point(378, 419);
            this.bton_Calcular.Name = "bton_Calcular";
            this.bton_Calcular.Size = new System.Drawing.Size(150, 52);
            this.bton_Calcular.TabIndex = 2;
            this.bton_Calcular.Text = "Calcular";
            this.bton_Calcular.UseVisualStyleBackColor = true;
            this.bton_Calcular.Click += new System.EventHandler(this.bton_Calcular_Click);
            // 
            // txt_SueldoB
            // 
            this.txt_SueldoB.AcceptsTab = true;
            this.txt_SueldoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SueldoB.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SueldoB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SueldoB.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.txt_SueldoB.Location = new System.Drawing.Point(212, 150);
            this.txt_SueldoB.MaxLength = 7;
            this.txt_SueldoB.Multiline = true;
            this.txt_SueldoB.Name = "txt_SueldoB";
            this.txt_SueldoB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SueldoB.Size = new System.Drawing.Size(212, 27);
            this.txt_SueldoB.TabIndex = 1;
            this.txt_SueldoB.Text = "\r\n";
            this.txt_SueldoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SueldoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SueldoB_KeyPress);
            // 
            // lbl_Bienvenidos
            // 
            this.lbl_Bienvenidos.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenidos.Location = new System.Drawing.Point(251, 21);
            this.lbl_Bienvenidos.Name = "lbl_Bienvenidos";
            this.lbl_Bienvenidos.Size = new System.Drawing.Size(431, 41);
            this.lbl_Bienvenidos.TabIndex = 2;
            this.lbl_Bienvenidos.Text = "Deducciones de Sueldo";
            // 
            // lbl_Sueldo
            // 
            this.lbl_Sueldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sueldo.AutoSize = true;
            this.lbl_Sueldo.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sueldo.Location = new System.Drawing.Point(12, 150);
            this.lbl_Sueldo.Name = "lbl_Sueldo";
            this.lbl_Sueldo.Size = new System.Drawing.Size(186, 26);
            this.lbl_Sueldo.TabIndex = 3;
            this.lbl_Sueldo.Text = "Ingrese Sueldo:";
            // 
            // lbl_AFP
            // 
            this.lbl_AFP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_AFP.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AFP.Location = new System.Drawing.Point(582, 218);
            this.lbl_AFP.Name = "lbl_AFP";
            this.lbl_AFP.Size = new System.Drawing.Size(66, 27);
            this.lbl_AFP.TabIndex = 5;
            this.lbl_AFP.Text = "AFP:";
            // 
            // txt_AFP
            // 
            this.txt_AFP.AcceptsTab = true;
            this.txt_AFP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AFP.BackColor = System.Drawing.SystemColors.Window;
            this.txt_AFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AFP.Enabled = false;
            this.txt_AFP.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.txt_AFP.Location = new System.Drawing.Point(648, 218);
            this.txt_AFP.MaxLength = 7;
            this.txt_AFP.Multiline = true;
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_AFP.Size = new System.Drawing.Size(199, 23);
            this.txt_AFP.TabIndex = 4;
            this.txt_AFP.Text = "\r\n";
            this.txt_AFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SFS
            // 
            this.lbl_SFS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SFS.AutoSize = true;
            this.lbl_SFS.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SFS.Location = new System.Drawing.Point(582, 283);
            this.lbl_SFS.Name = "lbl_SFS";
            this.lbl_SFS.Size = new System.Drawing.Size(56, 26);
            this.lbl_SFS.TabIndex = 7;
            this.lbl_SFS.Text = "SFS:";
            // 
            // txt_SFS
            // 
            this.txt_SFS.AcceptsTab = true;
            this.txt_SFS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SFS.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SFS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SFS.Enabled = false;
            this.txt_SFS.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.txt_SFS.Location = new System.Drawing.Point(648, 283);
            this.txt_SFS.MaxLength = 7;
            this.txt_SFS.Multiline = true;
            this.txt_SFS.Name = "txt_SFS";
            this.txt_SFS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SFS.Size = new System.Drawing.Size(199, 26);
            this.txt_SFS.TabIndex = 6;
            this.txt_SFS.Text = "\r\n";
            this.txt_SFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ISR
            // 
            this.lbl_ISR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ISR.AutoSize = true;
            this.lbl_ISR.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISR.Location = new System.Drawing.Point(587, 347);
            this.lbl_ISR.Name = "lbl_ISR";
            this.lbl_ISR.Size = new System.Drawing.Size(55, 26);
            this.lbl_ISR.TabIndex = 9;
            this.lbl_ISR.Text = "ISR:";
            // 
            // txt_ISR
            // 
            this.txt_ISR.AcceptsTab = true;
            this.txt_ISR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ISR.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ISR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ISR.Enabled = false;
            this.txt_ISR.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.txt_ISR.Location = new System.Drawing.Point(648, 347);
            this.txt_ISR.MaxLength = 7;
            this.txt_ISR.Multiline = true;
            this.txt_ISR.Name = "txt_ISR";
            this.txt_ISR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ISR.Size = new System.Drawing.Size(199, 23);
            this.txt_ISR.TabIndex = 8;
            this.txt_ISR.Text = "\r\n";
            this.txt_ISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Descuentos
            // 
            this.lbl_Descuentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Descuentos.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuentos.Location = new System.Drawing.Point(563, 149);
            this.lbl_Descuentos.Name = "lbl_Descuentos";
            this.lbl_Descuentos.Size = new System.Drawing.Size(293, 27);
            this.lbl_Descuentos.TabIndex = 10;
            this.lbl_Descuentos.Text = "Descuento aplicados:";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(12, 512);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 23);
            this.lbl_Hora.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sueldo con deducciones aplicadas:";
            // 
            // txt_SueldoN
            // 
            this.txt_SueldoN.AcceptsTab = true;
            this.txt_SueldoN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SueldoN.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SueldoN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SueldoN.Enabled = false;
            this.txt_SueldoN.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.txt_SueldoN.Location = new System.Drawing.Point(179, 343);
            this.txt_SueldoN.MaxLength = 7;
            this.txt_SueldoN.Multiline = true;
            this.txt_SueldoN.Name = "txt_SueldoN";
            this.txt_SueldoN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SueldoN.Size = new System.Drawing.Size(234, 30);
            this.txt_SueldoN.TabIndex = 11;
            this.txt_SueldoN.Text = "\r\n";
            this.txt_SueldoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_SueldoN
            // 
            this.lbl_SueldoN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SueldoN.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoN.Location = new System.Drawing.Point(12, 347);
            this.lbl_SueldoN.Name = "lbl_SueldoN";
            this.lbl_SueldoN.Size = new System.Drawing.Size(186, 26);
            this.lbl_SueldoN.TabIndex = 12;
            this.lbl_SueldoN.Text = "Sueldo Neto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(900, 547);
            this.Controls.Add(this.lbl_AFP);
            this.Controls.Add(this.txt_SueldoB);
            this.Controls.Add(this.txt_SueldoN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_Descuentos);
            this.Controls.Add(this.lbl_ISR);
            this.Controls.Add(this.txt_ISR);
            this.Controls.Add(this.lbl_SFS);
            this.Controls.Add(this.txt_SFS);
            this.Controls.Add(this.txt_AFP);
            this.Controls.Add(this.lbl_Bienvenidos);
            this.Controls.Add(this.bton_Calcular);
            this.Controls.Add(this.lbl_Sueldo);
            this.Controls.Add(this.lbl_SueldoN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bton_Calcular;
        private System.Windows.Forms.TextBox txt_SueldoB;
        private System.Windows.Forms.Label lbl_Bienvenidos;
        private System.Windows.Forms.Label lbl_Sueldo;
        private System.Windows.Forms.Label lbl_AFP;
        private System.Windows.Forms.TextBox txt_AFP;
        private System.Windows.Forms.Label lbl_SFS;
        private System.Windows.Forms.TextBox txt_SFS;
        private System.Windows.Forms.Label lbl_ISR;
        private System.Windows.Forms.TextBox txt_ISR;
        private System.Windows.Forms.Label lbl_Descuentos;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SueldoN;
        private System.Windows.Forms.Label lbl_SueldoN;
    }
}

