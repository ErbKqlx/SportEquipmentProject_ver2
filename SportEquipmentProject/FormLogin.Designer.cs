using System.DirectoryServices.ActiveDirectory;

namespace SportEquipmentProject
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnMain = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            pbLogo = new PictureBox();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(lblPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lblLogin);
            pnMain.Location = new Point(35, 118);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(315, 231);
            pnMain.TabIndex = 1;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(67, 97, 238);
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(82, 180);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(150, 30);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 97, 238);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(82, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(32, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(128, 81);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(58, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(32, 47);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 26);
            txtLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(131, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 19);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = Properties.Resources.Sports_Line_Logo_Vector;
            pbLogo.Location = new Point(142, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnMain;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtLogin;
        private Label lblLogin;
        private PictureBox pbLogo;
    }
}
