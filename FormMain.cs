using System;
using System.Windows.Forms;
using NAudio.Wave;
using Gijirokkun3.SoundTouch;
using System.IO;
using System.Data;
using System.Text;

namespace Gijirokkun3
{
    public partial class FormMain : Form
    {
        public const string VER = "Ver3.0.0";      // ぎじろっ君のバージョン
        private IWavePlayer wavePlayer;
        private VariSpSampleProvider speedControl;
        private AudioFileReader reader;
        private float AudioLength = 0.0f;
        private DataTable dt = new DataTable();
        private bool flg_TagChanged;
        private string fileName;

        public FormMain()
        {
            InitializeComponent();  // コンポーネントの初期化
            this.Text = "ぎじろっ君 " + VER; // フォームにバージョンを表示
            // タイマーの設定
            timer1.Interval = Properties.Settings.Default.INTERVAL; // インターバル時間の設定msec
            timer1.Start(); // タイマーのスタート
            // 再生/一時停止ボタンの表示
            buttonPlayPause.Text = "再生";
            // 速度ラジオボタンのイベントで同じメソッドをハンドル
            radioButtonSpeed100.CheckedChanged += rbtSpeed_CheckedChanged;
            radioButtonSpeed150.CheckedChanged += rbtSpeed_CheckedChanged;
            radioButtonSpeed200.CheckedChanged += rbtSpeed_CheckedChanged;

            enableControls(false);  // スキップボタン他を無効にする
            enableMenuItems(FileModes.FileClosed);  // メニュー有効無効（ファイル未選択状態）
            createTagList();       // dgvTagListの設定
            setToolTip();       // ツールチップの設定
            fileName = null;
        }

        /// <summary>
        /// ツールチップの設定
        /// Setting for TooTip.
        /// </summary>
        public void setToolTip()
        {
            toolTip1.SetToolTip(buttonSkipF, "" + Properties.Settings.Default.SKIP_F + "秒スキップ" );
            toolTip1.SetToolTip(buttonSkipFF, "" + Properties.Settings.Default.SKIP_FF + "秒スキップ");
            toolTip1.SetToolTip(buttonSkipB, "-" + Properties.Settings.Default.SKIP_B + "秒スキップ" );
            toolTip1.SetToolTip(buttonSkipBB, "-" + Properties.Settings.Default.SKIP_BB + "秒スキップ");
            toolTip1.SetToolTip(buttonStop, "スタートに戻る");
            toolTip1.SetToolTip(dgvTagList, "左端ヘッダーのダブルクリックで移動" + "\n" + "右クリックで削除");
            toolTip1.SetToolTip(buttonMakeTag, "クリックの" + Properties.Settings.Default.PRE_TAG + "秒手前にTagを生成");
        }

        /// <summary>
        /// データグリッドビューの設定をする
        /// Setting for DataGridView.
        /// </summary>
        private void createTagList()
        {
            // データテーブルdtの設定
            dt.Columns.Add("Position");     // 位置msec double
            dt.Columns.Add("hhmmss");       // 位置hh:mm;ss  string
            dt.Columns.Add("Memo");         // コメント string
            // dgvTagListの設定
            dgvTagList.DataSource = dt;     // データソースのバインド
            // 項目名のエイリアス
            dgvTagList.Columns["Position"].HeaderText = "Position";
            dgvTagList.Columns["hhmmss"].HeaderText = "タイム";
            dgvTagList.Columns["Memo"].HeaderText = "メモ";
            // 列の幅
            dgvTagList.Columns["Position"].Width = 70;
            dgvTagList.Columns["hhmmss"].Width = 70;
            dgvTagList.Columns["Memo"].Width = 380;
            // 表示の右寄せ左寄せ
            dgvTagList.Columns["Position"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTagList.Columns["hhmmss"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTagList.Columns["Memo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // ReadOnlyの設定
            dgvTagList.Columns["Position"].ReadOnly = true;
            dgvTagList.Columns["hhmmss"].ReadOnly = true;
            dgvTagList.Columns["Memo"].ReadOnly = false;
            // 手操作での行追加の禁止
            dgvTagList.AllowUserToAddRows = false;
            // 手操作での行列幅変更の禁止
            dgvTagList.AllowUserToResizeRows = false;
            dgvTagList.AllowUserToResizeColumns = false;
            // 列ソートの禁止
            dgvTagList.Columns["Position"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTagList.Columns["hhmmss"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvTagList.Columns["Memo"].SortMode = DataGridViewColumnSortMode.NotSortable;

            flg_TagChanged = false; // TagListが変更されたらtrue
        }

        /// <summary>
        /// スキップボタン他の有効無効
        /// Enable / Disable for skip buttons and other.
        /// </summary>
        /// <param name="mode"></param>
        private void enableControls(bool mode)
        {
            switch (mode)
            {
                case false:     // 無効
                    buttonSkipB.Enabled = false;
                    buttonSkipBB.Enabled = false;
                    buttonSkipF.Enabled = false;
                    buttonSkipFF.Enabled = false;
                    buttonMakeTag.Enabled = false;
                    trackBarPlaybackPosition.Enabled = false;
                    break;
                case true:      // 有効
                    buttonSkipB.Enabled = true;
                    buttonSkipBB.Enabled = true;
                    buttonSkipF.Enabled = true;
                    buttonSkipFF.Enabled = true;
                    buttonMakeTag.Enabled = true;
                    trackBarPlaybackPosition.Enabled = true;
                    break;
            }
        }
        /// <summary>
        /// メニュー項目の有効無効を設定する
        /// Set to enable or disable menu items.
        /// </summary>
        /// <param name="mode">0:File selected, 1;File unselected</param>
        private void enableMenuItems(FileModes mode)
        {
            switch(mode)
            {
                case FileModes.FileClosed:
                    menuItem_FileLoad.Enabled = true;   // ファイルの読込
                    menuItem_ProjectLoad.Enabled = true;    // プロジェクトの読込
                    menuItem_CloseFile.Enabled = false; // ファイルのクローズ
                    menuItem_ProjectSave.Enabled = false;   // プロジェクトの保存
                    break;
                case FileModes.FileSelected:
                    menuItem_FileLoad.Enabled = false;   // ファイルの読込
                    menuItem_ProjectLoad.Enabled = false;    // プロジェクトの読込
                    menuItem_CloseFile.Enabled = true; // ファイルのクローズ
                    menuItem_ProjectSave.Enabled = true;   // プロジェクトの保存
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* タイマーで定期的に起動されるイベント */
            if (reader != null)
            {
                if (wavePlayer != null && speedControl != null)
                {
                    if (trackBarPlaybackPosition.Value == 100)
                    {
                        wavePlayer.Pause();
                        buttonPlayPause.Text = "再生";
                    }
                    switch(wavePlayer.PlaybackState)
                    {
                        case PlaybackState.Playing:
                            trackBarPlaybackPosition.Value = (int)(reader.CurrentTime.TotalSeconds / (double)AudioLength * 100.0f);
                            displayPositions(); // 再生位置表示
                            menuItem_CloseFile.Enabled = false;
                            break;
                        case PlaybackState.Stopped:
                            menuItem_CloseFile.Enabled = true;
                            break;
                        case PlaybackState.Paused:
                            menuItem_CloseFile.Enabled=  false;
                            break;
                    }
                }
            }
        }

        private void menuItem_FileLoad_Click(object sender, EventArgs e)
        {
            /* メニュー「設定」→「音声ファイルの読込」クリック */
            loadFile();     // ファイル読込メソッドを起動
        }

        private void menuItem_Close_Click(object sender, EventArgs e)
        {
            /* メニュー「設定」　→　「アプリの終了」　をクリック */
            this.Close();
        }

        /// <summary>
        /// 音声ファイルを読み込むメソッド
        /// Load wav/mp3 file.
        /// </summary>
        private void loadFile()
        {
            if (fileName == null)   // ファイル名が未設定の場合はslectFile()を起動
                fileName = selectFile("音声ファイル(*.wav;*.mp3)|*.wav;*.mp3");  
            if (fileName == null) return;   // キャンセル時は中断
            // 再生中か否かをチェックする
            reader?.Dispose();      // readerがインスタンス化されていたらDispose()
            reader = null;         
            speedControl?.Dispose();    // speedControlがインスタンス化されていたらDispose()
            speedControl = null;   

            // AudioFileReader()にfileNameを渡してreaderをインスタンス化
            reader = new AudioFileReader(fileName);

            // 全長と現在位置のラベルを表示
            displayPositions();
            AudioLength = reader.TotalTime.Seconds + reader.TotalTime.Minutes * 60
                                        + reader.TotalTime.Hours * 3600;        // 全長(sec)
            AudioLength += (float)(reader.TotalTime.Milliseconds) / 1000;

            TimeSpan ts = new TimeSpan(0, 0, (int)AudioLength);
            labelAudioLength.Text = ts.ToString();

            // トラックバーの設定と表示
            trackBarPlaybackPosition.Value = 0;   // バーの位置を0にセット

            // トーン調整の有効無効
            bool useTempo = chkBoxTempo.Checked;   // 有効true,無効false

            // speedControlをVarispeedSampleProviderでインスタンス化
            // 引数１：ソース、引数２：読込持続時間msec、引数３；サウンドテックプロファイル(引数1:トーン調整,２：UseAntiAliasing)
            speedControl = new VariSpSampleProvider(reader, 100, new SoundTouchProfile(useTempo, false));

            enableControls(true);   // スキップボタン他を有効にする
            enableMenuItems(FileModes.FileSelected);    // メニュー有効無効（ファイル選択状態）
        }
        /// <summary>
        /// 音声ファイルを選択するメソッド
        /// Select wav/mp3 file.
        /// </summary>
        /// <param name="strFilter"></param>
        /// <returns>File name including path</returns>
        private string selectFile(string strFilter)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter =strFilter;
            if (ofd.ShowDialog()==DialogResult.OK ) 
                return ofd.FileName;
            else
                return null;
        }

        /// <summary>
        /// ファイルの全長と現在の位置を表示するメソッド
        /// Display the total length and current position of the file.
        /// </summary>
        private void displayPositions()
        {
            labelCurrentPosi.Text = reader.CurrentTime.ToString("hh\\:mm\\:ss");   // 現在位置
            labelFileName.Text = Path.GetFileName(reader.FileName);       // ファイル名
        }

        /// <summary>
        /// tag情報が編集されたかをチェックする
        /// Check if the tag information has been changed.
        /// </summary>
        /// <returns></returns>
        private bool checkTagChenged()
        {
            if (flg_TagChanged)
            {
                switch (MessageBox.Show("Tagが変更されてます。プロジェクトを保存じますか？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    case (DialogResult.Yes):
                        saveProject();
                        flg_TagChanged = false;
                        return false;
                    case (DialogResult.No):
                        flg_TagChanged = false;
                        return true;
                    default:
                        return true;
                }
            }
            else return true;
        }

        private void OnfmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tagが編集されて未保存の場合のチェック
            checkTagChenged();
            // 以下のインスタンスが存在したらDisposeする
            wavePlayer?.Dispose();
            speedControl?.Dispose();
            reader?.Dispose();
            timer1.Stop();
        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            /* ボタン「再生／一時停止」のクリック */
            // wavePlayerの状態を確認してセット
            initWavePlayer();

            // Play中かPause中かの確認して処理を分ける
            switch (wavePlayer.PlaybackState)
            {
                case PlaybackState.Stopped: // 停止状態の場合はプレイ
                    wavePlayer.Play();
                    buttonPlayPause.Text = "一時停止";
                    break;
                case PlaybackState.Paused:  // ポーズ状態の場合はプレイ
                    wavePlayer.Play();
                    buttonPlayPause.Text = "一時停止";
                    break;
                case PlaybackState.Playing: // 再生中の場合はポーズ
                    wavePlayer.Stop();
                    initWavePlayer();
                    buttonPlayPause.Text = "再生";
                    break;
            }
        }

        /// <summary>
        /// wavePlayerの状態を確認してセットする
        /// Initialize wavePlayer.
        /// </summary>
        private void initWavePlayer()
        {
            // 状態確認と処理
            if (wavePlayer == null) // wavePlayerがインスタンス化されていない時の処理
            {
                wavePlayer = new WaveOutEvent();
                // .PlaybackStoppedのｲﾍﾞﾝﾄにWavePlayerOnPlaybackStoppedをバインド
                wavePlayer.PlaybackStopped += wavePlayerOnPlaybackStopped;
            }
            if (speedControl == null)
            {
                loadFile(); // 音声ﾌｧｲﾙを読み込んでspeedControlをｲﾝｽﾀﾝｽ化する
                if (speedControl == null) return;
            }
            // 再生速度
            setPlayBackRate();
            // wavePlayer再生準備
            if (wavePlayer.PlaybackState == PlaybackState.Stopped)
                wavePlayer.Init(speedControl);

        }

        /// <summary>
        /// ラジオボタンの値を読んで再生速度を設定する
        /// Set the playback speed according to the state of rediobuttons.
        /// </summary>
        private void setPlayBackRate()
        {
            // speedControlがインスタンス化されてなかったら中断
            if (speedControl == null) return;
            // ラジオボタンの状態に応じてレートを決める
            if (radioButtonSpeed150.Checked)
                speedControl.PlaybackRate = 1.5f;
            else if (radioButtonSpeed200.Checked)
                speedControl.PlaybackRate = 2.0f;
            else
                speedControl.PlaybackRate = 1.0f;
        }

        private void wavePlayerOnPlaybackStopped(object sender,StoppedEventArgs stoppedEventArgs)
        {
            if (stoppedEventArgs.Exception != null)
            {
                MessageBox.Show(stoppedEventArgs.Exception.Message,"異常停止");
            }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            /* ボタン「停止」クリック */
            if (wavePlayer == null) return; // インスタンス化されていなければ抜ける
            wavePlayer.Stop();
            reader.CurrentTime = TimeSpan.FromSeconds(0.0); // 再生位置を最初に戻す
            buttonPlayPause.Text = "再生";
        }

        private void rbtSpeed_CheckedChanged(object sender, EventArgs e)
        {
            /* ﾗｼﾞｵﾎﾞﾀﾝ「x1.0」変更時のイベント */
            setPlayBackRate();
        }

        /// <summary>
        /// 現在位置から指定時間分を相対移動
        /// Seek from the current position.
        /// </summary>
        /// <param name="span">specifies seconds</param>
        private void skipSeek(int span)
        {
            // wavePlayerの状態を確認してセット
            initWavePlayer();

            // 現在位置の取得(秒)
            float currentPosition = (float)reader.CurrentTime.TotalMilliseconds / 1000.0f;

            // 目標位置の計算(秒）と移動
            float distPosition = currentPosition + (float)span;
            if (distPosition < 0) distPosition = 0f;
            reader.CurrentTime = TimeSpan.FromSeconds(distPosition);
            // 停止または一時停止中であれば再生開始
            if (wavePlayer.PlaybackState != PlaybackState.Playing)
                wavePlayer.Play();
            buttonPlayPause.Text = "一時停止";
        }

        private void buttonSkipF_Click(object sender, EventArgs e)
        {
            /* ボタン「▶」クリック */
            skipSeek(Properties.Settings.Default.SKIP_F);
        }

        private void buttonSkipFF_Click(object sender, EventArgs e)
        {
            /* ボタン「▶▶」クリック */
            skipSeek(Properties.Settings.Default.SKIP_FF);
        }

        private void buttonSkipB_Click(object sender, EventArgs e)
        {
            /* ボタン「◀」クリック */
            skipSeek(- Properties.Settings.Default.SKIP_B);
        }

        private void buttonSkipBB_Click(object sender, EventArgs e)
        {
            /* ボタン「◀◀」クリック */
            skipSeek(-Properties.Settings.Default.SKIP_BB);
        }

        private void menuItem_Settings_Click(object sender, EventArgs e)
        {
            /* メニュー「設定」クリック */
            FormSub1 fm1 = new FormSub1();
            fm1.ShowDialog();
            setToolTip();   // ツールチップの更新
        }

        private void trackBarPlaybackPosition_Scroll(object sender, EventArgs e)
        {
            /* トラックバーを動かした時のイベント */
            // 目標位置の計算(秒）と移動
            float distPosition = (int)((float)AudioLength * 
                (float)trackBarPlaybackPosition.Value/(float)trackBarPlaybackPosition.Maximum);
            reader.CurrentTime = TimeSpan.FromSeconds(distPosition);
            wavePlayer.Play();
            buttonPlayPause.Text = "一時停止";
        }

        private void menuItem_CloseFile_Click(object sender, EventArgs e)
        {
            /* メニュー「設定」→「音声ファイルを閉じる」 */
            checkTagChenged();    // Tagが編集されているかチェック
            //if (wavePlayer != null) return;
            closeFile();
        }

        /// <summary>
        /// 音声ファイルを閉じる
        /// Close wav/mp3 file.
        /// </summary>
        private void closeFile()
        {
            // 各インスタンスの解放
            if (wavePlayer != null) {
                wavePlayer.Dispose();
                wavePlayer = null;
            }
            if (speedControl != null)
            {
                speedControl.Dispose();
                speedControl = null;
            }
            if (reader != null)
            {
                reader.Dispose();
                reader = null;
            }
            // 表示のクリア
            labelAudioLength.Text = "---";
            labelCurrentPosi.Text = "---";
            labelFileName.Text = "---";
            trackBarPlaybackPosition.Value = 0;
            dt.Clear();
            // コントロールのロック
            enableControls(false);
            enableMenuItems(FileModes.FileClosed);  // メニュー（ファイル未選択状態へ）

            // ファイル名のクリア
            fileName = null;

        }

        private void chkBoxTempo_CheckedChanged(object sender, EventArgs e)
        {
            /* チェックボックスのチェック変更のイベント */
            bool useTempo = chkBoxTempo.Checked;
            speedControl.SetSoundTouchProfile(new SoundTouchProfile(useTempo, false));
        }

        private void buttonMakeTag_Click(object sender, EventArgs e)
        {
            /* ボタン「Tag記録」クリック */
            // 現在位置を取得する
            // dt.Columns["Position"]:msec単位の位置, ["hhmmss"]:string 時分秒, ["Memo"];string コメント
            DataRow dtRow = dt.NewRow();
            double currentPosition = reader.CurrentTime.TotalMilliseconds;
            dtRow["Position"] = Convert.ToInt32( currentPosition - Properties.Settings.Default.PRE_TAG);
            TimeSpan ts = new TimeSpan(0, 0, (int)currentPosition / 1000);
            dtRow["hhmmss"] = ts;
            dtRow["Memo"] = "";     // 入力はdataGridViewでやる
            dt.Rows.Add(dtRow);     // dtにレコードを追加

            // dtをソートする
            DataTableUil.Sort(ref dt, "hhmmss", "asc");
            dgvTagList.DataSource = dt; // 再描画
            flg_TagChanged = true;
        }

        private void dgvTagList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /* dgvTagListのメモが変更されたらdtに書き込む */
            if (e.RowIndex < 0) return; 
            dt.Rows[e.RowIndex]["Memo"] = dgvTagList.CurrentRow.Cells["Memo"].Value.ToString();
            dt.AcceptChanges();
            flg_TagChanged = true;
        }

        private void dgvTagList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* dgvTagListの行ヘッダーのｗクリックでseek再生 */
            if (e.RowIndex < 0) return;     // バカよけ
            // wavePlayerの状態を確認してセットする
            initWavePlayer();
            // 位置の指定
            float dst_Position =  (float)(Convert.ToInt32(dt.Rows[e.RowIndex]["Position"])) / 1000.0f;
            reader.CurrentTime = TimeSpan.FromSeconds( dst_Position);
            wavePlayer.Play();
        }

        private void menuItem_ProjectSave_Click(object sender, EventArgs e)
        {
            /* メニュー「設定」→「プロジェクトの保存」 */
            saveProject();
        }

        /// <summary>
        /// プロジェクトファイルを書き込む
        /// Save project file.
        /// </summary>
        private void saveProject()
        {
            if (reader == null) return;     // ファイル未読込はリターン
            // fileNameと同じところに拡張子を変えて同名のプロジェクトファイルを作る
            string path = Path.GetDirectoryName(fileName);  // パスだけを抜き取る
            string audName = Path.GetFileName(fileName);    // 音声ファイル名
            string prjFileName = path + @"\" + Path.GetFileNameWithoutExtension(fileName) + ".prjh";  //ファイルのフルパス
            string str_lineBuffer;
            try
            {
                using (StreamWriter writer1 = new StreamWriter(prjFileName, false, Encoding.GetEncoding("Shift_JIS")))
                {
                    // 引数①:フルパス ②:上書きfalse ③：エンコード指定
                    writer1.WriteLine(audName);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        str_lineBuffer = "";
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            str_lineBuffer += dt.Rows[i][j] + "\t";
                        }
                        writer1.WriteLine(str_lineBuffer);
                    }
                }

            }
            catch (Exception ex)
            {
                string err_str = "ファイル書き込み異常" + "\n" + ex.Message;
                MessageBox.Show(err_str);
                return;
            }
            flg_TagChanged = false;
            MessageBox.Show("プロジェクトを保存しました。");
        }

        private void menuItem_ProjectLoad_Click(object sender, EventArgs e)
        {
            /* メニュー「設定」→「プロジェクトファイルの読込」 */
            timer1.Stop();
            loadProject();
            timer1.Start();
        }

        /// <summary>
        /// プロジェクトファイルを読み込む
        /// Load project file.
        /// </summary>
        private void loadProject()
        {
            // ファイルの読込状態の解除
            closeFile();

            // プロジェクトファイルを読み込む
            string prjName; //　プロジェクトのフルパス
            string str_lineBuffer = "";
            string _path = "";

            // fileダイアログでプロジェクトを選択
            prjName = selectFile("プロジェクトファイル(*.prjh)|*.prjh");        // ファイル選択メソッドを起動
            if (prjName == null) return;   // キャンセル時は中断して戻る
            _path = Path.GetDirectoryName(prjName); // 保存フォルダのパス

            // プロジェクトの内容を各変数に取り込む
            try
            {
                using (StreamReader reader1 = new StreamReader(prjName, Encoding.GetEncoding("Shift_JIS")))
                {
                    // 音声ファイル名の読込(１行目）
                    str_lineBuffer = reader1.ReadLine();
                    fileName = _path + @"\" + str_lineBuffer;
                    // Tag情報の読込（２行目以降）
                    dt.Clear();
                    while (str_lineBuffer != null)
                    {
                        str_lineBuffer = reader1.ReadLine();
                        DataRow dtRow = dt.NewRow();
                        if (str_lineBuffer != null)
                        {
                            string[] tmpArray = str_lineBuffer.Split('\t'); // Tabで分割して配列に保存
                            dtRow["Position"] = Convert.ToInt32(tmpArray[0]);
                            dtRow["hhmmss"] = tmpArray[1];
                            dtRow["Memo"] = tmpArray[2];
                            dt.Rows.Add(dtRow);
                        }
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("読込異常" + "\n" + ex.Message);
                return;
            }
            loadFile(); // 音声ファイルの読込メソッド
        }


           private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* メニュー「ヘルプ」→「使い方(pdf)」クリック */
            // アプリの存在するpathを取得
            string appDir = Application.StartupPath;
            // pdfファイルの名前 
            string MANUAL_NAME = @"\gijirokkun_manual.pdf";
            // pdfファイルのフルパス
            string path_Manual = appDir + MANUAL_NAME;
            // pdfを表示させる
            System.Diagnostics.Process.Start(path_Manual);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            /* メニュー「ヘルプ」→「About」クリック */
            // FormSub2を表示させる
            FormSub2 fms2 = new FormSub2();
            fms2.Show();

        }
    }
}
