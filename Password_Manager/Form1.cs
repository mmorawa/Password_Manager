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
using System.IO;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tablica bajtowa wielowymiarowa z zaszyfrowanymi danymi
        byte[][] Encrypted_Bytes = new byte [6][];

        //klucz
        public static string Key { get; set; }
        public static string PathToDatabase { get; set; }

        //utworzenie instacji kryptograficznej funkcji skrótu md5
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
        UTF8Encoding utf8 = new UTF8Encoding();

        private void Button_Open_Click(object sender, EventArgs e)
        {

            using (Form2 form2 = new Form2())
            {
                DialogResult dr = form2.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(Form2.PathToDatabase))
                    {

                        //string line = sr.ReadToEnd();
                        

                        for (int i = 0; i < 6; i++)
                        {
                            string line = sr.ReadLine();
                            MessageBox.Show(line);
                            Encrypted_Bytes[i] = new byte[(line.Length) / 2];
                            for (int d = 0; d < line.Length; d += 2)
                            {
                                Encrypted_Bytes[i][d / 2] = Convert.ToByte(line.Substring(d, 2), 16);
                            }
                        }
                        

                        
                        foreach (var item in Encrypted_Bytes[0])
                        {
                            MessageBox.Show(string.Format("byte_{0}", item));
                        }
                        
                    }
                }
            }


            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                //Key = md5.ComputeHash(utf8.GetBytes(Key)),
                Key = md5.ComputeHash(utf8.GetBytes("aaa")),

                //Parametry dla 3DES
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji deszyfratora
            ICryptoTransform Decryptor = TripleDES.CreateDecryptor();

            MessageBox.Show(Encrypted_Bytes[0].Length.ToString());

            //deszyfrowanie tablicy z bajtami od pierwszego elementu do końca, a następnie przetworzenie do łańcucha znakowego i wysłanie do textBox'a
            textBox_Site1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[0], 0, Encrypted_Bytes[0].Length));
            textBox_Site2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[1], 0, Encrypted_Bytes[1].Length));
            textBox_Login1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[2], 0, Encrypted_Bytes[2].Length));
            textBox_Login2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[3], 0, Encrypted_Bytes[3].Length));
            textBox_Pass1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[4], 0, Encrypted_Bytes[4].Length));
            textBox_Pass2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[5], 0, Encrypted_Bytes[5].Length));

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                //Key = md5.ComputeHash(utf8.GetBytes(textBox_Site1.Text)),
                Key = md5.ComputeHash(utf8.GetBytes("aaa")),

                //Parametry dla 3DES
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor();

            //szyfrowanie wpisanego przez użytkownika tekstu od pierwszego znaku do ostatniego
            Encrypted_Bytes[0] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Site1.Text), 0, utf8.GetBytes(textBox_Site1.Text).Length);
            Encrypted_Bytes[1] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Site2.Text), 0, utf8.GetBytes(textBox_Site2.Text).Length);
            Encrypted_Bytes[2] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);
            Encrypted_Bytes[3] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login2.Text), 0, utf8.GetBytes(textBox_Login2.Text).Length);
            Encrypted_Bytes[4] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass1.Text), 0, utf8.GetBytes(textBox_Pass1.Text).Length);
            Encrypted_Bytes[5] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass2.Text), 0, utf8.GetBytes(textBox_Pass2.Text).Length);


            /*
            foreach (var item in Encrypted_Bytes[0])
            {
                MessageBox.Show(string.Format("byte_{0}", item));
            }
            */

            using (StreamWriter sw = new StreamWriter(File.Create(PathToDatabase)))
            {
                for (int i = 0; i < 6; i++)
                {
                    sw.WriteLine(BitConverter.ToString(Encrypted_Bytes[i]).Replace("-", ""));
                }

                sw.Dispose();
            }

            //konwersja zaszyfrowanych bajtów do łańcucha znakowego i przypisanie tego łańcucha do textBoxa'a w celu jego wyświetlenia
            //textBox_Encrypted.Text = BitConverter.ToString(Encrypted_Bytes);

            MessageBox.Show("Database was successfully saved.");

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


            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                //Key = md5.ComputeHash(utf8.GetBytes(textBox_Site1.Text)),
                Key = md5.ComputeHash(utf8.GetBytes("aaa")),

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
                Encrypted_Bytes[0] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Site1.Text), 0, utf8.GetBytes(textBox_Site1.Text).Length);
                Encrypted_Bytes[1] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Site2.Text), 0, utf8.GetBytes(textBox_Site2.Text).Length);
                Encrypted_Bytes[2] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);
                Encrypted_Bytes[3] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login2.Text), 0, utf8.GetBytes(textBox_Login2.Text).Length);
                Encrypted_Bytes[4] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass1.Text), 0, utf8.GetBytes(textBox_Pass1.Text).Length);
                Encrypted_Bytes[5] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass2.Text), 0, utf8.GetBytes(textBox_Pass2.Text).Length);


                /*
                foreach (var item in Encrypted_Bytes[0])
                {
                    MessageBox.Show(string.Format("byte_{0}", item));
                }
                */

                string path = saveFile.FileName;
                using (StreamWriter sw = new StreamWriter(File.Create(path)))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        sw.WriteLine(BitConverter.ToString(Encrypted_Bytes[i]).Replace("-", ""));
                    }
                    
                    sw.Dispose();
                }
            }
        }
    }
}
