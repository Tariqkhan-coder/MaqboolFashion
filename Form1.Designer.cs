namespace MaqboolFashion
{
    partial class registerbtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerbtn));
            label1 = new Label();
            emailbtn = new TextBox();
            label2 = new Label();
            passwordbtn = new TextBox();
            button1 = new Button();
            btnForgotPassword = new Button();
            regsiterbtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 94);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // emailbtn
            // 
            emailbtn.AccessibleName = "Email_btn";
            emailbtn.BorderStyle = BorderStyle.FixedSingle;
            emailbtn.ForeColor = Color.DimGray;
            emailbtn.Location = new Point(268, 87);
            emailbtn.Name = "emailbtn";
            emailbtn.Size = new Size(228, 27);
            emailbtn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 149);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Pasword";
            // 
            // passwordbtn
            // 
            passwordbtn.AccessibleName = "Password_btn";
            passwordbtn.BackColor = Color.WhiteSmoke;
            passwordbtn.BorderStyle = BorderStyle.FixedSingle;
            passwordbtn.ForeColor = Color.DimGray;
            passwordbtn.Location = new Point(268, 146);
            passwordbtn.Name = "passwordbtn";
            passwordbtn.Size = new Size(228, 27);
            passwordbtn.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(204, 227);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = Color.LightCoral;
            btnForgotPassword.Location = new Point(328, 227);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(94, 29);
            btnForgotPassword.TabIndex = 5;
            btnForgotPassword.Text = "Forgot Password?";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // regsiterbtn
            // 
            regsiterbtn.BackColor = Color.LightCoral;
            regsiterbtn.Location = new Point(443, 227);
            regsiterbtn.Name = "regsiterbtn";
            regsiterbtn.Size = new Size(94, 29);
            regsiterbtn.TabIndex = 6;
            regsiterbtn.Text = "Register Account";
            regsiterbtn.UseVisualStyleBackColor = false;
            regsiterbtn.Click += regsiterbtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(299, 28);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 7;
            label3.Text = "Maqbool Fashion";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // registerbtn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(regsiterbtn);
            Controls.Add(btnForgotPassword);
            Controls.Add(button1);
            Controls.Add(passwordbtn);
            Controls.Add(label2);
            Controls.Add(emailbtn);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerbtn";
            Text = "MaqboolFashion";
            Load += btnforgetpassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailbtn;
        private Label label2;
        private TextBox passwordbtn;
        private Button button1;
        private Button btnForgotPassword;
        private Button regsiterbtn;
        private Label label3;
    }
}
