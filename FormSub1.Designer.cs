
namespace Gijirokkun3
{
    partial class FormSub1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSub1));
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.grpPreTag = new System.Windows.Forms.GroupBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPreTag = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtSkip_FF = new System.Windows.Forms.TextBox();
            this.txtSkip_F = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtSkip_BB = new System.Windows.Forms.TextBox();
            this.txtSkip_B = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox4.SuspendLayout();
            this.grpPreTag.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Controls.Add(this.Label12);
            this.GroupBox4.Controls.Add(this.txtInterval);
            this.GroupBox4.Location = new System.Drawing.Point(11, 147);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(145, 52);
            this.GroupBox4.TabIndex = 11;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "位置取得周期";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 18);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(57, 24);
            this.Label11.TabIndex = 5;
            this.Label11.Text = "範囲:\r\n 100～500";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(106, 31);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(32, 12);
            this.Label12.TabIndex = 5;
            this.Label12.Text = "msec";
            // 
            // txtInterval
            // 
            this.txtInterval.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtInterval.Location = new System.Drawing.Point(72, 24);
            this.txtInterval.MaxLength = 3;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(28, 19);
            this.txtInterval.TabIndex = 6;
            // 
            // grpPreTag
            // 
            this.grpPreTag.Controls.Add(this.Label10);
            this.grpPreTag.Controls.Add(this.Label9);
            this.grpPreTag.Controls.Add(this.txtPreTag);
            this.grpPreTag.Location = new System.Drawing.Point(11, 91);
            this.grpPreTag.Name = "grpPreTag";
            this.grpPreTag.Size = new System.Drawing.Size(145, 52);
            this.grpPreTag.TabIndex = 10;
            this.grpPreTag.TabStop = false;
            this.grpPreTag.Text = "Tagのプレトリガー(0～9)";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label10.Location = new System.Drawing.Point(52, 26);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(22, 15);
            this.Label10.TabIndex = 4;
            this.Label10.Text = "－";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(111, 31);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(23, 12);
            this.Label9.TabIndex = 5;
            this.Label9.Text = "sec";
            // 
            // txtPreTag
            // 
            this.txtPreTag.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPreTag.Location = new System.Drawing.Point(76, 24);
            this.txtPreTag.MaxLength = 1;
            this.txtPreTag.Name = "txtPreTag";
            this.txtPreTag.Size = new System.Drawing.Size(28, 19);
            this.txtPreTag.TabIndex = 4;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.txtSkip_FF);
            this.GroupBox2.Controls.Add(this.txtSkip_F);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(167, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(145, 79);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "スキップ送り時間";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(111, 51);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(23, 12);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "sec";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(111, 24);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(23, 12);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "sec";
            // 
            // txtSkip_FF
            // 
            this.txtSkip_FF.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSkip_FF.Location = new System.Drawing.Point(76, 44);
            this.txtSkip_FF.MaxLength = 3;
            this.txtSkip_FF.Name = "txtSkip_FF";
            this.txtSkip_FF.Size = new System.Drawing.Size(28, 19);
            this.txtSkip_FF.TabIndex = 3;
            // 
            // txtSkip_F
            // 
            this.txtSkip_F.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSkip_F.Location = new System.Drawing.Point(76, 17);
            this.txtSkip_F.MaxLength = 3;
            this.txtSkip_F.Name = "txtSkip_F";
            this.txtSkip_F.Size = new System.Drawing.Size(28, 19);
            this.txtSkip_F.TabIndex = 2;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label7.Location = new System.Drawing.Point(10, 46);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(31, 15);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "▶▶▶";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label8.Location = new System.Drawing.Point(10, 19);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(23, 15);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "▶▶";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtSkip_BB);
            this.GroupBox1.Controls.Add(this.txtSkip_B);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(11, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(145, 79);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "スキップ戻し時間";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(111, 51);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(23, 12);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "sec";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(111, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(23, 12);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "sec";
            // 
            // txtSkip_BB
            // 
            this.txtSkip_BB.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSkip_BB.Location = new System.Drawing.Point(76, 44);
            this.txtSkip_BB.MaxLength = 3;
            this.txtSkip_BB.Name = "txtSkip_BB";
            this.txtSkip_BB.Size = new System.Drawing.Size(28, 19);
            this.txtSkip_BB.TabIndex = 1;
            // 
            // txtSkip_B
            // 
            this.txtSkip_B.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSkip_B.Location = new System.Drawing.Point(76, 17);
            this.txtSkip_B.MaxLength = 3;
            this.txtSkip_B.Name = "txtSkip_B";
            this.txtSkip_B.Size = new System.Drawing.Size(28, 19);
            this.txtSkip_B.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label2.Location = new System.Drawing.Point(10, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "◀◀◀";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(10, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(23, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "◀◀";
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(243, 146);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 14;
            this.btnInit.Text = "初期値へ";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(163, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.grpPreTag);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSub1";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.fmSub1_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.grpPreTag.ResumeLayout(false);
            this.grpPreTag.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtInterval;
        internal System.Windows.Forms.GroupBox grpPreTag;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPreTag;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtSkip_FF;
        internal System.Windows.Forms.TextBox txtSkip_F;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtSkip_BB;
        internal System.Windows.Forms.TextBox txtSkip_B;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnInit;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}