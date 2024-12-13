namespace church_management_system
{
    partial class LoginForm
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
            panel1 = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            btnLogin = new Button();
            txtUser = new TextBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 55);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.WhiteSmoke;
            btnClose.ForeColor = Color.IndianRed;
            btnClose.Location = new Point(963, 9);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 3;
            btnClose.Text = "❌";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "CMS | Church Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 545);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(98, 303);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.WhiteSmoke;
            txtUser.Location = new Point(98, 212);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 23);
            txtUser.TabIndex = 3;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtUser);
            panel3.Location = new Point(404, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 400);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(120, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(98, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(175, 23);
            txtPassword.TabIndex = 3;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Login - CMS";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private Button btnClose;
        private Button btnLogin;
        private TextBox txtUser;
        private Panel panel3;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}
