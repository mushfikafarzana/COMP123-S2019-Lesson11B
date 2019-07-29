using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11B
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void StudentInfoForm_Activated(object sender, EventArgs e)
        {
            //open file stream to read
            using (StreamReader inputStream = new StreamReader (
                File.Open("Student.txt", FileMode.Open)))
            {
                // read stuffs from the file into the Student object
                Program.student.id = int.Parse(inputStream.ReadLine());
                Program.student.StudentID = inputStream.ReadLine();
                Program.student.FirstName = inputStream.ReadLine();
                Program.student.LastName = inputStream.ReadLine();

                //cleanUp
                inputStream.Close();
                inputStream.Dispose();

                IDDataLabel.Text = Program.student.id.ToString();
                StudentIDDataLabel.Text = Program.student.StudentID;
                FirstNameDataLabel.Text = Program.student.FirstName;
                LastNameDataLabel.Text = Program.student.LastName;
            }
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
