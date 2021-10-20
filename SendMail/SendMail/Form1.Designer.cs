
namespace SendMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "件名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bcc：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "本文：";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(160, 49);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(398, 19);
            this.tbTo.TabIndex = 1;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(160, 218);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(398, 19);
            this.tbTitle.TabIndex = 1;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(160, 281);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(398, 238);
            this.tbMessage.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(483, 541);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "送信";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbCc
            // 
            this.tbCc.Location = new System.Drawing.Point(160, 111);
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(398, 19);
            this.tbCc.TabIndex = 1;
            // 
            // tbBcc
            // 
            this.tbBcc.Location = new System.Drawing.Point(160, 161);
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(398, 19);
            this.tbBcc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cc：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "To：";
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(160, 541);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(73, 23);
            this.btConfig.TabIndex = 3;
            this.btConfig.Text = "設定";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 617);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbBcc);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbCc;
        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConfig;
    }
}

