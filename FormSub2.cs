using System;
using System.Windows.Forms;

namespace Gijirokkun3
{
    public partial class FormSub2 : Form
    {
        /// <summary>
        /// メニューのABOUTで表示されるフォーム
        /// 使用したライブラリ名とライセンスを表示
        /// </summary>
        public FormSub2()
        {
            InitializeComponent();
        }

        private void FormSub2_Load(object sender, EventArgs e)
        {
            // Versionの表示
            labelVersion.Text = FormMain.VER;
        }

        private void labelLicenseMIT_Click(object sender, EventArgs e)
        {
            // NAudioのライセンスを表示させる
            FormLicenseMIT fmMIT = new FormLicenseMIT();
            fmMIT.Show();
        }

        private void labelLicenseLGPL_Click(object sender, EventArgs e)
        {
            // SoundTouch.NET
            FormLicenseLGPL fmLGPL = new FormLicenseLGPL();
            fmLGPL.Show();
        }
    }
}
