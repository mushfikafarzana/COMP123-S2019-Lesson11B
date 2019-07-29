 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11B
{
    public static class Program
    {
        public static StartForm startForm;
        public static MainForm mainForm;
        public static AboutForm aboutForm;

        public static StudentInfoForm studentInfoForm;
        public static Student student;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            mainForm = new MainForm();
            aboutForm = new AboutForm();

            studentInfoForm = new StudentInfoForm();

            student = new Student();
        
            Application.Run(startForm);
        }
    }
}
