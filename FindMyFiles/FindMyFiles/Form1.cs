using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSerchTerm.Text != string.Empty)
            {
                var directoryName = ConfigurationManager.AppSettings["SearchDirectories"];
                SearchFiles(directoryName, txtPattern.Text);
            }
        }

        private void SearchFiles(string dirName, string searchPattern)
        {
            var files = Directory.GetFiles(dirName, string.Format("*{0}{1}", txtSerchTerm.Text, searchPattern), SearchOption.AllDirectories);
            var dirInfo = new DirectoryInfo(dirName);

            lstFiles.Items.Clear();

            foreach (var file in files)
            {
                lstFiles.Items.Add(file);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in lstFiles.SelectedItems)
            {
                var file = new FileInfo((string)item);
                File.Copy((string)item, string.Format("{0}\\{1}", txtDestPath.Text, file.Name),true);
            }

            MessageBox.Show("Done!");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            foreach (var item in lstFiles.SelectedItems)
            {
                System.Diagnostics.Process.Start((string)item);
            }
        }
    }
}
