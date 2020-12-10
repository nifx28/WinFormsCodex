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
using WinFormsApp.Properties;

namespace WinFormsApp
{
    public partial class WinForms : Form
    {
        private string Caption;

        public WinForms()
        {
            InitializeComponent();
            Caption = this.Text;
        }

        private void WinForms_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = Settings.Default.LastFilePath;
        }

        private void WinForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool needUpdate = false;
            string filePath = txtFilePath.Text;

            if (!string.IsNullOrWhiteSpace(filePath) && Settings.Default.LastFilePath != filePath)
            {
                Settings.Default.LastFilePath = filePath;
                needUpdate = true;
            }

            if (needUpdate)
            {
                Settings.Default.Save();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                this.txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show(this, $@"""{filePath}"" 檔案不存在！", Caption);
                return;
            }

            txtResult.Text = "檔案內容為：";

            using (StreamReader reader  = File.OpenText(filePath))
            {
                string line = null;
                int i = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (txtResult.Text.Length > 0)
                    {
                        txtResult.Text += Environment.NewLine;
                    }

                    txtResult.Text += $"{i + 1,2:D}. {line}";
                    i++;
                }

                lbLineCountValue.Text = $"{i}";
            }
        }

        private void btnGetLastLine_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show(this, $@"""{filePath}"" 檔案不存在！", Caption);
                return;
            }

            using (StreamReader reader = File.OpenText(filePath))
            {
                string line = null, lastLine = string.Empty;
                int i = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lastLine = line;
                    i++;
                }
                
                if (txtResult.Text.Length > 0)
                {
                    txtResult.Text += Environment.NewLine + Environment.NewLine;
                }

                txtResult.Text += "最後一行為：" + Environment.NewLine;
                txtResult.Text += $"{i,2:D}. {lastLine}";
            }
        }
    }
}
