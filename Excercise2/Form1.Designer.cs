
namespace Excercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.sfdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(207, 56);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(90, 52);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "開く";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(207, 148);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(90, 52);
            this.bt2.TabIndex = 0;
            this.bt2.Text = "変換先";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "開く";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "変換先";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(207, 244);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(90, 52);
            this.bt3.TabIndex = 0;
            this.bt3.Text = "sa";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // sfdOpenFile
            // 
            this.sfdOpenFile.FileName = "sfdOpenFile";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileName = "sfdSaveFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.OpenFileDialog sfdOpenFile;
        private System.Windows.Forms.OpenFileDialog sfdSaveFile;
    }
}

