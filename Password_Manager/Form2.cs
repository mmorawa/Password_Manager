﻿using System;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string Key { get; set; }
        public static string PathToDatabase { get; set; }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open file with Database";
            openFile.Filter = "Text files |*.txt| All files |*.*";
            DialogResult dr2 = openFile.ShowDialog();
            //wewnętrzny Dialog
            DialogResult = DialogResult.None;

            if (dr2 == DialogResult.OK)
            {
                textBox_Filename.Text = openFile.FileName;
                PathToDatabase = openFile.FileName;
            }
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Key = textBox_Key2.Text;
        }

    }

}
