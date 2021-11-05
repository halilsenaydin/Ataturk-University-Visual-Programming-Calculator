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

            // Kodlarýmý try catch ile doldurmak istemedim..
            // Bu sorunu ileride daha iyi bir þekilde çözebileceðime inanýyorum ama þu an için kodlarýmda okunabilirliði ön plana çýkarmak istiyorum..
            try
            {
                Application.Run(new Intro());
            }

            catch (Exception){}

        }
    }
}
