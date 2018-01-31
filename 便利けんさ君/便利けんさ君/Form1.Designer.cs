namespace 便利けんさ君
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbString = new System.Windows.Forms.ListBox();
            this.button_End = new System.Windows.Forms.Button();
            this.btnDataEdit = new System.Windows.Forms.Button();
            this.lbMemo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            this.contextMenuStrip1.Text = "メニュー";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(156, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(524, 19);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // lbString
            // 
            this.lbString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbString.FormattingEnabled = true;
            this.lbString.ItemHeight = 12;
            this.lbString.Items.AddRange(new object[] {
            "aaa",
            "bbb"});
            this.lbString.Location = new System.Drawing.Point(12, 58);
            this.lbString.Name = "lbString";
            this.lbString.Size = new System.Drawing.Size(481, 280);
            this.lbString.TabIndex = 2;
            this.lbString.Enter += new System.EventHandler(this.listBox1_Enter);
            // 
            // button_End
            // 
            this.button_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_End.Location = new System.Drawing.Point(605, 404);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(75, 23);
            this.button_End.TabIndex = 5;
            this.button_End.Text = "終了";
            this.button_End.UseVisualStyleBackColor = true;
            this.button_End.Click += new System.EventHandler(this.button_End_Click);
            // 
            // btnDataEdit
            // 
            this.btnDataEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDataEdit.Location = new System.Drawing.Point(12, 404);
            this.btnDataEdit.Name = "btnDataEdit";
            this.btnDataEdit.Size = new System.Drawing.Size(105, 23);
            this.btnDataEdit.TabIndex = 3;
            this.btnDataEdit.Text = "データ編集";
            this.btnDataEdit.UseVisualStyleBackColor = true;
            this.btnDataEdit.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // lbMemo
            // 
            this.lbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMemo.FormattingEnabled = true;
            this.lbMemo.ItemHeight = 12;
            this.lbMemo.Items.AddRange(new object[] {
            "aaa",
            "bbb"});
            this.lbMemo.Location = new System.Drawing.Point(499, 58);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(181, 280);
            this.lbMemo.TabIndex = 8;
            this.lbMemo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "検　索　結　果";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(499, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "メ　　モ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "検索キーワード";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.Location = new System.Drawing.Point(123, 404);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(105, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "データ再読込み";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(12, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(605, 48);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ctrl + Alt + F ・・・ 画面の表示／表示を切り替え\r\nEnter 　　　　 ・・・ 検索結果リストから選択された内容をクリップボードにコピーし、画面" +
    "を非表示にする\r\nCtrl + Enter 　・・・ 検索結果リストから選択された内容をクリップボードにコピーし、プログラムを終了\r\n↓↑キー 　　　・・・ カ" +
    "ーソル移動\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 430);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDataEdit);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.lbString);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "便利けんさ君";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbString;
        private System.Windows.Forms.Button button_End;
        private System.Windows.Forms.Button btnDataEdit;
        private System.Windows.Forms.ListBox lbMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label4;
    }
}

