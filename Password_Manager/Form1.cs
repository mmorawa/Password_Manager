/*! \file Form1.cs
\brief Plik Form1.cs zawiera klasę Form1 z głównym oknem aplikacji.

Plik Form1.cs zawiera rdzeń programu czyli główne okno aplikacji wraz z menu, pozwalającym na dokonanie wyboru różnych opcji menadżera zadań takich jak: szyfrowanie/deszyfrowanie bazy danych.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

//! Przestrzeń nazw Password_Manager obejmuje całą aplikację Menedżera Haseł.
/*! Password_Manager to przestrzeń nazw obejmuje całą aplikację Menedżera Haseł, ze wszystkimi klasami Form. */
namespace Password_Manager
{
    //! Klasa Form1 zawiera główne okno aplikacji.
    /*! W klasie Form1 znajduje się menu główne aplikacji, przyciski oraz Textboxy z danymi, oraz warstwa logiczna aplikacji */
    public partial class Form1 : Form
    {

        //! Konstruktor klasy Form1.
        /*! Inicjalizuje komponenty klasy Form1. */
        public Form1()
        {
            InitializeComponent();
        }

        /*******************************************************************************
        * Atrybuty klasy Form1.
        ********************************************************************************/

        //! Tablica bajtowa wielowymiarowa zawierająca zaszyfrowane dane.
        /*! Tablica Encrypted_Bytes jest wykorzystywana pomocniczo do przechowywania danych przed ich zaszyfrowaniem lub odszyfrowaniem. */
        byte[][] Encrypted_Bytes;

        //! Klucz szyfrujący.
        /*! Właściwość Key zawiera hash md5 klucza, który szyfruje dane. */ 
        public static byte[] Key { get; set; }

        //! Ścieżka do pliku.
        /*! Właściwość typu string o nazwie PathToDatabase przechowuje ścieżkę do zapisywanego/otwieranego pliku. */
        public static string PathToDatabase { get; set; }

        //! Utworzenie obiektu utf8 z klasy UTF8Encoding.
        /*! Obiekt utf8 definiuje kodowanie utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty */
        UTF8Encoding utf8 = new UTF8Encoding(); 

        //! Lista zawierająca Panele z wpisami użytkownika.
        /*! Każdy Panel znajdujący się w Liście Entries składa się z kilku Textboxów zawierających dane odnośnie strony, 
         * loginu i hasła oraz przycisków odsłaniających hasła lub dodających/usuwających elementy tejże listy. 
         */
        private List<Panel> Entries = new List<Panel>();

        //TODO zabezpieczenia

        /*******************************************************************************
        *  Metody klasy Form1.
        ********************************************************************************/

        //! Metoda wywoływana naciśnięciem przycisku New.
        /*! Metoda Button_New_Click jest wywoływana poprzez wciśnięcie przycisku New w menu głównym aplikacji.
         * Najpierw otwiera nowe okno, gdzie pyta użytkownika o podstawowe dane odnośnie nowej bazy a następnie tworzy pierwszy Panel, w którym użytkownik może zacząć wpisywać swoje dane.
         */
        private void Button_New_Click(object sender, EventArgs e)
        {
            //TODO ostrzeżenie

            CloseDatabase();

            //Wywołanie okna Form3.
            using (Form3 form3 = new Form3())
            {
                DialogResult dr = form3.ShowDialog();


                if (dr == DialogResult.OK)
                {

                    label_Site.Visible = true;
                    label_Login.Visible = true;
                    label_Password.Visible = true;
                    label_URL.Visible = true;

                    //Generowanie pierwszego Panelu.
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

        //! Metoda wywoływana naciśnięciem przycisku Open.
        /*! 
         * Metoda Button_Open_Click jest wywoływana poprzez wciśnięcie przycisku Open w menu głównym aplikacji.
         * Odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generuje ona Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe. 
         */
        private void Button_Open_Click(object sender, EventArgs e)
        {
            //najpierw zamykamy wcześniejszą bazę z hasłami wywołując metodę CloseDatabase.
            CloseDatabase(); 

            //otwarcie nowego okna w celu załadowania wybranej bazy
            using (Form2 form2 = new Form2())
            {
                DialogResult dr = form2.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(PathToDatabase))
                        {
                            int lineCount = File.ReadLines(PathToDatabase).Count();

                            //odczytanie danych z pliku i przekonwertowanie do tablicy z bajtami
                            Encrypted_Bytes = new byte[lineCount][];
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

                            //Deszyfrowanie danych z tablicy bajtowej.
                            for (int i = 0; i < lineCount; i++)
                            {
                                Data[i] = utf8.GetString(Decryptor.TransformFinalBlock(Encrypted_Bytes[i], 0, Encrypted_Bytes[i].Length));
                            }

                            
                            label_Site.Visible = true;
                            label_Login.Visible = true;
                            label_Password.Visible = true;
                            label_URL.Visible = true;

                            //wygenerowanie Paneli z wpisami i podstawienie do nich odszyfrowanych danych
                            int position = 0;
                            for (int i = 0; i < lineCount / 4; i++)
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
                    catch (Exception)
                    {
                        MessageBox.Show("Bad data or invalid password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //! Metoda wywoływana naciśnięciem przycisku Change.
        /*! Metoda Button_change_Click jest wywoływana poprzez wciśnięcie przycisku Change w menu głównym aplikacji.
         * Umożliwia ona zmianę klucza szyfrującego bazę z hasłami.
         */
        private void Button_change_Click(object sender, EventArgs e)
        {
            if (Entries.Count == 0)
            {
                MessageBox.Show("First open or load Database.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (Form4 form4 = new Form4())
            {
                DialogResult dr = form4.ShowDialog();


                if (dr == DialogResult.OK)
                {
                    SaveDatabase(PathToDatabase);

                    MessageBox.Show("The Key has been changed.", "Information");
                }
            }
        }


        //! Metoda wywoływana naciśnięciem przycisku Save.
        /*! Metoda Button_Save_Click jest wywoływana poprzez wciśnięcie przycisku Save w menu głównym aplikacji.
         * Powoduje ona wywołanie metody SaveDatabase, która automatycznie szyfruje wpisy z hasłami, znajdujące się w głównym oknie programu bez konieczności podania ścieżki do pliku bazy.
         */
        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Entries.Count == 0)
            {
                MessageBox.Show("There is nothing to save.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveDatabase(PathToDatabase);

            MessageBox.Show("Database has been successfully saved.", "Information");
        }

        //! Metoda wywoływana naciśnięciem przycisku Save As.
        /*! Metoda Button_SaveAs_Click jest wywoływana poprzez wciśnięcie przycisku Save As w menu głównym aplikacji.
         * W wyniku jej użycia pojawia się nowe okno dialogowe, w którym możemy wybrać ścieżkę do pliku bazy, po czym następuje wywołanie metody SaveDatabase, która szyfruje wpisy z hasłami, znajdujące się w głównym oknie programu.
         */
        private void Button_SaveAs_Click(object sender, EventArgs e)
        {
            if (Entries.Count == 0)
            {
                MessageBox.Show("There is nothing to save.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "File name | *.txt",
                FileName = "Database.txt",
                Title = "Save Database:"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //Zapisanie danych do pliku.
                string path = saveFile.FileName;

                SaveDatabase(path);

                MessageBox.Show("Database has been successfully saved.", "Information");
            }
        }

        //! Metoda wywoływana naciśnięciem przycisku Close.
        /*! Metoda Button_Close_Click jest wywoływana poprzez wciśnięcie przycisku Close w menu głównym aplikacji.
         * Powoduje ona zamknięcie aktywnej bazy poprzez wywołanie metody CloseDatabase.
         */
        private void Button_Close_Click(object sender, EventArgs e)
        {
            if (Entries.Count == 0)
            {
                MessageBox.Show("There is nothing to close.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CloseDatabase();
            MessageBox.Show("Database has been successfully closed.", "Information");
        }

        //! Metoda wywoływana naciśnięciem przycisku Exit.
        /*! Metoda Button_Exit_Click jest wywoływana poprzez wciśnięcie przycisku Exit w menu głównym aplikacji.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            CloseDatabase();
            Application.Exit();
        }

        //! Metoda wywoływana przy zamykaniu aktywnej bazy.
        /*! Metoda CloseDatabase służy do zamknięcia aktywnej bazy poprzez usunięcie wpisów z hasłami z głównego okna aplikacji oraz z pamięci RAM. */
        private void CloseDatabase()
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

        }

        //! Metoda wywoływana przy zapisywaniu aktywnej bazy.
        /*! Metoda SaveDatabase służy do zapisania aktywnej bazy poprzez utworzenie nowego obiektu szyfratora i dokonanie transformacji blokowej tablicy bajtowej z danymi.
         * Po zaszyfrowaniu dane zostają zapisane do pliku tekstowego z bazą.
         */
        private void SaveDatabase(string PathDB)
        {
            //Utworzenie instacji szyfrowania 3DES.
            TripleDESCryptoServiceProvider TripleDES = new TripleDESCryptoServiceProvider
            {
                //Klucz wprowadzony przez użytkownika zahashowany md5.
                Key = Key,

                //Parametry dla 3DES.
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            //Utworzenie nowej instancji szyfratora.
            ICryptoTransform Encryptor = TripleDES.CreateEncryptor();

            Encrypted_Bytes = new byte[Entries.Count * 4][];
            string[] Data = new string[Entries.Count * 4];
            int position = 0;


            //Wstawienie danych z Textboxów do tablicy Data, która zostanie zaszyfrowana.
            for (int i = 0; i < Entries.Count; i++)
            {
                Control[] ctrls0 = Entries[i].Controls.Find("textBox_Site", false);
                TextBox textBox_Site_Encrypt = (TextBox)ctrls0[0];
                Data[position] = textBox_Site_Encrypt.Text;
                position++;

                Control[] ctrls1 = Entries[i].Controls.Find("textBox_URL", false);
                TextBox textBox_URL_Encrypt = (TextBox)ctrls1[0];
                Data[position] = textBox_URL_Encrypt.Text;
                position++;

                Control[] ctrls2 = Entries[i].Controls.Find("textBox_Login", false);
                TextBox textBox_Login_Encrypt = (TextBox)ctrls2[0];
                Data[position] = textBox_Login_Encrypt.Text;
                position++;

                Control[] ctrls3 = Entries[i].Controls.Find("textBox_Pass", false);
                TextBox textBox_Pass_Encrypt = (TextBox)ctrls3[0];
                Data[position] = textBox_Pass_Encrypt.Text;
                position++;
            }

            //Zaszyfrowanie danych.
            for (int i = 0; i < Entries.Count * 4; i++)
            {
                Encrypted_Bytes[i] = Encryptor.TransformFinalBlock(utf8.GetBytes(Data[i]), 0, utf8.GetBytes(Data[i]).Length);
            }

            //Zapisanie danych do pliku.
            using (StreamWriter sw = new StreamWriter(File.Create(PathDB)))
            {
                for (int i = 0; i < Entries.Count * 4; i++)
                {
                    sw.WriteLine(BitConverter.ToString(Encrypted_Bytes[i]).Replace("-", ""));
                }

                sw.Dispose();
            }
        }

        //! Metoda wywoływana po naciśnięciu przycisku z ikoną oka.
        /*! Metoda Button_Show_Click jest wywoływana po naciśnięciu przycisku z ikoną oka, który znajduje się obok każdego wpisu.
         * Służy ona do pokazywania hasła, które standardowo ukryte jest pod gwiazdkami.
         */
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
        }

        //! Metoda wywoływana po naciśnięciu przycisku z ikoną plusa.
        /*! Metoda Button_Plus_Click jest wywoływana po naciśnięciu przycisku z ikoną plusa. 
         * Dzięki niej można dodać nowy pusty wpis do okna głównego aplikacji.
         */
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

            //Zmiana numeracji tag dla buttonow poniżej dodanego + zmiana położenia tychże paneli.
            for (int i = Entry_Nr + 2; i < Entries.Count; i++)
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

        //! Metoda wywoływana po naciśnięciu przycisku z ikoną minusa.
        /*! Metoda Button_Minus_Click jest wywoływana po naciśnięciu przycisku z ikoną minusa. 
         * Powoduje ona usunięcie wpisu z okna głównego aplikacji.
         */
        private void Button_Minus_Click(object sender, EventArgs e)
        {
            Button Button_Minus = (sender as Button);
            int Entry_Nr = (int)Button_Minus.Tag;
            Controls.Remove(Entries[Entry_Nr]);
            Entries.RemoveAt(Entry_Nr);

            //Zmiana numeracji tag dla buttonow poniżej usuniętego + zmiana położenia tychże paneli.
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

        //! Metoda wywoływana po naciśnięciu przycisku New na pasku Menu.
        /*! Metoda NewToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku New na pasku Menu.
         * Najpierw otwiera nowe okno, gdzie pyta użytkownika o podstawowe dane odnośnie nowej bazy a następnie tworzy pierwszy Panel, w którym użytkownik może zacząć wpisywać swoje dane.
         */
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_New_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Open na pasku Menu.
        /*! Metoda OpenToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Open na pasku Menu.
         * Odpowiada za wczytanie pliku z bazą haseł a następnie jego odszyfrowanie przy użyciu podanego przez użytkownika klucza.
         * Następnie generuje ona Panele z Textboxami, do których podstawiane są odszyfrowane dane tekstowe. 
         */
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_Open_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Save na pasku Menu.
        /*! Metoda SaveToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save na pasku Menu.
         * Powoduje ona automatyczne zaszyfrowanie wpisów z hasłami, znajdujących w głównym oknie programu bez konieczności podania ścieżki do pliku bazy.
         */
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_Save_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Save As na pasku Menu.
        /*! Metoda SaveAsToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Save As na pasku Menu.
         * Powoduje ona zamknięcie aktywnej bazy poprzez wywołanie metody CloseDatabase.
         */
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_SaveAs_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Close na pasku Menu.
        /*! Metoda CloseToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Close na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_Close_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Exit na pasku Menu.
        /*! Metoda ExitToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Exit na pasku Menu.
         * Skutkuje ona zamknięciem aktywnej bazy poprzez wywołanie metody CloseDatabase oraz wyjściem z programu.
         */
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_Exit_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Change Key na pasku Menu.
        /*! Metoda ChangeKeyToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Change Key na pasku Menu.
         * Umożliwia ona zmianę klucza szyfrującego bazę z hasłami.
         */
        private void ChangeKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_change_Click(sender, e);
        }

        //! Metoda wywoływana po naciśnięciu przycisku Cut na pasku Menu.
        /*! Metoda CutToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Cut na pasku Menu.
         * Wycina ona zaznaczony tekst i przechowuje go w schowku systemowym.
         */
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = ActiveControl;

            if (ctrl != null)
            {
                if (ctrl is TextBox textBox_Cut)
                {
                    textBox_Cut.Cut();
                }
            }
        }

        //! Metoda wywoływana po naciśnięciu przycisku Copy na pasku Menu.
        /*! Metoda CopyToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Copy na pasku Menu.
         * Kopiuje ona zaznaczony tekst i przechowuje go w schowku systemowym.
         */
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = ActiveControl;

            if (ctrl != null)
            {
                if (ctrl is TextBox textBox_Copy)
                {
                    textBox_Copy.Copy();
                }
            }

        }

        //! Metoda wywoływana po naciśnięciu przycisku Paste na pasku Menu.
        /*! Metoda PasteToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku Paste na pasku Menu.
         * Wkleja ona tekst ze schowka systemowego w miejscu, gdzie znajduje się aktywny kursor.
         */
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control ctrl = ActiveControl;
            if (ctrl != null)
            {
                if (ctrl is TextBox textBox_Paste)
                {
                    textBox_Paste.Paste();
                }
            }
        }

        //! Metoda wywoływana po naciśnięciu przycisku About na pasku Menu.
        /*! Metoda AboutToolStripMenuItem_Click jest wywoływana po naciśnięciu przycisku About na pasku Menu.
         * Powoduje ona wyświetlenie się okna z informacjami o aplikacji.
         */
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox Abox = new AboutBox())
            {
                DialogResult dr = Abox.ShowDialog();
            }
        }
    }
}
