namespace mylogin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Msg;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_UserName.Location = new System.Drawing.Point(160, 25);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(52, 15);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Usuario:";

            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_UserName.Location = new System.Drawing.Point(160, 45);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(260, 24);
            this.txt_UserName.TabIndex = 2;

            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.Location = new System.Drawing.Point(160, 80);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(72, 15);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Contraseña:";

            // 
            // txt_PWD
            // 
            this.txt_PWD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_PWD.Location = new System.Drawing.Point(160, 100);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.PasswordChar = '*';
            this.txt_PWD.Size = new System.Drawing.Size(260, 24);
            this.txt_PWD.TabIndex = 4;

            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.login.Location = new System.Drawing.Point(160, 140);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 35);
            this.login.TabIndex = 5;
            this.login.Text = "Iniciar Sesión";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);

            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button2.Location = new System.Drawing.Point(295, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // lbl_Msg
            // 
            this.lbl_Msg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Msg.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Msg.Location = new System.Drawing.Point(20, 190);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(400, 45);
            this.lbl_Msg.TabIndex = 7;
            this.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 250);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txt_PWD);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema - Lab CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
