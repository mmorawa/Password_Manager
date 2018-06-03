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
        byte[][] Encrypted_Bytes = new byte [8][];

        byte[] IV;

        //klucz
        public static byte[] Key { get; set; }
        public static string PathToDatabase { get; set; }

        //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
        UTF8Encoding utf8 = new UTF8Encoding();

        //TODO zabezpieczenia
        private void Button_Open_Click(object sender, EventArgs e)
        {

            using (Form2 form2 = new Form2())
            {
                DialogResult dr = form2.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(PathToDatabase))
                    {
                        string lineIV = sr.ReadLine();
                        IV = new byte[8];

                        for (int m = 0; m < lineIV.Length; m += 2)
                        {
                            IV[m / 2] = Convert.ToByte(lineIV.Substring(m, 2), 16);
                        }

                        for (int i = 0; i < 8; i++)
                        {
                            string line = sr.ReadLine();
                            
                            Encrypted_Bytes[i] = new byte[(line.Length) / 2];
                            for (int d = 0; d < line.Length; d += 2)
                            {
                                Encrypted_Bytes[i][d / 2] = Convert.ToByte(line.Substring(d, 2), 16);
                            }
                        }

                        label_Site.Visible = true;
                        label_Login.Visible = true;
                        label_Password.Visible = true;

                        panel1.Visible = true;
                        panel2.Visible = true;

                        //utworzenie instacji szyfrowania 3DES
                        TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
                        {
                            //klucz wprowadzony przez użytkownika zahashowany md5
                            Key = Key,
                            IV = IV,
                            //Parametry dla 3DES
                            Mode = CipherMode.CBC,
                            Padding = PaddingMode.PKCS7
                        };

                        //utworzenie nowej instancji deszyfratora
                        ICryptoTransform Decryptor = TripleDES.CreateDecryptor(TripleDES.Key, TripleDES.IV);

                        //deszyfrowanie tablicy z bajtami od pierwszego elementu do końca, a następnie przetworzenie do łańcucha znakowego i wysłanie do textBox'a
                        textBox_Site1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[0], 0, Encrypted_Bytes[0].Length));
                        textBox_Site2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[1], 0, Encrypted_Bytes[1].Length));
                        textBox_URL1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[2], 0, Encrypted_Bytes[2].Length));
                        textBox_URL2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[3], 0, Encrypted_Bytes[3].Length));
                        textBox_Login1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[4], 0, Encrypted_Bytes[4].Length));
                        textBox_Login2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[5], 0, Encrypted_Bytes[5].Length));
                        textBox_Pass1.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[6], 0, Encrypted_Bytes[6].Length));
                        textBox_Pass2.Text = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[7], 0, Encrypted_Bytes[7].Length));
                    }
                }
            }



        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                Key = Key,

                //Parametry dla 3DES
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            TripleDES.GenerateIV();
            IV = TripleDES.IV;

            /*
            foreach (var item in IV)
            {
                MessageBox.Show(string.Format("byte_", item));
            }
            */

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor(TripleDES.Key, TripleDES.IV);

            //szyfrowanie wpisanego przez użytkownika tekstu od pierwszego znaku do ostatniego
            Encrypted_Bytes[0] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Site1.Text), 0, utf8.GetBytes(textBox_Site1.Text).Length);
            Encrypted_Bytes[1] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Site2.Text), 0, utf8.GetBytes(textBox_Site2.Text).Length);
            Encrypted_Bytes[2] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_URL1.Text), 0, utf8.GetBytes(textBox_URL1.Text).Length);
            Encrypted_Bytes[3] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_URL2.Text), 0, utf8.GetBytes(textBox_URL2.Text).Length);
            Encrypted_Bytes[4] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);
            Encrypted_Bytes[5] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login2.Text), 0, utf8.GetBytes(textBox_Login2.Text).Length);
            Encrypted_Bytes[6] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass1.Text), 0, utf8.GetBytes(textBox_Pass1.Text).Length);
            Encrypted_Bytes[7] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass2.Text), 0, utf8.GetBytes(textBox_Pass2.Text).Length);


            


            using (StreamWriter sw = new StreamWriter(File.Create(PathToDatabase)))
            {
                sw.WriteLine(BitConverter.ToString(IV).Replace("-", ""));

                for (int i = 0; i < 8; i++)
                {
                    sw.WriteLine(BitConverter.ToString(Encrypted_Bytes[i]).Replace("-", ""));
                }

                sw.Dispose();
            }

            //konwersja zaszyfrowanych bajtów do łańcucha znakowego i przypisanie tego łańcucha do textBoxa'a w celu jego wyświetlenia
            //textBox_Encrypted.Text = BitConverter.ToString(Encrypted_Bytes);

            MessageBox.Show("Database has been successfully saved.");

        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                DialogResult dr = form3.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    textBox_Site1.Text = null;
                    textBox_Site2.Text = null;
                    textBox_URL1.Text = null;
                    textBox_URL2.Text = null;
                    textBox_Login1.Text = null;
                    textBox_Login2.Text = null;
                    textBox_Pass1.Text = null;
                    textBox_Pass2.Text = null;


                    label_Site.Visible = true;
                    label_Login.Visible = true;
                    label_Password.Visible = true;
                    label_URL.Visible = true;
                    panel1.Visible = true;
                    panel2.Visible = true;
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
                    MessageBox.Show("The Key has been changed.");

                }
            }
        }

        private void Button_SaveAs_Click(object sender, EventArgs e)
        {


            //utworzenie instacji szyfrowania 3DES
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //klucz wprowadzony przez użytkownika zahashowany md5
                Key = Key,

                //Parametry dla 3DES
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            TripleDES.GenerateIV();
            IV = TripleDES.IV;

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor(TripleDES.Key, TripleDES.IV);


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
                Encrypted_Bytes[2] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_URL1.Text), 0, utf8.GetBytes(textBox_URL1.Text).Length);
                Encrypted_Bytes[3] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_URL2.Text), 0, utf8.GetBytes(textBox_URL2.Text).Length);
                Encrypted_Bytes[4] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);
                Encrypted_Bytes[5] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login2.Text), 0, utf8.GetBytes(textBox_Login2.Text).Length);
                Encrypted_Bytes[6] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass1.Text), 0, utf8.GetBytes(textBox_Pass1.Text).Length);
                Encrypted_Bytes[7] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass2.Text), 0, utf8.GetBytes(textBox_Pass2.Text).Length);


                /*
                foreach (var item in Encrypted_Bytes[0])
                {
                    MessageBox.Show(string.Format("byte_{0}", item));
                }
                */

                string path = saveFile.FileName;
                using (StreamWriter sw = new StreamWriter(File.Create(path)))
                {
                    sw.WriteLine(BitConverter.ToString(IV).Replace("-", ""));

                    for (int i = 0; i < 8; i++)
                    {
                        sw.WriteLine(BitConverter.ToString(Encrypted_Bytes[i]).Replace("-", ""));
                    }
                    
                    sw.Dispose();
                }

                MessageBox.Show("Database has been successfully saved.");
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Key = null;
            IV = null;
            /*
            for (int i = 0; i < Encrypted_Bytes.Length; i++)
            {
                Encrypted_Bytes[i] = null;
            }
            */
            textBox_Site1.Text = null;
            textBox_Site2.Text = null;
            textBox_URL1.Text = null;
            textBox_URL2.Text = null;
            textBox_Login1.Text = null;
            textBox_Login2.Text = null;
            textBox_Pass1.Text = null;
            textBox_Pass2.Text = null;


            label_Site.Visible = false;
            label_Login.Visible = false;
            label_Password.Visible = false;
            label_URL.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;

            MessageBox.Show("Database has been successfully closed.");
        }

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Show1_Click(object sender, EventArgs e)
        {
            bool state = textBox_Pass1.UseSystemPasswordChar;

            if (state == true)
            {
                textBox_Pass1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Pass1.UseSystemPasswordChar = true;
            }
        }

        private void Button_Show2_Click(object sender, EventArgs e)
        {
            bool state = textBox_Pass2.UseSystemPasswordChar;

            if (state == true)
            {
                textBox_Pass2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Pass2.UseSystemPasswordChar = true;
            }
        }
    }
}
