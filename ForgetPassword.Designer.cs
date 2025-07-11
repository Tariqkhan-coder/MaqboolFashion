namespace MaqboolFashion
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            label1 = new Label();
            label2 = new Label();
            newpasswordbtn = new TextBox();
            cnfrmbtn = new TextBox();
            label3 = new Label();
            email_btn = new TextBox();
            Confirm = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 155);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 0;
            label1.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 224);
            label2.Name = "label2";
            label2.Size = new Size(155, 23);
            label2.TabIndex = 1;
            label2.Text = "Confrim Paassword";
            label2.Click += label2_Click;
            // 
            // newpasswordbtn
            // 
            newpasswordbtn.BackColor = Color.WhiteSmoke;
            newpasswordbtn.BorderStyle = BorderStyle.FixedSingle;
            newpasswordbtn.ForeColor = Color.DimGray;
            newpasswordbtn.Location = new Point(506, 158);
            newpasswordbtn.Name = "newpasswordbtn";
            newpasswordbtn.Size = new Size(255, 30);
            newpasswordbtn.TabIndex = 2;
            // 
            // cnfrmbtn
            // 
            cnfrmbtn.BackColor = Color.WhiteSmoke;
            cnfrmbtn.BorderStyle = BorderStyle.FixedSingle;
            cnfrmbtn.ForeColor = Color.DimGray;
            cnfrmbtn.Location = new Point(506, 224);
            cnfrmbtn.Name = "cnfrmbtn";
            cnfrmbtn.Size = new Size(255, 30);
            cnfrmbtn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // email_btn
            // 
            email_btn.BackColor = Color.WhiteSmoke;
            email_btn.BorderStyle = BorderStyle.FixedSingle;
            email_btn.ForeColor = Color.DimGray;
            email_btn.Location = new Point(506, 92);
            email_btn.Name = "email_btn";
            email_btn.Size = new Size(255, 30);
            email_btn.TabIndex = 5;
            // 
            // Confirm
            // 
            Confirm.BackColor = Color.LightCoral;
            Confirm.Location = new Point(420, 325);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(106, 33);
            Confirm.TabIndex = 6;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += Confirm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.IndianRed;
            label4.Location = new Point(387, 28);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 7;
            label4.Text = "Maqbool Fashion";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(900, 518);
            Controls.Add(label4);
            Controls.Add(Confirm);
            Controls.Add(email_btn);
            Controls.Add(label3);
            Controls.Add(cnfrmbtn);
            Controls.Add(newpasswordbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPassword";
            Text = "ForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox newpasswordbtn;
        private TextBox cnfrmbtn;
        private Label label3;
        private TextBox email_btn;
        private Button Confirm;
        private Label label4;
    }
}