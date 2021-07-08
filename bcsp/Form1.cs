using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;


namespace bcsp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Startbutton.Enabled = false;
        }
        string dirName, dirName2;

        private void Path1button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории1";
            DirDialog.SelectedPath = @"C:\";

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                PathArc1TextBox.Text = DirDialog.SelectedPath;
            }
        }

        private void Path2button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории2";
            DirDialog.SelectedPath = @"C:\";

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                PathArc2TextBox.Text = DirDialog.SelectedPath;
            }
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {            
            dirName = PathArc1TextBox.Text;

            dirName2 = PathArc2TextBox.Text;

            if (PathArc1TextBox.Text == PathArc2TextBox.Text)
            {
                MessageBox.Show(
    "Каталоги разные быть должны",
    "Сообщение",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1);                
            } else {
                res_textBox.Text = "";

                using (TextWriter text = new StreamWriter(dirName + @"\bcsp.txt"))
                {
                    GetFiles(dirName, dirName2, text);
                }

   //             if (res_textBox.Text != "")
     //           {
                    res_textBox.Text += (Environment.NewLine + "complete");
         //       }
           //     else
             //   {
               //     res_textBox.Text = ("нет одинаковых файлов");
              //  }
            }
        }

        private static string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }

        private void GetFiles(string path1, string path2, TextWriter text)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path1);
                DirectoryInfo dir2 = new DirectoryInfo(path2);
                FileInfo[] files = dir.GetFiles();
                FileInfo[] files2 = dir2.GetFiles();
                foreach (FileInfo f in files)
                {
                    if (f.Name == "bcsp.txt")
                    {
                        continue;
                    }
                    foreach (FileInfo f2 in files2)
                    {
                        if (ComputeMD5Checksum(f2.FullName) == ComputeMD5Checksum(f.FullName))
                        {
                            text.WriteLine(f.Name + " - " + f.LastWriteTime);
                            text.WriteLine(f2.Name + " - " + f2.LastWriteTime);
                            text.WriteLine("\t" + "одинаковые - " + ComputeMD5Checksum(f.FullName) + "\n");
                            res_textBox.Text += (f.Name + " = " + f2.Name + " = " + ComputeMD5Checksum(f.FullName) + Environment.NewLine);
                        }
                    }

                }

                foreach (DirectoryInfo d in dir.GetDirectories())
                {
                    GetFiles(path1 + d.Name + @"\", path2 + d.Name + @"\", text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void openPath1button_Click(object sender, EventArgs e)
        {
            //            if (Directory.Exists(PathArc1TextBox.Text))
            //            {
            //                Process.Start(PathArc1TextBox.Text);
            //            }
            Nextver();
        }

        private void PathArc1TextBox_TextChanged(object sender, EventArgs e)
        {
            StartbuttonEnabled();
        }

        private void openTXTbutton_Click(object sender, EventArgs e)
        {
            if (File.Exists(dirName + @"\bcsp.txt"))
            {
                Process.Start(@"notepad.exe ", dirName + @"\bcsp.txt");
            }
        }

        private void PathArc2TextBox_TextChanged(object sender, EventArgs e)
        {
            StartbuttonEnabled();
        }

        private void StartbuttonEnabled()
        {
            if (Directory.Exists(PathArc1TextBox.Text) && Directory.Exists(PathArc2TextBox.Text))
            {
                Startbutton.Enabled = true;
            }
            else
            {
                Startbutton.Enabled = false;
            }
        }

        private void openPath2button_Click(object sender, EventArgs e)
        {
            Nextver();
        }

        private void Nextver()
        {
            MessageBox.Show(
            "Кнопка пока не работает",
            "Ожидайте следующую версию",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }
    }
}
