using Microsoft.Data.SqlClient;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        bool isStudentInfoSaved = false;
        bool isCourseInfoSaved = false;
        bool isStudentAcadsSaved = false;
        bool isGuardianInfoSaved = false;
        string defaultUsername = "";
        string defaultPassword = "";



        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            string studentSurname = tbSurname.Text;
            string studentFirstName = tbFirstName.Text;
            string studentMiddleName = tbMidName.Text;
            string studentSuffix = tbSuffix.Text;
            string studentEmail = tbEmail.Text;
            string studentContact = tbContact.Text;
            string studentHouseNo = tbHouseNum.Text;
            string studentStreet = tbStreet.Text;
            string studentBarangay = tbBarangay.Text;
            string studentCity = tbCity.Text;
            string studentProvince = tbProvince.Text;   
            string studentPostal = tbPostal.Text;
            string studentAddress = tbHouseNum.Text + tbStreet.Text  + tbBarangay.Text  + tbCity.Text  + tbProvince.Text + tbPostal.Text; 
            string studentBirthday = cbMonth.Text + cbDay.Text + cbYear.Text;
            string studentGender = cbGender.Text;
            defaultUsername = studentSurname + "_" + cbMonth.SelectedIndex.ToString() + cbDay.SelectedIndex.ToString() + cbYear.SelectedIndex.ToString();
            defaultPassword = studentBirthday;
            //connection to SQL Server
            try
            {
                string connectionString = "Data Source=CHELS\\SQLEXPRESS;Initial Catalog=StudentInformationDB; Integrated Security=TRUE; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO student_Info(studentSurname, studentFirstName, studentMidName, studentSuffix, studentEmail, studentContact, studentAddress, studentBirthday, studentGender, studentUsername, studentPassword) VALUES (@surname, @firstName, @midName, @suffix, @email, @contact, @address, @birthday, @gender, @username, @password)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    //adding of data 
                    command.Parameters.AddWithValue("@surname", studentSurname);
                    command.Parameters.AddWithValue("@firstName", studentFirstName);
                    command.Parameters.AddWithValue("@midName", studentMiddleName);
                    command.Parameters.AddWithValue("@suffix", studentSuffix);
                    command.Parameters.AddWithValue("@email", studentEmail);
                    command.Parameters.AddWithValue("@contact", studentContact);
                    command.Parameters.AddWithValue("@address", studentAddress);
                    command.Parameters.AddWithValue("@birthday", studentBirthday);
                    command.Parameters.AddWithValue("@gender", studentGender);
                    command.Parameters.AddWithValue("@username", defaultUsername);
                    command.Parameters.AddWithValue("@password", defaultPassword);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Information saved.");
                    isStudentInfoSaved = true;
                   
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Information not saved, server error" + ex.Message); ;
            }

        }

        private void btnCourseInfo_Click(object sender, EventArgs e)
        {
            string studentYearLevel = cbYearLevel.Text;
            string studentFirstChoice = cbCourse1.Text;
            string studentSecondChoice = cbCourse2.Text;
            try
            {
                string connectionString = "Data Source=CHELS\\SQLEXPRESS;Initial Catalog=StudentInformationDB; Integrated Security=TRUE; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO student_Course(studentYearLevel, studentCourse1, studentCourse2) VALUES (@yearlevel, @course1, @course2)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    //adding of data 
                    command.Parameters.AddWithValue("@yearlevel", studentYearLevel);
                    command.Parameters.AddWithValue("@course1", studentFirstChoice);
                    command.Parameters.AddWithValue("@course2", studentSecondChoice);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Course Information saved.");
                    isCourseInfoSaved = true;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Information not saved, server error" + ex.Message); ;
            }
        }

        private void btnStudentAcads_Click(object sender, EventArgs e)
        {

            string studentGradeSchool = tbGradeSchool.Text;
            string studentGradeGWA = tbGradeGWA.Text;
            string studentGradeAcads = rtbAcads1.Text;
            string studentHighSchool = tbHighSchool.Text;
            string studentHighGWA = tbHighGWA.Text;
            string studentHighAcads = rtbAcads2.Text;
            try
            {
                string connectionString = "Data Source=CHELS\\SQLEXPRESS;Initial Catalog=StudentInformationDB; Integrated Security=TRUE; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO student_Acads(studentGradeSchool, studentGradeGWA, studentGradeAcads, studentHighSchool, studentHighGWA, studentHighAcads) VALUES (@gradeschool, @gradegwa, @gradeacads, @highschool, @highgwa, @highacads)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    //adding of data 
                    command.Parameters.AddWithValue("@gradeschool", studentGradeSchool);
                    command.Parameters.AddWithValue("@gradegwa", studentGradeGWA);
                    command.Parameters.AddWithValue("@gradeacads", studentGradeAcads);
                    command.Parameters.AddWithValue("@highschool", studentHighSchool);
                    command.Parameters.AddWithValue("@highgwa", studentHighGWA);
                    command.Parameters.AddWithValue("@highacads", studentHighAcads);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Academic Information saved.");
                    isStudentAcadsSaved = true;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Information not saved, server error" + ex.Message); ;
            }
        }
        private void btnGuardian_Click(object sender, EventArgs e)
        {
            string guardianSurname = tbGuardianSurname.Text;
            string guardianFirstName = tbGuardianFirstName.Text;
            string guardianMidName = tbGuardianMidName.Text;
            string guardianSuffix = tbGuardianSuffix.Text;
            string guardianRelations = tbGuardianRelation.Text;
            string guardianEmail = tbGuardianEmail.Text;
            string guardianContact = tbGuardianContact.Text;
           

            try
            {
                string connectionString = "Data Source=CHELS\\SQLEXPRESS;Initial Catalog=StudentInformationDB; Integrated Security=TRUE; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO guardian_Info(guardianSurname, guardianFirstName, guardianMidName, guardianSuffix, guardianRelationship, guardianEmail, guardianContact, guardianAddress) VALUES (@guardianSurname, @guardianFirstName, @guardianMidName, @guardianSuffix, @guardianEmail, @guardianContact, @guardianAddress, @guardianRelationship)";
                    SqlCommand command = new SqlCommand(sql, connection);

                    //adding of data 
                    command.Parameters.AddWithValue("@guardianSurname", guardianSurname);
                    command.Parameters.AddWithValue("@guardianFirstName", guardianFirstName);
                    command.Parameters.AddWithValue("@guardianMidName", guardianMidName);
                    command.Parameters.AddWithValue("@guardianSuffix", guardianSuffix);
                    command.Parameters.AddWithValue("@guardianRelationship", guardianRelations);
                    command.Parameters.AddWithValue("@guardianEmail", guardianEmail);
                    command.Parameters.AddWithValue("@guardianContact", guardianContact);
                    

                    command.ExecuteNonQuery();
                    MessageBox.Show("Student Information saved.");
                    isGuardianInfoSaved = true;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Information not saved, server error" + ex.Message);
            }

        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isStudentInfoSaved == true & isCourseInfoSaved == true & isStudentAcadsSaved == true & isGuardianInfoSaved == true)
            {
                MessageBox.Show("You have successfully registered! Your default username is: " + defaultUsername + "and your default password is: " + defaultPassword);
               
                LoginForm frm = new LoginForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Information is not saved. Save information first.");
            }

        }
    }
}
