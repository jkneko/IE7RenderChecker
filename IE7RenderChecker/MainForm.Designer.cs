namespace IE7RenderChecker
{
    partial class MainForm
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.goButton = new System.Windows.Forms.Button();
            this.ieComboBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reloadInterval = new System.Windows.Forms.NumericUpDown();
            this.reloadCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reloadInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(445, 9);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(541, 22);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "https://";
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(321, 8);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(23, 25);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prevButton_MouseClick);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(349, 8);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(23, 25);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nextButton_MouseClick);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(375, 8);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(64, 25);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reloadButton_MouseClick);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 40);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(16, 16);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1047, 662);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(992, 8);
            this.goButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(45, 25);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // ieComboBox
            // 
            this.ieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ieComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ieComboBox.FormattingEnabled = true;
            this.ieComboBox.Location = new System.Drawing.Point(8, 9);
            this.ieComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ieComboBox.Name = "ieComboBox";
            this.ieComboBox.Size = new System.Drawing.Size(106, 23);
            this.ieComboBox.TabIndex = 6;
            this.ieComboBox.DropDownClosed += new System.EventHandler(this.ieComboBox_DropDownClosed);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reloadInterval
            // 
            this.reloadInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reloadInterval.Location = new System.Drawing.Point(251, 9);
            this.reloadInterval.Margin = new System.Windows.Forms.Padding(4);
            this.reloadInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reloadInterval.Name = "reloadInterval";
            this.reloadInterval.Size = new System.Drawing.Size(46, 22);
            this.reloadInterval.TabIndex = 7;
            this.reloadInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.reloadInterval.ValueChanged += new System.EventHandler(this.reloadInterval_ValueChanged);
            // 
            // reloadCheckbox
            // 
            this.reloadCheckbox.AutoSize = true;
            this.reloadCheckbox.Location = new System.Drawing.Point(139, 11);
            this.reloadCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.reloadCheckbox.Name = "reloadCheckbox";
            this.reloadCheckbox.Size = new System.Drawing.Size(102, 19);
            this.reloadCheckbox.TabIndex = 9;
            this.reloadCheckbox.Text = "Auto reload";
            this.reloadCheckbox.UseVisualStyleBackColor = true;
            this.reloadCheckbox.CheckedChanged += new System.EventHandler(this.reloadCheckbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(127, -19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(182, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 701);
            this.Controls.Add(this.reloadCheckbox);
            this.Controls.Add(this.reloadInterval);
            this.Controls.Add(this.ieComboBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "IE7RenderChecker";
            ((System.ComponentModel.ISupportInitialize)(this.reloadInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox ieComboBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown reloadInterval;
        private System.Windows.Forms.CheckBox reloadCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

