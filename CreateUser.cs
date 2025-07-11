using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MaqboolFashion
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        private void SendVerificationEmail(string recipientEmail, string username)
        {
            try
            {
                string smtpEmail = "tariqkhansahil14@gmail.com";
                string smtpPassword = "hexk ytxw szuq ilgr";

                string subject = "Verify Your Email - Maqbool Fashion";
                string body = $"<h3>Welcome {username}!</h3>" +
                              $"<p>Click below to verify your email:</p>" +
                              $"<a href='https://yourwebsite.com/verify?email={recipientEmail}'>Verify Email</a>";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(smtpEmail, "Maqbool Fashion");
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(smtpEmail, smtpPassword);
                smtp.Send(mail);

                MessageBox.Show("Verification email sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email failed: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernamebtn.Text.Trim();
            string email = emailbtn.Text.Trim();
            string password = pbtn.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-I9BRQED;Initial Catalog=MaqboolFashion;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO UserDetails (username, email, password) VALUES (@username, @email, @password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User created successfully.");
                            SendVerificationEmail(email, username); // ✅ call only if success
                        }
                        else
                        {
                            MessageBox.Show("Insert failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 600);
        }
    }
}
