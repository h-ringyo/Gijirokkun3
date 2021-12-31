using System;
using System.Windows.Forms;

namespace Gijirokkun3
{
    /// <summary>
    /// 各種パラメータの設定用フォーム
    /// Form for setting parameters.
    /// </summary>
    public partial class FormSub1 : Form
    {
        public FormSub1()
        {
            InitializeComponent();

            // テキストボックスのエラー処理
            txtSkip_B.Validating += validateTextBoxContentIsNumeric;
            txtSkip_BB.Validating += validateTextBoxContentIsNumeric;
            txtSkip_F.Validating += validateTextBoxContentIsNumeric;
            txtSkip_FF.Validating += validateTextBoxContentIsNumeric;
            txtPreTag.Validating += validateTextBoxContentIsNumeric;
            txtInterval.Validating += validateTextBoxContentIsNumeric;
        }

        /// <summary>
        /// テキストボックスに数字以外を受け付けない
        /// Only numbers are accepted in textbox.
        /// </summary>
        /// <param name="textboxName"></param>
        /// <param name="e"></param>
        private void validateTextBoxContentIsNumeric(object sender  ,EventArgs e)
        {
            string str = ((TextBox)sender).Text;
            int i = 0;
            if (int.TryParse(str,out i)==false)
            {
                // 呼び出したオブジェクト名によって変える
                switch (((TextBox)sender).Name)
                {
                    case "txtSkip_B":
                        this.txtSkip_B.Text = Properties.Settings.Default.SKIP_B.ToString();
                        this.txtSkip_B.Focus();
                        break;
                    case "txtSkip_BB":
                        this.txtSkip_BB.Text = Properties.Settings.Default.SKIP_BB.ToString();
                        this.txtSkip_BB.Focus();
                        break;
                    case "txtSkip_F":
                        this.txtSkip_F.Text = Properties.Settings.Default.SKIP_F.ToString();
                        this.txtSkip_F.Focus();
                        break;
                    case "txtSkip_FF":
                        this.txtSkip_FF.Text = Properties.Settings.Default.SKIP_FF.ToString();
                        this.txtSkip_FF.Focus();
                        break;
                    case "txtPreTag":
                        this.txtPreTag.Text = Properties.Settings.Default.PRE_TAG.ToString();
                        this.txtPreTag.Focus();
                        break;
                    case "txtInterval":
                        this.txtInterval.Text = Properties.Settings.Default.INTERVAL.ToString();
                        this.txtInterval.Focus();
                        break;
                }
                errorProvider1.SetError((TextBox)sender, "半角数字限定です");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
         private void fmSub1_Load(object sender, EventArgs e)
        {
            /* フォームロードイベント */
            // テキストボックスの初期値
            txtSkip_B.Text = Properties.Settings.Default.SKIP_B.ToString(); // スキップ◀
            txtSkip_BB.Text = Properties.Settings.Default.SKIP_BB.ToString(); // スキップ◀◀
            txtSkip_F.Text = Properties.Settings.Default.SKIP_F.ToString(); // スキップ▶
            txtSkip_FF.Text = Properties.Settings.Default.SKIP_FF.ToString(); // スキップ▶▶
            txtInterval.Text = Properties.Settings.Default.INTERVAL.ToString(); // 現在位置表示周期msec
            txtPreTag.Text = Properties.Settings.Default.PRE_TAG.ToString(); // プレトリガ時間 sec

            // フォームの最大化を禁止
            this.MaximizeBox = false;

            // ツールチップの設定
            toolTip1.SetToolTip(grpPreTag, "Tag記録ボタン・クリックの設定秒前にTagが記録されます。");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* ボタン「Cancel」クリック */
            this.Close();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            /* ボタン「初期値」クリック */
            txtSkip_B.Text = "10";  //秒
            txtSkip_BB.Text = "30"; 
            txtSkip_F.Text = "10";
            txtSkip_FF.Text = "30";
            txtPreTag.Text = "0";
            txtInterval.Text = "100";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /* ボタン「OK」クリック */
            // プロパティにテキストボックスの値を入れる
            Properties.Settings.Default.SKIP_B = Convert.ToInt32(txtSkip_B.Text);
            Properties.Settings.Default.SKIP_BB = Convert.ToInt32(txtSkip_BB.Text);
            Properties.Settings.Default.SKIP_F = Convert.ToInt32(txtSkip_F.Text);
            Properties.Settings.Default.SKIP_FF = Convert.ToInt32(txtSkip_FF.Text);
            Properties.Settings.Default.PRE_TAG = Convert.ToInt32(txtPreTag.Text);
            Properties.Settings.Default.INTERVAL = Convert.ToInt32(txtInterval.Text);
            Properties.Settings.Default.Save();     // 保存

            this.Close();       // 閉じる
        }
    }
}
