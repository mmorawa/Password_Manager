﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

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
                //TODO if cancel
                Form1.PathToDatabase = saveFile.FileName;
            }
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if ((textBox_Key.Text != "") && (textBox_Filename.Text != ""))
            {
                //utworzenie instacji kryptograficznej funkcji skrótu md5
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                //zdefiniowanie kodowania utf8 w celu późniejszej zamiany tekstu wprowadzanego przez użytkownika na bajty
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
