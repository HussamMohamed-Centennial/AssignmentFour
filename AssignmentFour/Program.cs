using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFour
{
   public static class Program
   {

       public static BMICalculatorForm BmiCalculatorForm;
       public static SplashForm SplashForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BmiCalculatorForm = new BMICalculatorForm();
            Application.Run(new SplashForm());
        }
    }
}
