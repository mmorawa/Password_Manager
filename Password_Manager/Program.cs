/*! \file Program.cs
\brief Plik Program.cs zawiera klasę Program.

Plik Program.cs zawiera klasę Program, która uruchamia całość aplikacji.
*/

using System;
using System.Windows.Forms;

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa Program to podstawowa klasa dla każdej aplikacji.
    /*! Klasa Program zawiera metodę Main, która jest punktem startowym każdej aplikacji. */
    static class Program
    {
        //! Metoda Main to podstawowa metoda dla każdej aplikacji.
        /*! Metoda Main jest punktem startowym dla każdej aplikacji.
         * Uruchamia ona okno główne aplikacji.
         */
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
