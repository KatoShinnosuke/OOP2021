
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.tbStart = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(52, 141);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(122, 108);
            this.tbStart.TabIndex = 0;
            this.tbStart.Text = "スタート";
            this.tbStart.UseVisualStyleBackColor = true;
            this.tbStart.Click += new System.EventHandler(this.lbTimerDisp_Click);
            // 
            // btstop
            // 
            this.btstop.Location = new System.Drawing.Point(180, 141);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(122, 108);
            this.btstop.TabIndex = 0;
            this.btstop.Text = "ストップ";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 19);
            this.textBox1.TabIndex = 1;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(52, 255);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(122, 108);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 108);
            this.button2.TabIndex = 0;
            this.button2.Text = "ラップ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 94);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 269);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btstop);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tbStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbStart;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer tmDisp;
    }
}

