using CalculatorUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Kodlar�m� try catch ile doldurmak istemedim..
            // Bu sorunu ileride daha iyi bir �ekilde ��zebilece�ime inan�yorum ama �u an i�in kodlar�mda okunabilirli�i �n plana ��karmak istiyorum..
            try
            {
                Application.Run(new Intro());
            }

            catch (Exception){}

        }
    }
}
