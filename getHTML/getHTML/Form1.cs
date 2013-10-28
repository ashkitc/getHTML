using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace getHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void goButtom_Click(object sender, EventArgs e)
        {
            string url = urlField.Text;
            //Add http:// prefix if need
            if (!url.StartsWith("http://"))
            {
                url = "http://" + url;
            }
            try
            {
                browser.Url = new Uri(url);
            }
            catch (UriFormatException)
            {
                // If entered url is invalid clean url field
                urlField.Text = "";
            }
           
        }

        private void getHTMLButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog folderBrowser = new SaveFileDialog();
            //Choose the file for saving
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //Write inner html to chosen file
                string html = browser.DocumentText;
                System.IO.File.WriteAllText(folderBrowser.FileName, html);
            }

        }
    }
}
