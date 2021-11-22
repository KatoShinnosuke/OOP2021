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
           // dgvRegistData.DataSource = listCarReport;
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
            {
                return;
            }
            
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
                    rbNissan.Checked = true;
                    break;
                    case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                    case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                    case CarReport.MakerGroup.外国車:
                    rbimport.Checked = true;
                    break;
                    case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                    default:
                        break;
                
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
           // listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
           // listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,
             //   cbAuthor.Text,selectedGroup(),
             //   cbCarName.Text,tbReport.Text,pbPicture.Image);
            //dgvRegistData.Refresh();//コントロールの強制再描画
        }

        private void fmMain_Load(object sender, EventArgs e) {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車種";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].HeaderText = "画像";

            ssErrorLaval.Text = "";
        }
        //保存
        private void btSeve_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;
            {
                carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;//日付
                carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;//記録者
                carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();//メーカー
                carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
                carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;

                this.Validate();

                this.carReportBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.infosys202109DataSet);
            }
            

        }

        private void btOpen_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202109DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202109DataSet.CarReport);

        }
       
        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202109DataSet);

        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null)
            {
                return;
            }
            try
            {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerRadioButton(
                    (CarReport.MakerGroup)
                    Enum.Parse(typeof(CarReport.MakerGroup),
                    carReportDataGridView.CurrentRow.Cells[3].Value.ToString()
                    ));
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage
                    ((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
            }
            catch (InvalidCastException)
            {
                pbPicture.Image = null;
            }
            catch (Exception ex)
            {
                ssErrorLaval.Text = ex.Message;
            }
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpDate.Value =  DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            setMakerRadioButton(CarReport.MakerGroup.その他);
            pbPicture.Image = null;
        }
    }
}
