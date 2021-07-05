
namespace Exercise1 {
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.nuYear = new System.Windows.Forms.NumericUpDown();
            this.nuMothe = new System.Windows.Forms.NumericUpDown();
            this.nuDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.dtoDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMothe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(105, 71);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(300, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(436, 101);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(122, 38);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // nuYear
            // 
            this.nuYear.Location = new System.Drawing.Point(105, 170);
            this.nuYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nuYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nuYear.Name = "nuYear";
            this.nuYear.Size = new System.Drawing.Size(120, 31);
            this.nuYear.TabIndex = 2;
            this.nuYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nuMothe
            // 
            this.nuMothe.Location = new System.Drawing.Point(310, 170);
            this.nuMothe.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nuMothe.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuMothe.Name = "nuMothe";
            this.nuMothe.Size = new System.Drawing.Size(62, 31);
            this.nuMothe.TabIndex = 2;
            this.nuMothe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuDay
            // 
            this.nuDay.Location = new System.Drawing.Point(436, 170);
            this.nuDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nuDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDay.Name = "nuDay";
            this.nuDay.Size = new System.Drawing.Size(60, 31);
            this.nuDay.TabIndex = 2;
            this.nuDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Location = new System.Drawing.Point(105, 108);
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.Size = new System.Drawing.Size(300, 31);
            this.tbLeapYear.TabIndex = 0;
            // 
            // dtoDateTime
            // 
            this.dtoDateTime.Location = new System.Drawing.Point(105, 242);
            this.dtoDateTime.Name = "dtoDateTime";
            this.dtoDateTime.Size = new System.Drawing.Size(300, 31);
            this.dtoDateTime.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 900);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuDay);
            this.Controls.Add(this.nuMothe);
            this.Controls.Add(this.nuYear);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.dtoDateTime);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.tbOutput);
            this.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nuYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMothe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.NumericUpDown nuYear;
        private System.Windows.Forms.NumericUpDown nuMothe;
        private System.Windows.Forms.NumericUpDown nuDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.TextBox dtoDateTime;
    }
}

