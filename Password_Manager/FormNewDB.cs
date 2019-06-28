/*! \file FormNewDB.cs
\brief Plik FormNewDB.cs zawiera klasę FormNewDB odpowiedzialną za zapisanie klucza i ścieżki do nowo utworzonej bazy z hasłami.

Plik FormNewDB.cs zawiera kod okna aplikacji, w którym użytkownik w oknie dialogowym wybiera plik, do którego zostanie zapisana nowo utworzona baza z hasłami a następnie podaje klucz do niej.
*/

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa FormNewDB zawiera okno aplikacji, w której użytkownik podaje dane dla nowej bazy z hasłami.
    /*! W klasie FormNewDB znajduje się okno otwierane po naciśnięciu przycisku New w głównym oknie aplikacji.
     * Pozwala ono na wybranie pliku bazy, do którego zapisywane będą nowe wpisy z hasłami a także na podanie klucza szyfrującego do niej.
     */
    public partial class FormNewDB : Form
    {
        //! Konstruktor klasy FormNewDB.
        /*! Inicjalizuje komponenty klasy FormNewDB. */
        public FormNewDB()
        {
            InitializeComponent();
        }

        /*******************************************************************************
        *  Metody klasy FormNewDB.
        ********************************************************************************/

        //! Metoda otwierająca okno dialogowe, w którym można wybrać plik, do którego zapisana będzie nowo utworzona baza z hasłami. 
        /*! Metoda Button_Save_Click otwiera okno dialogowe, w którym można wybrać plik, do którego zapisana będzie nowo utworzona baza z hasłami.
         * Nowy plik tekstowy nie będzie zawierał żadnych wpisów z hasłami aż do momentu ich wprowadzenia w oknie głównym aplikacji i zapisania ich.
         */
        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "File name | *.txt",
                FileName = "Database.txt",
                Title = "Save Database:"
            };

            DialogResult dr2 = saveFile.ShowDialog();
            //wewnętrzny Dialog
            DialogResult = DialogResult.None;

            if (dr2 == DialogResult.OK)
            {
                textBox_Filename.Text = saveFile.FileName;
                MainForm.PathToDatabase = saveFile.FileName;
            }
        }

        //! Metoda sprawdzająca poprawność podanych przez użytkownika danych.
        /*! Metoda Button_OK_Click wywołana jest poprzez naciśnięcie przycisku OK.
         * Sprawdza ona czy użytkownik podał wszystkie wymagane dane a następnie używa funkcji skrótu md5 w odniesieniu do podanego przez użytkownika hasła.
         */
        private void Button_OK_Click(object sender, EventArgs e)
        {
            if ((textBox_Key.Text != "") && (textBox_Filename.Text != ""))
            {
                //Utworzenie instacji kryptograficznej funkcji skrótu md5.
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                //Zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty.
                UTF8Encoding utf8 = new UTF8Encoding();

                MainForm.Key = md5.ComputeHash(utf8.GetBytes(textBox_Key.Text));

            }
            else
            {
                MessageBox.Show("Incorrect data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }

        }
    }
}
