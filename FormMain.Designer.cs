
namespace Gijirokkun3
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_FileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ProjectLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ProjectSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCurrentPosi = new System.Windows.Forms.Label();
            this.labelAudioLength = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpSpeed = new System.Windows.Forms.GroupBox();
            this.chkBoxTempo = new System.Windows.Forms.CheckBox();
            this.radioButtonSpeed200 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeed150 = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeed100 = new System.Windows.Forms.RadioButton();
            this.buttonMakeTag = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSkipF = new System.Windows.Forms.Button();
            this.buttonSkipBB = new System.Windows.Forms.Button();
            this.buttonSkipFF = new System.Windows.Forms.Button();
            this.buttonSkipB = new System.Windows.Forms.Button();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.dgvTagList = new System.Windows.Forms.DataGridView();
            this.grpFlgStasus = new System.Windows.Forms.GroupBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblKeyControl = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblFileOpen = new System.Windows.Forms.Label();
            this.lblFileSelected = new System.Windows.Forms.Label();
            this.trackBarPlaybackPosition = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.grpSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTagList)).BeginInit();
            this.grpFlgStasus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlaybackPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MenuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_FileLoad,
            this.menuItem_ProjectLoad,
            this.menuItem_ProjectSave,
            this.menuItem_Settings,
            this.menuItem_CloseFile,
            this.menuItem_Close});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(53, 20);
            this.menuFile.Text = "ファイル";
            // 
            // menuItem_FileLoad
            // 
            this.menuItem_FileLoad.Name = "menuItem_FileLoad";
            this.menuItem_FileLoad.Size = new System.Drawing.Size(171, 22);
            this.menuItem_FileLoad.Text = "音声ファイル読込";
            this.menuItem_FileLoad.Click += new System.EventHandler(this.menuItem_FileLoad_Click);
            // 
            // menuItem_ProjectLoad
            // 
            this.menuItem_ProjectLoad.Name = "menuItem_ProjectLoad";
            this.menuItem_ProjectLoad.Size = new System.Drawing.Size(171, 22);
            this.menuItem_ProjectLoad.Text = "プロジェクトの読込";
            this.menuItem_ProjectLoad.Click += new System.EventHandler(this.menuItem_ProjectLoad_Click);
            // 
            // menuItem_ProjectSave
            // 
            this.menuItem_ProjectSave.Name = "menuItem_ProjectSave";
            this.menuItem_ProjectSave.Size = new System.Drawing.Size(171, 22);
            this.menuItem_ProjectSave.Text = "プロジェクトの保存";
            this.menuItem_ProjectSave.Click += new System.EventHandler(this.menuItem_ProjectSave_Click);
            // 
            // menuItem_Settings
            // 
            this.menuItem_Settings.Name = "menuItem_Settings";
            this.menuItem_Settings.Size = new System.Drawing.Size(171, 22);
            this.menuItem_Settings.Text = "設定";
            this.menuItem_Settings.Click += new System.EventHandler(this.menuItem_Settings_Click);
            // 
            // menuItem_CloseFile
            // 
            this.menuItem_CloseFile.Name = "menuItem_CloseFile";
            this.menuItem_CloseFile.Size = new System.Drawing.Size(171, 22);
            this.menuItem_CloseFile.Text = "音声ファイルを閉じる";
            this.menuItem_CloseFile.Click += new System.EventHandler(this.menuItem_CloseFile_Click);
            // 
            // menuItem_Close
            // 
            this.menuItem_Close.Name = "menuItem_Close";
            this.menuItem_Close.Size = new System.Drawing.Size(171, 22);
            this.menuItem_Close.Text = "アプリの終了";
            this.menuItem_Close.Click += new System.EventHandler(this.menuItem_Close_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(48, 20);
            this.menuHelp.Text = "ヘルプ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.labelCurrentPosi);
            this.GroupBox1.Controls.Add(this.labelAudioLength);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.labelFileName);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Location = new System.Drawing.Point(12, 27);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(253, 95);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            // 
            // labelCurrentPosi
            // 
            this.labelCurrentPosi.AutoSize = true;
            this.labelCurrentPosi.Font = new System.Drawing.Font("MS UI Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCurrentPosi.Location = new System.Drawing.Point(118, 69);
            this.labelCurrentPosi.Name = "labelCurrentPosi";
            this.labelCurrentPosi.Size = new System.Drawing.Size(35, 16);
            this.labelCurrentPosi.TabIndex = 3;
            this.labelCurrentPosi.Text = "---";
            // 
            // labelAudioLength
            // 
            this.labelAudioLength.AutoSize = true;
            this.labelAudioLength.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAudioLength.Location = new System.Drawing.Point(109, 45);
            this.labelAudioLength.Name = "labelAudioLength";
            this.labelAudioLength.Size = new System.Drawing.Size(28, 13);
            this.labelAudioLength.TabIndex = 2;
            this.labelAudioLength.Text = "---";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label3.Location = new System.Drawing.Point(7, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "現在位置 　：";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label2.Location = new System.Drawing.Point(7, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "音声の全長 　：";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFileName.Location = new System.Drawing.Point(109, 19);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(28, 13);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "---";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(7, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "音声ファイル名：";
            // 
            // grpSpeed
            // 
            this.grpSpeed.Controls.Add(this.chkBoxTempo);
            this.grpSpeed.Controls.Add(this.radioButtonSpeed200);
            this.grpSpeed.Controls.Add(this.radioButtonSpeed150);
            this.grpSpeed.Controls.Add(this.radioButtonSpeed100);
            this.grpSpeed.Location = new System.Drawing.Point(271, 80);
            this.grpSpeed.Name = "grpSpeed";
            this.grpSpeed.Size = new System.Drawing.Size(301, 40);
            this.grpSpeed.TabIndex = 5;
            this.grpSpeed.TabStop = false;
            this.grpSpeed.Text = "再生スピード";
            // 
            // chkBoxTempo
            // 
            this.chkBoxTempo.AutoSize = true;
            this.chkBoxTempo.Checked = true;
            this.chkBoxTempo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxTempo.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkBoxTempo.Location = new System.Drawing.Point(236, 17);
            this.chkBoxTempo.Name = "chkBoxTempo";
            this.chkBoxTempo.Size = new System.Drawing.Size(46, 15);
            this.chkBoxTempo.TabIndex = 1;
            this.chkBoxTempo.Text = "変調";
            this.chkBoxTempo.UseVisualStyleBackColor = true;
            this.chkBoxTempo.CheckedChanged += new System.EventHandler(this.chkBoxTempo_CheckedChanged);
            // 
            // radioButtonSpeed200
            // 
            this.radioButtonSpeed200.AutoSize = true;
            this.radioButtonSpeed200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSpeed200.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButtonSpeed200.Location = new System.Drawing.Point(152, 17);
            this.radioButtonSpeed200.Name = "radioButtonSpeed200";
            this.radioButtonSpeed200.Size = new System.Drawing.Size(48, 15);
            this.radioButtonSpeed200.TabIndex = 0;
            this.radioButtonSpeed200.Text = "×2.0";
            this.radioButtonSpeed200.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpeed150
            // 
            this.radioButtonSpeed150.AutoSize = true;
            this.radioButtonSpeed150.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSpeed150.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButtonSpeed150.Location = new System.Drawing.Point(86, 17);
            this.radioButtonSpeed150.Name = "radioButtonSpeed150";
            this.radioButtonSpeed150.Size = new System.Drawing.Size(48, 15);
            this.radioButtonSpeed150.TabIndex = 0;
            this.radioButtonSpeed150.Text = "×1.5";
            this.radioButtonSpeed150.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpeed100
            // 
            this.radioButtonSpeed100.AutoSize = true;
            this.radioButtonSpeed100.Checked = true;
            this.radioButtonSpeed100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSpeed100.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButtonSpeed100.Location = new System.Drawing.Point(20, 17);
            this.radioButtonSpeed100.Name = "radioButtonSpeed100";
            this.radioButtonSpeed100.Size = new System.Drawing.Size(48, 15);
            this.radioButtonSpeed100.TabIndex = 0;
            this.radioButtonSpeed100.TabStop = true;
            this.radioButtonSpeed100.Text = "×1.0";
            this.radioButtonSpeed100.UseVisualStyleBackColor = true;
            // 
            // buttonMakeTag
            // 
            this.buttonMakeTag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakeTag.Location = new System.Drawing.Point(502, 35);
            this.buttonMakeTag.Name = "buttonMakeTag";
            this.buttonMakeTag.Size = new System.Drawing.Size(70, 36);
            this.buttonMakeTag.TabIndex = 9;
            this.buttonMakeTag.Text = "Tag記録";
            this.buttonMakeTag.UseVisualStyleBackColor = true;
            this.buttonMakeTag.Click += new System.EventHandler(this.buttonMakeTag_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStop.Location = new System.Drawing.Point(338, 130);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 48);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "■";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSkipF
            // 
            this.buttonSkipF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSkipF.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSkipF.Location = new System.Drawing.Point(420, 130);
            this.buttonSkipF.Name = "buttonSkipF";
            this.buttonSkipF.Size = new System.Drawing.Size(70, 48);
            this.buttonSkipF.TabIndex = 11;
            this.buttonSkipF.Text = "▶▶";
            this.buttonSkipF.UseVisualStyleBackColor = true;
            this.buttonSkipF.Click += new System.EventHandler(this.buttonSkipF_Click);
            // 
            // buttonSkipBB
            // 
            this.buttonSkipBB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSkipBB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSkipBB.Location = new System.Drawing.Point(12, 130);
            this.buttonSkipBB.Name = "buttonSkipBB";
            this.buttonSkipBB.Size = new System.Drawing.Size(70, 48);
            this.buttonSkipBB.TabIndex = 12;
            this.buttonSkipBB.Text = "◀◀◀";
            this.buttonSkipBB.UseVisualStyleBackColor = true;
            this.buttonSkipBB.Click += new System.EventHandler(this.buttonSkipBB_Click);
            // 
            // buttonSkipFF
            // 
            this.buttonSkipFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSkipFF.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSkipFF.Location = new System.Drawing.Point(502, 130);
            this.buttonSkipFF.Name = "buttonSkipFF";
            this.buttonSkipFF.Size = new System.Drawing.Size(70, 48);
            this.buttonSkipFF.TabIndex = 13;
            this.buttonSkipFF.Text = "▶▶▶";
            this.buttonSkipFF.UseVisualStyleBackColor = true;
            this.buttonSkipFF.Click += new System.EventHandler(this.buttonSkipFF_Click);
            // 
            // buttonSkipB
            // 
            this.buttonSkipB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSkipB.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSkipB.Location = new System.Drawing.Point(94, 130);
            this.buttonSkipB.Name = "buttonSkipB";
            this.buttonSkipB.Size = new System.Drawing.Size(70, 48);
            this.buttonSkipB.TabIndex = 14;
            this.buttonSkipB.Text = "◀◀";
            this.buttonSkipB.UseVisualStyleBackColor = true;
            this.buttonSkipB.Click += new System.EventHandler(this.buttonSkipB_Click);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayPause.Location = new System.Drawing.Point(176, 130);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(150, 48);
            this.buttonPlayPause.TabIndex = 15;
            this.buttonPlayPause.Text = "再生／一時停止";
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // dgvTagList
            // 
            this.dgvTagList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTagList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTagList.Location = new System.Drawing.Point(12, 184);
            this.dgvTagList.Name = "dgvTagList";
            this.dgvTagList.RowTemplate.Height = 21;
            this.dgvTagList.ShowCellToolTips = false;
            this.dgvTagList.Size = new System.Drawing.Size(560, 145);
            this.dgvTagList.TabIndex = 16;
            this.dgvTagList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTagList_CellValueChanged);
            this.dgvTagList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTagList_RowHeaderMouseDoubleClick);
            // 
            // grpFlgStasus
            // 
            this.grpFlgStasus.Controls.Add(this.lblText);
            this.grpFlgStasus.Controls.Add(this.lblKeyControl);
            this.grpFlgStasus.Controls.Add(this.lblPause);
            this.grpFlgStasus.Controls.Add(this.lblPlay);
            this.grpFlgStasus.Controls.Add(this.lblFileOpen);
            this.grpFlgStasus.Controls.Add(this.lblFileSelected);
            this.grpFlgStasus.Location = new System.Drawing.Point(12, 324);
            this.grpFlgStasus.Name = "grpFlgStasus";
            this.grpFlgStasus.Size = new System.Drawing.Size(560, 26);
            this.grpFlgStasus.TabIndex = 17;
            this.grpFlgStasus.TabStop = false;
            this.grpFlgStasus.Visible = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(442, 12);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 12);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "label4";
            // 
            // lblKeyControl
            // 
            this.lblKeyControl.AutoSize = true;
            this.lblKeyControl.Location = new System.Drawing.Point(313, 13);
            this.lblKeyControl.Name = "lblKeyControl";
            this.lblKeyControl.Size = new System.Drawing.Size(54, 12);
            this.lblKeyControl.TabIndex = 1;
            this.lblKeyControl.Text = "KEY_CON";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new System.Drawing.Point(241, 11);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(53, 12);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "flg_Pause";
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Location = new System.Drawing.Point(175, 11);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(44, 12);
            this.lblPlay.TabIndex = 0;
            this.lblPlay.Text = "flg_Play";
            // 
            // lblFileOpen
            // 
            this.lblFileOpen.AutoSize = true;
            this.lblFileOpen.Location = new System.Drawing.Point(101, 11);
            this.lblFileOpen.Name = "lblFileOpen";
            this.lblFileOpen.Size = new System.Drawing.Size(50, 12);
            this.lblFileOpen.TabIndex = 0;
            this.lblFileOpen.Text = "FileOpen";
            // 
            // lblFileSelected
            // 
            this.lblFileSelected.AutoSize = true;
            this.lblFileSelected.Location = new System.Drawing.Point(10, 11);
            this.lblFileSelected.Name = "lblFileSelected";
            this.lblFileSelected.Size = new System.Drawing.Size(68, 12);
            this.lblFileSelected.TabIndex = 0;
            this.lblFileSelected.Text = "FileSelected";
            // 
            // trackBarPlaybackPosition
            // 
            this.trackBarPlaybackPosition.Location = new System.Drawing.Point(271, 35);
            this.trackBarPlaybackPosition.Maximum = 100;
            this.trackBarPlaybackPosition.Name = "trackBarPlaybackPosition";
            this.trackBarPlaybackPosition.Size = new System.Drawing.Size(219, 45);
            this.trackBarPlaybackPosition.TabIndex = 18;
            this.trackBarPlaybackPosition.TickFrequency = 5;
            this.trackBarPlaybackPosition.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPlaybackPosition.Scroll += new System.EventHandler(this.trackBarPlaybackPosition_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "使い方(PDF)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "ABOUT";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 351);
            this.Controls.Add(this.trackBarPlaybackPosition);
            this.Controls.Add(this.grpFlgStasus);
            this.Controls.Add(this.dgvTagList);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSkipF);
            this.Controls.Add(this.buttonSkipBB);
            this.Controls.Add(this.buttonSkipFF);
            this.Controls.Add(this.buttonSkipB);
            this.Controls.Add(this.buttonPlayPause);
            this.Controls.Add(this.buttonMakeTag);
            this.Controls.Add(this.grpSpeed);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "ぎじろっ君３";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnfmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grpSpeed.ResumeLayout(false);
            this.grpSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTagList)).EndInit();
            this.grpFlgStasus.ResumeLayout(false);
            this.grpFlgStasus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlaybackPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem menuFile;
        internal System.Windows.Forms.ToolStripMenuItem menuItem_FileLoad;
        internal System.Windows.Forms.ToolStripMenuItem menuItem_ProjectLoad;
        internal System.Windows.Forms.ToolStripMenuItem menuItem_ProjectSave;
        internal System.Windows.Forms.ToolStripMenuItem menuItem_Settings;
        internal System.Windows.Forms.ToolStripMenuItem menuItem_CloseFile;
        internal System.Windows.Forms.ToolStripMenuItem menuItem_Close;
        internal System.Windows.Forms.ToolStripMenuItem menuHelp;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label labelCurrentPosi;
        internal System.Windows.Forms.Label labelAudioLength;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label labelFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox grpSpeed;
        internal System.Windows.Forms.RadioButton radioButtonSpeed200;
        internal System.Windows.Forms.RadioButton radioButtonSpeed150;
        internal System.Windows.Forms.RadioButton radioButtonSpeed100;
        internal System.Windows.Forms.Button buttonMakeTag;
        internal System.Windows.Forms.Button buttonStop;
        internal System.Windows.Forms.Button buttonSkipF;
        internal System.Windows.Forms.Button buttonSkipBB;
        internal System.Windows.Forms.Button buttonSkipFF;
        internal System.Windows.Forms.Button buttonSkipB;
        internal System.Windows.Forms.Button buttonPlayPause;
        internal System.Windows.Forms.DataGridView dgvTagList;
        internal System.Windows.Forms.GroupBox grpFlgStasus;
        internal System.Windows.Forms.Label lblKeyControl;
        internal System.Windows.Forms.Label lblPause;
        internal System.Windows.Forms.Label lblPlay;
        internal System.Windows.Forms.Label lblFileOpen;
        internal System.Windows.Forms.Label lblFileSelected;
        private System.Windows.Forms.TrackBar trackBarPlaybackPosition;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkBoxTempo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

