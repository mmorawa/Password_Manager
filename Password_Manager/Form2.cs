using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string Key;
        public static string PathToDatabase;

        private void Button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open file with Database";
            openFile.Filter = "Text files |*.txt| All files |*.*";
            DialogResult dr2 = openFile.ShowDialog();
            //magic
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
