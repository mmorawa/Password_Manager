/*! \file Form2.cs
\brief Plik Form2.cs zawiera Formularz .NET z oknem odpowiedzialnym za wczytanie bazy z hasłami do aplikacji.

Plik Form2.cs zawiera kod okna aplikacji, w którym użytkownik może wybrać bazę z hasłami oraz podać do niej hasło w celu wczytania jej do głównego okna aplikacji.
*/

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//! Przestrzeń nazw Password_Manager, która obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa Form2 zawiera okno aplikacji wczytujące bazę z hasłami do aplikacji.
    /*! W klasie Form2 znajduje się okno odpowiedzialne za wybranie bazy i podanie jej hasła w celu wczytania jej do aplikacji. */
    public partial class Form2 : Form
    {
        //! Konstruktor klasy Form2.
        /*! Inicjalizuje komponenty klasy Form2. */
        public Form2()
        {
            InitializeComponent();
        }

        /*******************************************************************************
        *  Metody klasy Form2.
        ********************************************************************************/
        //! Funkcja otwierająca okno dialogowe, w którym można wybrać bazę do wczytania.
        /*! Funkcja Button_Load_Click otwieraja okno dialogowe, w którym można wybrać bazę do wczytania.
         * Plik z bazą obsługiwane przez aplikację mają postać plików tekstowych z rozszerzeniem .txt.
         */
        private void Button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Title = "Open file with Database",
                Filter = "Text files |*.txt| All files |*.*"
            };

            DialogResult dr2 = openFile.ShowDialog();
            //wewnętrzny Dialog
            DialogResult = DialogResult.None;

            if (dr2 == DialogResult.OK)
            {
                textBox_Filename.Text = openFile.FileName;
                Form1.PathToDatabase = openFile.FileName;
            }
        }

        //! Funkcja sprawdzająca poprawność podanych przez użytkownika danych.
        /*! Funkcja Button_OK_Click wywołana jest poprzez naciśnięcie przycisku OK.
         * Sprawdza ona czy użytkownik podał wszystkie wymagane dane a następnie używa funkcji skrótu md5 w odniesieniu do podanego przez użytkownika hasła.
         */
        private void Button_OK_Click(object sender, EventArgs e)
        {

            if ((textBox_Key.Text != "") && (textBox_Filename.Text != ""))
            {
                //utworzenie instacji kryptograficznej funkcji skrótu md5
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
                UTF8Encoding utf8 = new UTF8Encoding();

                Form1.Key = md5.ComputeHash(utf8.GetBytes(textBox_Key.Text));
            }
            else
            {
                MessageBox.Show("Incorrect data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
        }
    }

}
