﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tablica bajtowa z zaszyfrowanymi danymi
        byte[] Encrypted_Bytes;
        //klucz
        public static string Key { get; set; }
        public static string PathToDatabase { get; set; }

        private void Button_Open_Click(object sender, EventArgs e)
        {

            using (Form2 form2 = new Form2())
            {
                DialogResult dr = form2.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(Form2.PathToDatabase))
                    {

                        string line = sr.ReadToEnd();

                        Encrypted_Bytes = new byte[(line.Length - 2) / 2];
                        for (int d = 0; d < line.Length - 2; d += 2)
                        {
                            Encrypted_Bytes[d / 2] = Convert.ToByte(line.Substring(d, 2), 16);
                        }
                        /* test
                        foreach (var item in Encrypted_Bytes)
                        {
                            MessageBox.Show(string.Format("byte_{0}", item));
                        }
                        */
                    }
                }
            }

            //utworzenie instacji kryptograficznej funkcji skrótu md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();


            //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
            UTF8Encoding utf8 = new UTF8Encoding();


            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                Key = md5.ComputeHash(utf8.GetBytes(Key)),

                //Parametry dla 3DES
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji deszyfratora
            ICryptoTransform Decryptor = TripleDES.CreateDecryptor();



            //deszyfrowanie tablicy z bajtami od pierwszego elementu do końca, a następnie przetworzenie do łańcucha znakowego i wysłanie do textBox'a
            //textBox_Decrypted.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes, 0, Encrypted_Bytes.Length));


        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            //utworzenie instacji kryptograficznej funkcji skrótu md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
            UTF8Encoding utf8 = new UTF8Encoding();

            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                Key = md5.ComputeHash(utf8.GetBytes(textBox_Site1.Text)),

                //Parametry dla 3DES
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor();


            //konwersja zaszyfrowanych bajtów do łańcucha znakowego i przypisanie tego łańcucha do textBoxa'a w celu jego wyświetlenia
            //textBox_Encrypted.Text = BitConverter.ToString(Encrypted_Bytes);



            //szyfrowanie wpisanego przez użytkownika tekstu od pierwszego znaku do ostatniego
            Encrypted_Bytes = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);

            /* test
            foreach (var item in Encrypted_Bytes)
            {
                MessageBox.Show(string.Format("byte_{0}", item));
            }
            */


            using (StreamWriter sw = new StreamWriter(File.Create(PathToDatabase)))
            {
                sw.WriteLine(BitConverter.ToString(Encrypted_Bytes).Replace("-", ""));
                sw.Dispose();
            }

        }

        private void button_New_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                DialogResult dr = form3.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Test");
                    /*
                    using (StreamReader sr = new StreamReader(Form2.PathToDatabase))
                    {
                        MessageBox.Show("Test");


                    }
                    */
                }
            }
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {
                DialogResult dr = form4.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Test");

                }
            }
        }

        private void Button_SaveAs_Click(object sender, EventArgs e)
        {
            //utworzenie instacji kryptograficznej funkcji skrótu md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
            UTF8Encoding utf8 = new UTF8Encoding();

            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                Key = md5.ComputeHash(utf8.GetBytes(textBox_Site1.Text)),

                //Parametry dla 3DES
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor();


            //konwersja zaszyfrowanych bajtów do łańcucha znakowego i przypisanie tego łańcucha do textBoxa'a w celu jego wyświetlenia
            //textBox_Encrypted.Text = BitConverter.ToString(Encrypted_Bytes);

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "File name | *.txt",
                FileName = "Database.txt",
                Title = "Sava Database:"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //szyfrowanie wpisanego przez użytkownika tekstu od pierwszego znaku do ostatniego
                Encrypted_Bytes = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);

                /* test
                foreach (var item in Encrypted_Bytes)
                {
                    MessageBox.Show(string.Format("byte_{0}", item));
                }
                */

                string path = saveFile.FileName;
                using (StreamWriter sw = new StreamWriter(File.Create(path)))
                {
                    sw.WriteLine(BitConverter.ToString(Encrypted_Bytes).Replace("-", ""));
                    sw.Dispose();
                }
            }
        }
    }
}
