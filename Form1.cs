using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MaqboolFashion
{
    public partial class registerbtn : Form
    {
        public registerbtn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailbtn.Text.Trim();
            string password = passwordbtn.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-I9BRQED;Initial Catalog=MaqboolFashion;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to check email and password match
                    string query = "SELECT * FROM UserDetails WHERE email = @Email AND password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // TODO: hash in future

                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Optionally: Open Dashboard
                            // new Dashboard().Show();
                            // this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong email or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forgetForm = new ForgetPassword();
            forgetForm.ShowDialog();
            this.Show();
        }

        private void btnforgetpassword_Load(object sender, EventArgs e)
        {
            btnForgotPassword.FlatStyle = FlatStyle.Flat;
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.ForeColor = Color.Blue;
            btnForgotPassword.Font = new Font("Segoe UI", 9, FontStyle.Underline);
            btnForgotPassword.Cursor = Cursors.Hand;
        }

        private void regsiterbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreateUser createUserForm = new CreateUser();
            createUserForm.ShowDialog();
            this.Show();
        }
        

    }
}

