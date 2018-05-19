using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
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

        private void Button_OK_Click(object sender, EventArgs e)
        {
            //utworzenie instacji kryptograficznej funkcji skrótu md5
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
            UTF8Encoding utf8 = new UTF8Encoding();

            Form1.Key = md5.ComputeHash(utf8.GetBytes(textBox_Key.Text));
        }

    }

}
