using Azure.Core;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Scheduling_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //manual instantiation of admin panel to avoid being child panel of previous panel
            panel1.Visible = false;
            Font fontProperty = new Font("Segoe UI", 14);

            //instatiate panel that will group the instantiated elements
            Panel adminPanel = new Panel();
            adminPanel.BackColor = System.Drawing.Color.White;
            adminPanel.Size = new Size(609, 586);
            adminPanel.Location = new Point(344, 133);

            PictureBox pictureBox3 = new PictureBox();
            pictureBox3.Size = new System.Drawing.Size(455, 107);
            pictureBox3.Location = new System.Drawing.Point(81, 29);
            pictureBox3.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\images.jpg");

            Label label4 = new Label();
            label4.Size = new Size(419, 28);
            label4.Location = new Point(103, 148);
            Font font12 = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = font12;
            label4.AutoSize = true;
            label4.Text = "Welcome Back! Please Input your credentials";

            //instatiate label
            Label adminInputID = new Label();
            adminInputID.Location = new Point(81, 215);
            adminInputID.Size = new Size(117, 31);
            adminInputID.Text = "Enter Administrator ID";
            adminInputID.AutoSize = true;
            adminInputID.Font = fontProperty;

            TextBox textBox3 = new TextBox();
            textBox3.Location = new Point(79, 247);
            textBox3.Size = new Size(456, 43);
            textBox3.Text = "";
            textBox3.Font = fontProperty;

            Label adminInputPass = new Label();
            adminInputPass.Location = new Point(81, 326);
            adminInputPass.Size = new Size(117, 31);
            adminInputPass.Font = fontProperty;
            adminInputPass.AutoSize = true;
            adminInputPass.Text = "Enter Administrator Password";

            TextBox textBox4 = new TextBox();
            textBox4.Location = new Point(79, 362);
            textBox4.Size = new Size(456, 43);
            textBox4.Font = fontProperty;
            textBox4.Text = "";

            Button adminBtn = new Button();
            adminBtn.Location = new Point(215, 515);
            adminBtn.Size = new Size(198, 50);
            adminBtn.Text = "Sign In";
            adminBtn.Font = fontProperty;

            //show initiated objects on form
            adminPanel.Controls.Add(textBox4);
            adminPanel.Controls.Add(textBox3);
            adminPanel.Controls.Add(adminInputID);
            adminPanel.Controls.Add(pictureBox3);
            adminPanel.Controls.Add(adminBtn);
            adminPanel.Controls.Add(label4);
            adminPanel.Controls.Add(adminInputPass);
            this.Controls.Add(adminPanel);
            adminPanel.Visible = true;
            adminPanel.BringToFront();
            adminBtn.Click += new EventHandler(adminSignIn_Click);

            //event handler for admin credentials 
            void adminSignIn_Click(object sender, EventArgs e)
            {
                string idInput = textBox3.Text;
                string passInput = textBox4.Text;
                try
                {
                    string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                    string query = "SELECT admin_id, admin_password FROM account_credentials WHERE admin_id=@adminId AND admin_password=@adminPassword";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@adminId", textBox3.Text);
                        command.Parameters.AddWithValue("@adminPassword", textBox4.Text);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? adminId = reader["admin_id"].ToString();
                                string? adminPassword = reader["admin_password"].ToString();

                                if (adminId == textBox3.Text && adminPassword == textBox4.Text)
                                {
                                    MessageBox.Show("Login Success");
                                    new AdminForm(adminId).Show();
                                    Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Credentials!");
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("An error occurred, please try again");
                }
            }
        } 
        private void studentSignIn_Click(object sender, EventArgs e)
        {
            String inputUsername = textBox1.Text;
            String inputPassword = textBox2.Text;
            try
            {
                //SQL connection to server and query
                string connectionString = "Data Source=DESKTOP-LP7AF2L\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=TRUE; TrustServerCertificate=True";
                string credentialslQuery = "SELECT student_name, student_id, student_password FROM account_credentials WHERE student_id=@studentId AND student_password=@studentPassword";

                //Check user credentials from textbox, then using sqldatareader to loop through the selected columsn
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand credentialsCommand= new SqlCommand (credentialslQuery, connection))
                {
                    connection.Open();
                    credentialsCommand.Parameters.AddWithValue("@studentId", textBox1.Text);
                    credentialsCommand.Parameters.AddWithValue("@studentPassword", textBox2.Text);

                    using (SqlDataReader reader = credentialsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string? userName = reader["student_name"].ToString();
                            string? studentID = reader["student_id"].ToString();
                            string? studentPassword = reader["student_password"].ToString();

                            if (studentID == inputUsername && studentPassword == inputPassword)
                            {
                                MessageBox.Show("Login Success");
                                new SubjectOffering(userName, studentID).Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Credentials!");
                            }

                        }
                        reader.Close();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("An error occured, please try again");
            }
        }
        private void signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().Show();
            Hide();
        }
    }
}
