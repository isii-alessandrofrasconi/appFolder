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


namespace appFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            inputForm f1 = new inputForm();
            f1.Show();

        }

        private void app_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;

            System.Diagnostics.Process.Start(b1.Name);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader str = new StreamReader("data.txt");

                addBtn.Enabled = false;
                string[] temp = str.ReadToEnd().Split('}');
                int nApp = temp.Length;

            for (int i = 0; i < nApp; i++)
            {
                Button b = new Button();
                string[] t = temp[i].Replace("title: ", "").Replace("{", "").Replace("url: ", "").Replace("image: ", "").Split(',');
                if (t.Length > 1)
                {
                    b.Text = t[0].Trim();
                    b.AutoSize = true;
                    b.Name = t[1].Trim();
                    b.Image = t[2].Trim();
                    b.Click += app_Click;

                    if (t[0].Trim() != "")
                        flpStage.Controls.Add(b);
                }
            }

            str.Close();
            addBtn.Enabled = true;
        }
    }
}
