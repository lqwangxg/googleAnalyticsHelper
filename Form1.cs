using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Text.RegularExpressions;

namespace GoogleAnalyticsHelper
{
    public partial class Form1 : Form
    {
        private const string pattern_header = @"\s*\<\/head\>";
        private static HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void linkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/SignUp");
        }

        private void linkTryConnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        

        private void linkAnalytics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/analytics/");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string TrackingId = string.Format("{0}-{1}-{2}", txtTrackingH1.Text, txtTrackingH2.Text, txtTrackingH3.Text);
            txtResult.Text = txtTemplate.Text.Replace("TrackingId", TrackingId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void chkTrackEdit_CheckedChanged(object sender, EventArgs e)
        {
            txtTrackingH1.Enabled = chkTrackEdit.Checked;
            txtTrackingH3.Enabled = chkTrackEdit.Checked;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    lblHtmlFile.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        if (Regex.IsMatch(fileContent, pattern_header, RegexOptions.IgnoreCase | RegexOptions.Multiline))
                        {
                            string newContent = Regex.Replace(fileContent, pattern_header, "\r\n" + txtResult.Text + "$0");
                            string newFileName = lblHtmlFile.Text + "_new.html";
                            File.WriteAllText(newFileName, newContent);
                            MessageBox.Show("処理正常終了しました。新作成ファイル：\n"+ newFileName, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("</head>タグが見つかりません、処理中止しました。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            
        }
    }
}
