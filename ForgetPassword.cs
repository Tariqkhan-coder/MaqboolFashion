using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaqboolFashion
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FloralWhite;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10);

            // Style Submit Button
            Confirm.BackColor = Color.Red;
            Confirm.ForeColor = Color.HotPink;
            Confirm.FlatStyle = FlatStyle.Flat;
            Confirm.FlatAppearance.BorderSize = 0;
            Confirm.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Confirm.Cursor = Cursors.Hand;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string email = email_btn.Text.Trim();
            string newPassword = newpasswordbtn.Text;
            string confirmPassword = cnfrmbtn.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-I9BRQED;Initial Catalog=MaqboolFashion;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                    return;
                }

                // Check if email exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", email);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                // Update password
                string updateQuery = "UPDATE Users SET Password = @Password WHERE Email = @Email";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@Password", newPassword);
                updateCmd.Parameters.AddWithValue("@Email", email);

                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }


        }
    }
}

