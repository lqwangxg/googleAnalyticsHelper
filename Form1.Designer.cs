namespace GoogleAnalyticsHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTrackEdit = new System.Windows.Forms.CheckBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHtmlFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrackingH3 = new System.Windows.Forms.TextBox();
            this.txtTrackingH1 = new System.Windows.Forms.TextBox();
            this.txtTrackingH2 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkAnalytics = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkGoogle = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTrackEdit);
            this.groupBox1.Controls.Add(this.btnExec);
            this.groupBox1.Controls.Add(this.txtTemplate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblHtmlFile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTrackingH3);
            this.groupBox1.Controls.Add(this.txtTrackingH1);
            this.groupBox1.Controls.Add(this.txtTrackingH2);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.linkAnalytics);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkGoogle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1403, 780);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Googleアナリティクス導入ステップ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkTrackEdit
            // 
            this.chkTrackEdit.AutoSize = true;
            this.chkTrackEdit.Location = new System.Drawing.Point(399, 340);
            this.chkTrackEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrackEdit.Name = "chkTrackEdit";
            this.chkTrackEdit.Size = new System.Drawing.Size(164, 19);
            this.chkTrackEdit.TabIndex = 7;
            this.chkTrackEdit.Text = "トラッキングIDを全修正";
            this.chkTrackEdit.UseVisualStyleBackColor = true;
            this.chkTrackEdit.CheckedChanged += new System.EventHandler(this.chkTrackEdit_CheckedChanged);
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(56, 722);
            this.btnExec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(384, 31);
            this.btnExec.TabIndex = 10;
            this.btnExec.Text = "HTMLファイルを選択して、トラッキング用タグを追加";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(651, 356);
            this.txtTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(44, 39);
            this.txtTemplate.TabIndex = 9;
            this.txtTemplate.Text = resources.GetString("txtTemplate.Text");
            this.txtTemplate.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(737, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 15);
            this.label15.TabIndex = 8;
            this.label15.Text = "トラッキング用タグ↓";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(56, 441);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(639, 232);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(53, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "トラッキング用タグ↓";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(305, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(193, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(735, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "トラッキングID";
            // 
            // lblHtmlFile
            // 
            this.lblHtmlFile.AutoSize = true;
            this.lblHtmlFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHtmlFile.Location = new System.Drawing.Point(445, 730);
            this.lblHtmlFile.Name = "lblHtmlFile";
            this.lblHtmlFile.Size = new System.Drawing.Size(27, 15);
            this.lblHtmlFile.TabIndex = 8;
            this.lblHtmlFile.Text = "　　";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(53, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "トラッキングID";
            // 
            // txtTrackingH3
            // 
            this.txtTrackingH3.Enabled = false;
            this.txtTrackingH3.Location = new System.Drawing.Point(324, 338);
            this.txtTrackingH3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrackingH3.MaxLength = 1;
            this.txtTrackingH3.Name = "txtTrackingH3";
            this.txtTrackingH3.Size = new System.Drawing.Size(33, 22);
            this.txtTrackingH3.TabIndex = 7;
            this.txtTrackingH3.Text = "1";
            // 
            // txtTrackingH1
            // 
            this.txtTrackingH1.Enabled = false;
            this.txtTrackingH1.Location = new System.Drawing.Point(153, 338);
            this.txtTrackingH1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrackingH1.MaxLength = 2;
            this.txtTrackingH1.Name = "txtTrackingH1";
            this.txtTrackingH1.Size = new System.Drawing.Size(33, 22);
            this.txtTrackingH1.TabIndex = 4;
            this.txtTrackingH1.Text = "UA";
            // 
            // txtTrackingH2
            // 
            this.txtTrackingH2.Location = new System.Drawing.Point(212, 338);
            this.txtTrackingH2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrackingH2.MaxLength = 9;
            this.txtTrackingH2.Name = "txtTrackingH2";
            this.txtTrackingH2.Size = new System.Drawing.Size(89, 22);
            this.txtTrackingH2.TabIndex = 5;
            this.txtTrackingH2.Text = "123456789";
            this.txtTrackingH2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel2.Location = new System.Drawing.Point(339, 54);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(243, 15);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://accounts.google.com/SignUp";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoogle_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(739, 356);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 318);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(739, 156);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(581, 158);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel3.Location = new System.Drawing.Point(339, 115);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(233, 15);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://www.google.com/analytics/";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAnalytics_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(31, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "ステップ３.２：測定対象を選択（ウェブを選択）";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(31, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "ステップ３.４：Googleアナリティクス利用規約を同意して、次へ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(31, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "ステップ３.３：測定対象ホームページのURLを設定";
            // 
            // linkAnalytics
            // 
            this.linkAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAnalytics.AutoSize = true;
            this.linkAnalytics.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkAnalytics.Location = new System.Drawing.Point(339, 100);
            this.linkAnalytics.Name = "linkAnalytics";
            this.linkAnalytics.Size = new System.Drawing.Size(387, 15);
            this.linkAnalytics.TabIndex = 2;
            this.linkAnalytics.TabStop = true;
            this.linkAnalytics.Text = "ログイン済みの場合、ここをクリックして、アナリティクスにログインする";
            this.linkAnalytics.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAnalytics_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(31, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "ステップ３.１：アカウント名の入力";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(19, 692);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(573, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "ステップ６：指定HTMLファイルに埋める。(※ファイルに</head>が見つからない場合、動作しません)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(19, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(623, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "ステップ５：上記トラッキングIDを入力後、下のタグが自動生成されます。Googleアナリティクスにも表示される";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(19, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(358, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "ステップ４：Googleアナリティクスに必要なトラッキングIDを取得";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ステップ３：測定を開始によりアナリティクスアカウントを作成する";
            // 
            // linkGoogle
            // 
            this.linkGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGoogle.AutoSize = true;
            this.linkGoogle.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkGoogle.Location = new System.Drawing.Point(339, 39);
            this.linkGoogle.Name = "linkGoogle";
            this.linkGoogle.Size = new System.Drawing.Size(336, 15);
            this.linkGoogle.TabIndex = 0;
            this.linkGoogle.TabStop = true;
            this.linkGoogle.Text = "無ければ、ここをクリックして、Googleアカウントを作成する";
            this.linkGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoogle_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ステップ２：Googleアカウントへログインする。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ステップ１：GoogleアカウントIDが必要です。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 780);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Googleアナリティクス導入手順";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkGoogle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkAnalytics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrackingH2;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTrackingH1;
        private System.Windows.Forms.TextBox txtTrackingH3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtTemplate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.CheckBox chkTrackEdit;
        private System.Windows.Forms.Label lblHtmlFile;
    }
}

