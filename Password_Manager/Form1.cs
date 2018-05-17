using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Encrypt_Click(object sender, EventArgs e)
        {
            //utworzenie instacji kryptograficznej funkcji skrótu md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
            UTF8Encoding utf8 = new UTF8Encoding();

            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                Key = md5.ComputeHash(utf8.GetBytes(textBox_Key.Text)),

                //Parametry dla 3DES
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor();

            //tablica bajtowa z zaszyfrowanymi danymi
            byte[] Encrypted_Bytes;
             
            
            //szyfrowanie wpisanego przez użytkownika tekstu od pierwszego znaku do ostatniego
            Encrypted_Bytes = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Text.Text), 0, utf8.GetBytes(textBox_Text.Text).Length);
            

            //konwersja zaszyfrowanych bajtów do łańcucha znakowego i przypisanie tego łańcucha do textBoxa'a w celu jego wyświetlenia
            textBox_Encrypted.Text = BitConverter.ToString(Encrypted_Bytes);
            
        }
    }
}
