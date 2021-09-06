
namespace RssRaader
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.RssReader = new System.Windows.Forms.Label();
            this.btRead = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.ListBox();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(207, 43);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(405, 19);
            this.tbUrl.TabIndex = 0;
            // 
            // RssReader
            // 
            this.RssReader.AutoSize = true;
            this.RssReader.Location = new System.Drawing.Point(54, 50);
            this.RssReader.Name = "RssReader";
            this.RssReader.Size = new System.Drawing.Size(61, 12);
            this.RssReader.TabIndex = 2;
            this.RssReader.Text = "RssReader";
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(710, 43);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(62, 28);
            this.btRead.TabIndex = 3;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.FormattingEnabled = true;
            this.lbTitle.ItemHeight = 12;
            this.lbTitle.Location = new System.Drawing.Point(46, 101);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(161, 292);
            this.lbTitle.TabIndex = 5;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Location = new System.Drawing.Point(350, 104);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(371, 288);
            this.WebBrowser.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.RssReader);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label RssReader;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.ListBox lbTitle;
        private System.Windows.Forms.WebBrowser WebBrowser;
    }
}

