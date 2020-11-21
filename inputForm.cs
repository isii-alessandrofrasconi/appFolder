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

namespace appFolder
{
    public partial class inputForm : Form
    {
        public inputForm()
        {
            InitializeComponent();
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            string title = txb_title.Text;
            string url = txb_url.Text;
            string img = txb_picture.Text;
            

            StreamWriter strw = new StreamWriter("data.txt", true);

            strw.WriteLine("{");
            strw.WriteLine("title: " + title + ",");
            strw.WriteLine("url: " + url + ",");
            strw.WriteLine("image: " + img + ",");
            strw.WriteLine("}");

            strw.Close();
        }

        private void btn_explore_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Program (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                }
            }

            txb_url.Text = filePath;
            txb_title.Text = filePath.Split('\\')[filePath.Split('\\').Length - 1].Replace(".exe", "").ToString();
        }

        private void btnExplore1_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Icon (*.ico)|*.ico|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                }
            }

            txb_picture.Text = filePath;

        }
    }
}
