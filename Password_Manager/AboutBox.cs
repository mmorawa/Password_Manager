/*! \file AboutBox.cs
\brief Plik AboutBox.cs zawiera klasę AboutBox z oknem informacyjnym aplikacji.

Plik AboutBox.cs zawiera kod okna wyświetlającego informacje o aplikacji oraz jej licencji. 
*/

using System;
using System.Reflection;
using System.Windows.Forms;

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa AboutBox zawiera kod okna wyświetlającego podstawowe informacje o aplikacji. 
    /*! W klasie AboutBox znajduje się okno informacyjne, otwierane po naciśnięciu przycisku About z paska menu.
     * Można dowiedzieć się z niego takich danych jak: nazwa aplikacji, jej licencja czy krótki opis. 
     */
    partial class AboutBox : Form
    {
        //! Konstruktor klasy AboutBox.
        /*! Inicjalizuje komponenty klasy AboutBox oraz jej atrybuty. */
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        //! Nazwa projektu.
        /*! Właściwość AssemblyTitle pobiera nazwę projektu z ustawień projektu. */
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        //! Wersja aplikacji.
        /*! Właściwość AssemblyVersion pobiera wersję aplikacji z ustawień projektu. */
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        //! Opis aplikacji.
        /*! Właściwość AssemblyDescription pobiera opis aplikacji z ustawień projektu. */
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        //! Nazwa aplikacji.
        /*! Właściwość AssemblyProduct pobiera nazwę aplikacji z ustawień projektu. */
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        //! Licencja.
        /*! Właściwość AssemblyCopyright pobiera typ licencji z ustawień projektu. */
        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        #endregion
    }
}
