using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Scheduling_System
{
    public partial class SubjectOffering : Form
    {
        private string userName;
        private string studentID;

        public SubjectOffering(string userName, string studentID)
        {
            InitializeComponent();
            this.userName = userName;
            this.studentID = studentID;

            studentName.Text = userName;
            studentNumber.Text = studentID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StudentForm(userName, studentID).Show();
            Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void subjOffering_Click(object sender, EventArgs e)
        {
            webView21.Stop();
            webView21.Visible = false;
            webView21.SendToBack();
        }

        private void finance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void subjEnrollment_Click(object sender, EventArgs e)
        {
            new StudentForm(userName, studentID).Show();
            Hide();
        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
            webView21.BringToFront();
            webView21.Visible = true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        int currentImageIndex = 0;
        private void imageShow_Click(object sender, EventArgs e)
        {
            currentImageIndex++;
            imageCounter();

        }
        void imageCounter()
        {
            if (currentImageIndex == 1)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\1.png");
            }
            else if (currentImageIndex == 2)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\2.png");
            }
            else if (currentImageIndex == 3)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\3.png");
            }
            else if (currentImageIndex == 4)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\4.png");
            }
            else if (currentImageIndex == 5)
            {
                pictureBox9.BackgroundImage = Image.FromFile("C:\\Users\\danna\\Downloads\\5.png");
            }
            else if (currentImageIndex < 5)
            {
                currentImageIndex = 1;
            }
        }
    }
}

