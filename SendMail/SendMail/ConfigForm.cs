using SendMail.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings settings = Settings.getInstance();
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
{
            tbHost.Text = settings.sHost(); //ホスト名
            tbPort.Text = settings.sPort(); //ポート番号
            tbUserName.Text = settings.sMailAdder(); //ユーザー名
            tbPass.Text = settings.sPass(); //パスワード
            cbSsl.Checked = settings.bSsl();    //SSL
            tbSender.Text = settings.sMailAdder();   //送信元
        }
        //OKボタン
        private void btOk_Click(object sender, EventArgs e)
        {
            this.btApply_Click(sender, e);
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e)
        {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        //送信データ登録
        private void SettingRegist()
{
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAdder = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
