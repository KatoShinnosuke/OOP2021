
namespace Exercise3 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(99, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.4";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(104, 146);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(535, 28);
            this.inputStrText.TabIndex = 1;
            this.inputStrText.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(228, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(228, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(411, 28);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(104, 211);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(94, 24);
            this.a.TabIndex = 2;
            this.a.Text = "空白をカウント";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "big → samll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "4文字以下の単語";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(228, 270);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(411, 28);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 423);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "列挙";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(228, 418);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(411, 28);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox5.Location = new System.Drawing.Point(389, 480);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(411, 28);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox6.Location = new System.Drawing.Point(279, 514);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(628, 115);
            this.textBox6.TabIndex = 1;
            this.textBox6.TextChanged += new System.EventHandler(this.inputStrText_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 24);
            this.button4.TabIndex = 2;
            this.button4.Text = "問題5.4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 641);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
    }
}

