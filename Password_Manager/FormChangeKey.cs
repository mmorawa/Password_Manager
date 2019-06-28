/*! \file FormChangeKey.cs
\brief Plik FormChangeKey.cs zawiera klasę FormChangeKey odpowiedzialną za zmianę klucza do bazy z hasłami.

Plik FormChangeKey.cs zawiera kod okna aplikacji, w którym użytkownik może dokonać zmiany klucza szyfrującego do bazy z hasłami.
*/

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa FormChangeKey zawiera okno aplikacji, w której użytkownik dokonuje zmiany klucza szyfrującego do bazy z hasłami.
    /*! W klasie FormChangeKey znajduje się okno otwierane po naciśnięciu przycisku Change w głównym oknie aplikacji.
     * Pozwala ono użytkownikowi na wprowadzenie nowego klucza szyfrującego. 
     * Po naciśnięciu przycisku OK zmiany zostają automatycznie zapisane do bazy.
     */
    public partial class FormChangeKey : Form
    {
        //! Konstruktor klasy FormChangeKey.
        /*! Inicjalizuje komponenty klasy FormChangeKey. */
        public FormChangeKey()
        {
            InitializeComponent();
        }

        //! Metoda sprawdzająca poprawność podanych przez użytkownika danych.
        /*! Metoda Button_OK_Click wywołana jest poprzez naciśnięcie przycisku OK.
         * Sprawdza ona czy użytkownik podał nowy klucz szyfrujący a następnie używa funkcji skrótu md5 w odniesieniu do niego.
         */
        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Key.Text != "")
            {
                //utworzenie instacji kryptograficznej funkcji skrótu md5
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
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
