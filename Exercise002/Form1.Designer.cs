
namespace Exercise002 {
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
            System.Windows.Forms.TextBox inStrNum;
            System.Windows.Forms.TextBox outStrNum;
            this.button5_2 = new System.Windows.Forms.Button();
            inStrNum = new System.Windows.Forms.TextBox();
            outStrNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inStrNum
            // 
            inStrNum.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            inStrNum.Location = new System.Drawing.Point(54, 75);
            inStrNum.Name = "inStrNum";
            inStrNum.Size = new System.Drawing.Size(100, 31);
            inStrNum.TabIndex = 0;
            inStrNum.TextChanged += new System.EventHandler(this.inStrNum_TextChanged);
            // 
            // button5_2
            // 
            this.button5_2.Location = new System.Drawing.Point(241, 75);
            this.button5_2.Name = "button5_2";
            this.button5_2.Size = new System.Drawing.Size(75, 23);
            this.button5_2.TabIndex = 1;
            this.button5_2.Text = "問題5.2実行";
            this.button5_2.UseVisualStyleBackColor = true;
            this.button5_2.Click += new System.EventHandler(this.button5_2_Click);
            // 
            // outStrNum
            // 
            outStrNum.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            outStrNum.Location = new System.Drawing.Point(54, 150);
            outStrNum.Name = "outStrNum";
            outStrNum.Size = new System.Drawing.Size(100, 31);
            outStrNum.TabIndex = 0;
            outStrNum.TextChanged += new System.EventHandler(this.outStrNum_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5_2);
            this.Controls.Add(outStrNum);
            this.Controls.Add(inStrNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5_2;
    }
}

