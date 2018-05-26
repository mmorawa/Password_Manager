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
        byte[][] Encrypted_Bytes = new byte[8][];

        //klucz
        public static byte[] Key { get; set; }
        public static string PathToDatabase { get; set; }

        //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
        UTF8Encoding utf8 = new UTF8Encoding();

        private List<Panel> Entries = new List<Panel>();

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
                        int lineCount = File.ReadLines(PathToDatabase).Count();
                        MessageBox.Show(lineCount.ToString());

                        for (int i = 0; i < lineCount; i++)
                        {
                            string line = sr.ReadLine();

                            Encrypted_Bytes[i] = new byte[(line.Length) / 2];
                            for (int d = 0; d < line.Length; d += 2)
                            {
                                Encrypted_Bytes[i][d / 2] = Convert.ToByte(line.Substring(d, 2), 16);
                            }
                        }


                        //utworzenie instacji szyfrowania 3DES
                        TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
                        {
                            //klucz wprowadzony przez użytkownika zahashowany md5
                            Key = Key,

                            //Parametry dla 3DES
                            Mode = CipherMode.ECB,
                            Padding = PaddingMode.PKCS7
                        };

                        //utworzenie nowej instancji deszyfratora
                        ICryptoTransform Decryptor = TripleDES.CreateDecryptor();

                        string[] Data = new string[lineCount];

                        for (int i = 0; i < lineCount; i++)
                        {
                            Data[i] = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[i], 0, Encrypted_Bytes[i].Length));
                        }


                        label_Site.Visible = true;
                        label_Login.Visible = true;
                        label_Password.Visible = true;
                        label_URL.Visible = true;

                        int position = 0;
                        for (int i = 0; i < lineCount/4; i++)
                        {
                            TextBox textBox_Site = new TextBox
                            {
                                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238),
                                Location = new Point(0, 2),
                                Name = "textBox_Site",
                                Size = new Size(216, 35),
                                Text = Data[position],
                                TabIndex = 4
                            };

                            position++;

                            TextBox textBox_URL = new TextBox
                            {
                                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                                Location = new Point(222, 2),
                                Name = "textBox_URL",
                                Size = new Size(216, 35),
                                Text = Data[position],
                                TabIndex = 19
                            };

                            position++;

                            TextBox textBox_Login = new TextBox
                            {
                                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                                Location = new Point(444, 2),
                                Name = "textBox_Login",
                                Size = new Size(216, 35),
                                Text = Data[position],
                                TabIndex = 5
                            };

                            position++;
                            
                            TextBox textBox_Pass = new TextBox
                            {
                                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                                Location = new Point(666, 2),
                                Name = "textBox_Pass",
                                Size = new Size(216, 35),
                                Text = Data[position],
                                TabIndex = 12,
                                UseSystemPasswordChar = true
                            };

                            position++;

                            Button Button_Show = new Button
                            {
                                Image = Properties.Resources.OneEye,
                                Location = new Point(888, 2),
                                Name = "Button_Show",
                                Tag = i,
                                Size = new Size(35, 35),
                                TabIndex = 24,
                                UseVisualStyleBackColor = true
                            };
                            Button_Show.Click += new EventHandler(Button_Show_Click);

                            Button Button_Plus = new Button
                            {
                                Image = Properties.Resources.Plus,
                                Location = new Point(929, 2),
                                Name = "Button_Plus",
                                Tag = i,
                                Size = new Size(35, 35),
                                TabIndex = 26,
                                UseVisualStyleBackColor = true
                            };
                            Button_Plus.Click += new EventHandler(Button_Plus_Click);

                            Button Button_Minus = new Button
                            {
                                Image = Properties.Resources.Minus,
                                Location = new Point(970, 2),
                                Name = "Button_Minus",
                                Tag = i,
                                Size = new Size(35, 35),
                                TabIndex = 28,
                                UseVisualStyleBackColor = true
                            };
                            Button_Minus.Click += new EventHandler(Button_Minus_Click);

                            Panel Entry = new Panel
                            {
                                Location = new Point(12, 160 + i * 43),
                                Name = "Entry",
                                Size = new Size(1015, 40),
                                TabIndex = 22,
                                Visible = true
                            };

                            Entry.Controls.Add(textBox_URL);
                            Entry.Controls.Add(Button_Minus);
                            Entry.Controls.Add(Button_Show);
                            Entry.Controls.Add(textBox_Site);
                            Entry.Controls.Add(Button_Plus);
                            Entry.Controls.Add(textBox_Login);
                            Entry.Controls.Add(textBox_Pass);
                            Controls.Add(Entry);
                            Entries.Add(Entry);
                        }


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
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //utworzenie nowej instancji szyfratora
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor();

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
                    textBox_Login1.Text = null;
                    textBox_Login2.Text = null;
                    textBox_Pass1.Text = null;
                    textBox_Pass2.Text = null;

                    label_Site.Visible = true;
                    label_Login.Visible = true;
                    label_Password.Visible = true;
                    label_URL.Visible = true;


                    TextBox textBox_Site = new TextBox
                    {
                        Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238),
                        Location = new Point(0, 2),
                        Name = "textBox_Site",
                        Size = new Size(216, 35),
                        TabIndex = 4
                    };

                    TextBox textBox_URL = new TextBox
                    {
                        Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                        Location = new Point(222, 2),
                        Name = "textBox_URL",
                        Size = new Size(216, 35),
                        TabIndex = 19
                    };

                    TextBox textBox_Login = new TextBox
                    {
                        Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                        Location = new Point(444, 2),
                        Name = "textBox_Login",
                        Size = new Size(216, 35),
                        TabIndex = 5
                    };


                    TextBox textBox_Pass = new TextBox
                    {
                        Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                        Location = new Point(666, 2),
                        Name = "textBox_Pass",
                        Size = new Size(216, 35),
                        TabIndex = 12,
                        UseSystemPasswordChar = true
                    };

                    Button Button_Show = new Button
                    {
                        Image = Properties.Resources.OneEye,
                        Location = new Point(888, 2),
                        Name = "Button_Show",
                        Tag = 0,
                        Size = new Size(35, 35),
                        TabIndex = 24,
                        UseVisualStyleBackColor = true
                    };
                    Button_Show.Click += new EventHandler(Button_Show_Click);

                    Button Button_Plus = new Button
                    {
                        Image = Properties.Resources.Plus,
                        Location = new Point(929, 2),
                        Name = "Button_Plus",
                        Tag = 0,
                        Size = new Size(35, 35),
                        TabIndex = 26,
                        UseVisualStyleBackColor = true
                    };
                    Button_Plus.Click += new EventHandler(Button_Plus_Click);

                    Button Button_Minus = new Button
                    {
                        Image = Properties.Resources.Minus,
                        Location = new Point(970, 2),
                        Name = "Button_Minus",
                        Tag = 0,
                        Size = new Size(35, 35),
                        TabIndex = 28,
                        UseVisualStyleBackColor = true
                    };
                    Button_Minus.Click += new EventHandler(Button_Minus_Click);

                    Panel Entry = new Panel
                    {
                        Location = new Point(12, 160),
                        Name = "Entry",
                        Size = new Size(1015, 40),
                        TabIndex = 22,
                        Visible = true
                    };

                    Entry.Controls.Add(textBox_URL);
                    Entry.Controls.Add(Button_Minus);
                    Entry.Controls.Add(Button_Show);
                    Entry.Controls.Add(textBox_Site);
                    Entry.Controls.Add(Button_Plus);
                    Entry.Controls.Add(textBox_Login);
                    Entry.Controls.Add(textBox_Pass);
                    Controls.Add(Entry);
                    Entries.Add(Entry);

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
                Encrypted_Bytes[2] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_URL1.Text), 0, utf8.GetBytes(textBox_URL1.Text).Length);
                Encrypted_Bytes[3] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_URL2.Text), 0, utf8.GetBytes(textBox_URL2.Text).Length);
                Encrypted_Bytes[4] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login1.Text), 0, utf8.GetBytes(textBox_Login1.Text).Length);
                Encrypted_Bytes[5] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Login2.Text), 0, utf8.GetBytes(textBox_Login2.Text).Length);
                Encrypted_Bytes[6] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass1.Text), 0, utf8.GetBytes(textBox_Pass1.Text).Length);
                Encrypted_Bytes[7] = Encryptor.TransformFinalBlock(utf8.GetBytes(textBox_Pass2.Text), 0, utf8.GetBytes(textBox_Pass2.Text).Length);



                string path = saveFile.FileName;
                using (StreamWriter sw = new StreamWriter(File.Create(path)))
                {
                    for (int i = 0; i < 6; i++)
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

            label_Site.Visible = false;
            label_Login.Visible = false;
            label_Password.Visible = false;
            label_URL.Visible = false;

            foreach (var item in Entries)
            {
                Controls.Remove(item);
            }

            Entries.Clear();

            MessageBox.Show("Database has been successfully closed.");
        }

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Button_Show_Click(object sender, EventArgs e)
        {
            //całość opiera się na Tagach
            Button Button_Show = (sender as Button);
            int Entry_Nr = (int)Button_Show.Tag;

            Control[] ctrls = Entries[Entry_Nr].Controls.Find("textBox_Pass", false);

            TextBox textBox_Pass = (TextBox)ctrls[0];
            if (textBox_Pass.UseSystemPasswordChar == true)
            {
                textBox_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Pass.UseSystemPasswordChar = true;
            }
            //MessageBox.Show(Entry_Nr.ToString());


        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            Button Button_Minus = (sender as Button);
            int Entry_Nr = (int)Button_Minus.Tag;
            Controls.Remove(Entries[Entry_Nr]);
            Entries.RemoveAt(Entry_Nr);

            //zmiana numeracji tag dla buttonow poniżej usuniętego + zmiana położenia tychże paneli
            for (int i = Entry_Nr; i < Entries.Count; i++)
            {
                Control[] ctrls0 = Entries[i].Controls.Find("Button_Show", false);
                Button Button_Show_Change = (Button)ctrls0[0];
                Button_Show_Change.Tag = i;

                Control[] ctrls1 = Entries[i].Controls.Find("Button_Plus", false);
                Button Button_Plus_Change = (Button)ctrls1[0];
                Button_Plus_Change.Tag = i;

                Control[] ctrls2 = Entries[i].Controls.Find("Button_Minus", false);
                Button Button_Minus_Change = (Button)ctrls2[0];
                Button_Minus_Change.Tag = i;

                Entries[i].Location = new Point(12, 160 + i * 43);
            }
            

        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            Button Button_Plus_Add = (sender as Button);
            int Entry_Nr = (int)Button_Plus_Add.Tag;


            TextBox textBox_Site = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238),
                Location = new Point(0, 2),
                Name = "textBox_Site",
                Size = new Size(216, 35),
                TabIndex = 4
            };

            TextBox textBox_URL = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                Location = new Point(222, 2),
                Name = "textBox_URL",
                Size = new Size(216, 35),
                TabIndex = 19
            };

            TextBox textBox_Login = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                Location = new Point(444, 2),
                Name = "textBox_Login",
                Size = new Size(216, 35),
                TabIndex = 5
            };


            TextBox textBox_Pass = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))),
                Location = new Point(666, 2),
                Name = "textBox_Pass",
                Size = new Size(216, 35),
                TabIndex = 12,
                UseSystemPasswordChar = true
            };

            Button Button_Show = new Button
            {
                Image = Properties.Resources.OneEye,
                Location = new Point(888, 2),
                Name = "Button_Show",
                Tag = Entry_Nr + 1,
                Size = new Size(35, 35),
                TabIndex = 24,
                UseVisualStyleBackColor = true
            };
            Button_Show.Click += new EventHandler(Button_Show_Click);

            Button Button_Plus = new Button
            {
                Image = Properties.Resources.Plus,
                Location = new Point(929, 2),
                Name = "Button_Plus",
                Tag = Entry_Nr + 1,
                Size = new Size(35, 35),
                TabIndex = 26,
                UseVisualStyleBackColor = true
            };
            Button_Plus.Click += new EventHandler(Button_Plus_Click);

            Button Button_Minus = new Button
            {
                Image = Properties.Resources.Minus,
                Location = new Point(970, 2),
                Name = "Button_Minus",
                Tag = Entry_Nr + 1,
                Size = new Size(35, 35),
                TabIndex = 28,
                UseVisualStyleBackColor = true
            };
            Button_Minus.Click += new EventHandler(Button_Minus_Click);

            Panel Entry = new Panel
            {
                Location = new Point(12, 160 + (Entry_Nr + 1) * 43),
                Name = "Entry",
                Size = new Size(1015, 40),
                TabIndex = 22,
                Visible = true
            };

            Entry.Controls.Add(textBox_URL);
            Entry.Controls.Add(Button_Minus);
            Entry.Controls.Add(Button_Show);
            Entry.Controls.Add(textBox_Site);
            Entry.Controls.Add(Button_Plus);
            Entry.Controls.Add(textBox_Login);
            Entry.Controls.Add(textBox_Pass);
            Controls.Add(Entry);
            Entries.Insert(Entry_Nr + 1, Entry);

            for (int i = Entry_Nr + 2; i  < Entries.Count; i ++)
            {
                Control[] ctrls0 = Entries[i].Controls.Find("Button_Show", false);
                Button Button_Show_Change = (Button)ctrls0[0];
                Button_Show_Change.Tag = i;

                Control[] ctrls1 = Entries[i].Controls.Find("Button_Plus", false);
                Button Button_Plus_Change = (Button)ctrls1[0];
                Button_Plus_Change.Tag = i;

                Control[] ctrls2 = Entries[i].Controls.Find("Button_Minus", false);
                Button Button_Minus_Change = (Button)ctrls2[0];
                Button_Minus_Change.Tag = i;

                Entries[i].Location = new Point(12, 160 + i * 43);
            }

        }
    }
}
