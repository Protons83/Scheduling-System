namespace Scheduling_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ForgotPassword = new LinkLabel();
            signUp = new LinkLabel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            studentSignIn = new Button();
            label3 = new Label();
            panel1 = new Panel();
            userPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            userPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-17, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1309, 850);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(19, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 43);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(19, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(456, 43);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 121);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // ForgotPassword
            // 
            ForgotPassword.AutoSize = true;
            ForgotPassword.Font = new Font("Segoe UI", 12F);
            ForgotPassword.LinkColor = Color.DarkBlue;
            ForgotPassword.Location = new Point(308, 207);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(167, 28);
            ForgotPassword.TabIndex = 6;
            ForgotPassword.TabStop = true;
            ForgotPassword.Text = "Forgot Password?";
            ForgotPassword.LinkClicked += ForgotPassword_LinkClicked;
            // 
            // signUp
            // 
            signUp.AutoSize = true;
            signUp.Font = new Font("Segoe UI", 12F);
            signUp.LinkColor = Color.DarkBlue;
            signUp.Location = new Point(19, 207);
            signUp.Name = "signUp";
            signUp.Size = new Size(82, 28);
            signUp.TabIndex = 8;
            signUp.TabStop = true;
            signUp.Text = "Sign Up";
            signUp.LinkClicked += signUp_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(20, 254);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 28);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(81, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(455, 107);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // studentSignIn
            // 
            studentSignIn.BackColor = SystemColors.InactiveCaption;
            studentSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentSignIn.Location = new Point(215, 515);
            studentSignIn.Name = "studentSignIn";
            studentSignIn.Size = new Size(198, 50);
            studentSignIn.TabIndex = 3;
            studentSignIn.Text = "SIGN IN";
            studentSignIn.UseVisualStyleBackColor = false;
            studentSignIn.Click += studentSignIn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 148);
            label3.Name = "label3";
            label3.Size = new Size(419, 28);
            label3.TabIndex = 7;
            label3.Text = "Welcome back! Please enter your credentials";
            // 
            // panel1
            // 
            panel1.Controls.Add(userPanel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(studentSignIn);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(344, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 586);
            panel1.TabIndex = 1;
            // 
            // userPanel
            // 
            userPanel.Controls.Add(linkLabel1);
            userPanel.Controls.Add(signUp);
            userPanel.Controls.Add(ForgotPassword);
            userPanel.Controls.Add(label2);
            userPanel.Controls.Add(label1);
            userPanel.Controls.Add(textBox2);
            userPanel.Controls.Add(textBox1);
            userPanel.Location = new Point(54, 200);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(498, 288);
            userPanel.TabIndex = 9;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1290, 808);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private LinkLabel ForgotPassword;
        private LinkLabel signUp;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Button studentSignIn;
        private Label label3;
        private Panel panel1;
        private Panel userPanel;
    }
}
