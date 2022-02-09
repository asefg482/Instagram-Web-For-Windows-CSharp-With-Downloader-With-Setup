using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram__unofficial_version_
{
    public partial class Download_Frm : Form
    {
        public Download_Frm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Download_Frm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Paste();
            MessageBox.Show("Warning Do not close the form until you see the end of the download message","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) == false)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        string url = textBox1.Text;
                        string sourceCode = WorkingClass.getSourceCode(url);

                        int startIndex = sourceCode.IndexOf("og:image") + 19;
                        sourceCode = sourceCode.Substring(startIndex, sourceCode.Length - startIndex);
                        int startIndexFile = sourceCode.IndexOf(".ak.instagram.com/") + 18;
                        int endIndex = sourceCode.IndexOf(".jpg");
                        string link = sourceCode.Substring(0, endIndex + 4);
                        string fileName = sourceCode.Substring(startIndexFile, endIndex - startIndexFile);


                        System.IO.StreamWriter file = new System.IO.StreamWriter("sourceCode.txt");
                        file.WriteLine(sourceCode);
                        file.Close();

                        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                        saveFileDialog1.Filter = "jpg|*.jpg";
                        saveFileDialog1.InitialDirectory = path;
                        saveFileDialog1.AddExtension = true;
                        saveFileDialog1.FileName = fileName;
                        saveFileDialog1.OverwritePrompt = true;
                        saveFileDialog1.DefaultExt = ".jpg";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            Uri realLink = new Uri(link);
                            WebClient wc = new WebClient();
                            wc.DownloadFileAsync(realLink, saveFileDialog1.FileName);

                        }
                        MessageBox.Show("Downloaded image: " + fileName + "." + saveFileDialog1.DefaultExt + "!");
                    }
                    else
                    {
                        string url = textBox1.Text;
                        string sourceCode = WorkingClass.getSourceCode(url);

                        int startIndex = sourceCode.IndexOf("og:video") + 19;
                        sourceCode = sourceCode.Substring(startIndex, sourceCode.Length - startIndex);
                        int startIndexFile = sourceCode.IndexOf(".ak.instagram.com/") + 18;
                        int endIndex = sourceCode.IndexOf(".mp4");
                        string link = sourceCode.Substring(0, endIndex + 4);
                        string fileName = sourceCode.Substring(startIndexFile, endIndex - startIndexFile);


                        System.IO.StreamWriter file = new System.IO.StreamWriter("sourceCode.txt");
                        file.WriteLine(sourceCode);
                        file.Close();

                        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        SaveFileDialog saveFileDialog2 = new SaveFileDialog();

                        saveFileDialog2.Filter = "mp4|*.mp4";
                        saveFileDialog2.InitialDirectory = path;
                        saveFileDialog2.AddExtension = true;
                        saveFileDialog2.FileName = fileName;
                        saveFileDialog2.OverwritePrompt = true;
                        saveFileDialog2.DefaultExt = ".mp4";
                        if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                        {
                            Uri realLink = new Uri(link);
                            WebClient wc = new WebClient();
                            wc.DownloadFileAsync(realLink, saveFileDialog2.FileName);

                        }
                        MessageBox.Show("Downloaded image: " + fileName + "." + saveFileDialog1.DefaultExt + "!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter The Link");
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}