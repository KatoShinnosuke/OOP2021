
namespace StopWatch {
    partial class Stopwatch {
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
            this.lbTimerDisp = new System.Windows.Forms.Button();
            this.Elapsed = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.Location = new System.Drawing.Point(30, 123);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(122, 108);
            this.lbTimerDisp.TabIndex = 0;
            this.lbTimerDisp.Text = "button1";
            this.lbTimerDisp.UseVisualStyleBackColor = true;
            // 
            // Elapsed
            // 
            this.Elapsed.Location = new System.Drawing.Point(217, 123);
            this.Elapsed.Name = "Elapsed";
            this.Elapsed.Size = new System.Drawing.Size(122, 108);
            this.Elapsed.TabIndex = 0;
            this.Elapsed.Text = "button1";
            this.Elapsed.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 19);
            this.textBox1.TabIndex = 1;
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Elapsed);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Stopwatch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbTimerDisp;
        private System.Windows.Forms.Button Elapsed;
        private System.Windows.Forms.TextBox textBox1;
    }
}

