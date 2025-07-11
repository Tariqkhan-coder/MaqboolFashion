namespace MaqboolFashion
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            user = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernamebtn = new TextBox();
            emailbtn = new TextBox();
            pbtn = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // user
            // 
            user.AutoSize = true;
            user.BackColor = Color.IndianRed;
            user.Location = new Point(351, 30);
            user.Name = "user";
            user.Size = new Size(123, 20);
            user.TabIndex = 0;
            user.Text = "Maqbool Fashion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 105);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 159);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 206);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // usernamebtn
            // 
            usernamebtn.BackColor = Color.WhiteSmoke;
            usernamebtn.BorderStyle = BorderStyle.FixedSingle;
            usernamebtn.ForeColor = Color.DimGray;
            usernamebtn.Location = new Point(338, 98);
            usernamebtn.Name = "usernamebtn";
            usernamebtn.Size = new Size(256, 27);
            usernamebtn.TabIndex = 4;
            // 
            // emailbtn
            // 
            emailbtn.BackColor = Color.WhiteSmoke;
            emailbtn.BorderStyle = BorderStyle.FixedSingle;
            emailbtn.ForeColor = Color.DarkGray;
            emailbtn.Location = new Point(338, 152);
            emailbtn.Name = "emailbtn";
            emailbtn.Size = new Size(256, 27);
            emailbtn.TabIndex = 5;
            // 
            // pbtn
            // 
            pbtn.BackColor = Color.WhiteSmoke;
            pbtn.BorderStyle = BorderStyle.FixedSingle;
            pbtn.ForeColor = Color.DimGray;
            pbtn.Location = new Point(338, 199);
            pbtn.Name = "pbtn";
            pbtn.Size = new Size(256, 27);
            pbtn.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(329, 263);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pbtn);
            Controls.Add(emailbtn);
            Controls.Add(usernamebtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(user);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUser";
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label user;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernamebtn;
        private TextBox emailbtn;
        private TextBox pbtn;
        private Button button1;
    }
}