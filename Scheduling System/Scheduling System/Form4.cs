using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_System
{
    public partial class StudentForm : Form
    {
        private string userName;
        private string studentID;
        private ListBox enrolledSubjects;
        public StudentForm(string userName, string studentID)
        {
            InitializeComponent();
            this.userName = userName;
            this.studentID = studentID;

            label1.Text = userName;
            label2.Text = studentID;

        }
        public void SetListBoxItems(ListBox.ObjectCollection items)
        {
            foreach (var item in items)
            {
                enrolledSubject.Items.Add(item);
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void SubjOffering_Click(object sender, EventArgs e)
        {
            new SubjectOffering(userName, studentID).Show();
            Hide();
        }

        private void Finance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void SubjEnrollment_Click(object sender, EventArgs e)
        {
            webView21.Stop();
            webView21.Visible = false;
            webView21.SendToBack();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {
            webView21.BringToFront();
            webView21.Visible = true;
        }


        private void LogOut_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void EnrollSubjects_Click(object sender, EventArgs e)
        {
            new StudentEnroll(userName, studentID).Show();
            Hide();
        }
    }
}
