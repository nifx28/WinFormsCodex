
namespace WinFormsApp
{
    partial class WinForms
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbFilePicker = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGetLastLine = new System.Windows.Forms.Button();
            this.lbLineCount = new System.Windows.Forms.Label();
            this.lbLineCountValue = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Controls.Add(this.lbFilePicker, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFilePath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRead, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbFilePicker
            // 
            this.lbFilePicker.AutoSize = true;
            this.lbFilePicker.Location = new System.Drawing.Point(16, 13);
            this.lbFilePicker.Name = "lbFilePicker";
            this.lbFilePicker.Size = new System.Drawing.Size(56, 12);
            this.lbFilePicker.TabIndex = 1;
            this.lbFilePicker.Text = "選取檔案:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFilePath.Location = new System.Drawing.Point(26, 31);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(280, 22);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(312, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(64, 26);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "瀏覽";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(26, 97);
            this.txtResult.Margin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(283, 147);
            this.txtResult.TabIndex = 9;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(312, 63);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(64, 26);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "讀取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGetLastLine);
            this.flowLayoutPanel1.Controls.Add(this.lbLineCount);
            this.flowLayoutPanel1.Controls.Add(this.lbLineCountValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 31);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnGetLastLine
            // 
            this.btnGetLastLine.Location = new System.Drawing.Point(3, 3);
            this.btnGetLastLine.Name = "btnGetLastLine";
            this.btnGetLastLine.Size = new System.Drawing.Size(102, 26);
            this.btnGetLastLine.TabIndex = 6;
            this.btnGetLastLine.Text = "抓取最後一行";
            this.btnGetLastLine.UseVisualStyleBackColor = true;
            this.btnGetLastLine.Click += new System.EventHandler(this.btnGetLastLine_Click);
            // 
            // lbLineCount
            // 
            this.lbLineCount.AutoSize = true;
            this.lbLineCount.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLineCount.Location = new System.Drawing.Point(121, 6);
            this.lbLineCount.Margin = new System.Windows.Forms.Padding(13, 6, 0, 0);
            this.lbLineCount.Name = "lbLineCount";
            this.lbLineCount.Size = new System.Drawing.Size(35, 16);
            this.lbLineCount.TabIndex = 7;
            this.lbLineCount.Text = "行數:";
            // 
            // lbLineCountValue
            // 
            this.lbLineCountValue.AutoSize = true;
            this.lbLineCountValue.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbLineCountValue.Location = new System.Drawing.Point(156, 6);
            this.lbLineCountValue.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.lbLineCountValue.Name = "lbLineCountValue";
            this.lbLineCountValue.Size = new System.Drawing.Size(0, 16);
            this.lbLineCountValue.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "文字文件 (*.txt)|*.txt|記錄檔 (*.log)|*.log|JSON 文件 (*.json)|*.json|XML 文件 (*.xml)|*.xml" +
    "|所有檔案 (*.*)|*.*";
            // 
            // WinForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "WinForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "視窗測試";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinForms_FormClosing);
            this.Load += new System.EventHandler(this.WinForms_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbFilePicker;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGetLastLine;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbLineCount;
        private System.Windows.Forms.Label lbLineCountValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

