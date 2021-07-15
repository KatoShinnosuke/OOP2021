using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carReportSystem {
    [Serializable]
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null; 
        }

        private void btDateAdd_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture  = pbPicture.Image
            };
            listCarReport.Add(carReport);
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked){
                   return (CarReport.MakerGroup)
                   int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
            
        }
        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);

            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);

            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) 
                return;
            
            //選択された行を取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //習得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }
            private void setMakerRadioButton(CarReport.MakerGroup mg) {
                switch (mg) {
                    case CarReport.MakerGroup.トヨタ:
                        rbToyota.Checked = true;
                        break;
                    case CarReport.MakerGroup.日産:
                        break;
                    case CarReport.MakerGroup.ホンダ:
                        break;
                    case CarReport.MakerGroup.スバル:
                        break;
                    case CarReport.MakerGroup.外国車:
                        break;
                    case CarReport.MakerGroup.その他:
                        break;
                    default:
                        break;
                
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,
                cbAuthor.Text,selectedGroup(),
                cbCarName.Text,tbReport.Text,pbPicture.Image);
            dgvRegistData.Refresh();//コントロールの強制再描画
        }

        private void fmMain_Load(object sender, EventArgs e) {

        }
        //保存
        private void btSeve_Click(object sender, EventArgs e) {
            if (sfdFileSeve.ShowDialog() == DialogResult.OK)  {
                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = File.Open(sfdFileSeve.FileName,FileMode.Create)) {
                    bf.Serialize(fs, listCarReport);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                //バイナリ形式で逆シリアル化
                var bf = new BinaryFormatter();
                using (FileStream fs = File.Open(ofdFileOpen.FileName,FileMode.Open,FileAccess.Read)) {
                    //逆シリアル化
                    listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                    dgvRegistData.DataSource = null;
                    dgvRegistData.DataSource = listCarReport;
                }
            }
        }
    }
}
