using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTextFileActions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Holders\3_IT\Проекты\Study\StudyProject\StudyTextFileActions\Test.txt";

            //File.Move(path, path.Replace("1.txt", "1\\1.txt"));


            // используя using нам не надо будет открывать и закрывать потоки, процедура будет выполнена используя то, что указано ввыше неё в using
            //using (WebClient wc = new WebClient())
            //{
            //wc.DownloadFile("https://www.rulit.me/download-books-48237.html?t=txt", path);
            //}


            //using (FileStream file = new FileStream(path, FileMode.Append))
            //{
                using (StreamWriter stream = new StreamWriter(path, true))
                {
                    stream.WriteLine("Test");
                //label2.Focus();
                label2.Text = "Done!";
                }


                //не надо такого теперь
                //stream.Close();
            //}




        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
