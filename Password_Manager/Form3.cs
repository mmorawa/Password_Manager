/*! \file Form3.cs
\brief Plik Form3.cs zawiera klasę Form3 odpowiedzialną za zapisanie klucza i ścieżki do nowo utworzonej bazy z hasłami.

Plik Form3.cs zawiera kod okna aplikacji, w którym użytkownik w oknie dialogowym wybiera plik, do którego zostanie zapisana nowo utworzona baza z hasłami a następnie podaje klucz do niej.
*/

using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw, która obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa Form3 zawiera okno aplikacji, w której użytkownik podaje dane dla nowej bazy z hasłami.
    /*! W klasie Form3 znajduje się okno otwierane po naciśnięciu przycisku New w głównym oknie aplikacji.
     * Pozwala ono na wybranie pliku bazy, do którego zapisywane będą nowe wpisy z hasłami a także na podanie klucza szyfrującego do niej.
     */
    public partial class Form3 : Form
    {
        //! Konstruktor klasy Form3.
        /*! Inicjalizuje komponenty klasy Form3. */
        public Form3()
        {
            InitializeComponent();
        }

        /*******************************************************************************
        *  Metody klasy Form3.
        ********************************************************************************/

        //! Metoda otwierająca okno dialogowe, w którym można wybrać plik, do którego zapisana będzie nowo utworzona baza z hasłami. 
        /*! Metoda Button_Save_Click otwiera okno dialogowe, w którym można wybrać plik, do którego zapisana będzie nowo utworzona baza z hasłami.
         * Nowy plik tekstowy z bazą będzie pusty aż do momentu wprowadzenia nowych wpisów w oknie głównym aplikacji i zapisania ich.
         */
        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "File name | *.txt",
                FileName = "Database.txt",
                Title = "Sava Database:"
            };

            DialogResult dr2 = saveFile.ShowDialog();
            //wewnętrzny Dialog
            DialogResult = DialogResult.None;

            if (dr2 == DialogResult.OK)
            {
                textBox_Filename.Text = saveFile.FileName;
                Form1.PathToDatabase = saveFile.FileName;
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
