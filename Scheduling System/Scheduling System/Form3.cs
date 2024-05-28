using System.DirectoryServices;

namespace Scheduling_System
{
    public partial class AdminForm : Form
    {
        private string adminId;
        public AdminForm(string adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            adminLabel.Text = adminId;
        }

        private void home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void subjOffering_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void finance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incoming feature, we apologize for the inconvenience");
        }

        private void subjEnrollment_Click(object sender, EventArgs e)
        {
            webView21.Stop();
            webView21.Visible = false;
            webView21.SendToBack();
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

        private void enrollComAni_Click(object sender, EventArgs e)
        {
            computerAnimation.Items.Add(comAnim.Text);
        }

        private void enrollDiscrete_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(discreteStruc.Text);
        }

        private void enrollDLab_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(digiLab.Text);
        }

        private void enrollDLec_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Add(digiLec.Text);
        }

        private void enrollDSA_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Add(dsa.Text);
        }
    }
}
