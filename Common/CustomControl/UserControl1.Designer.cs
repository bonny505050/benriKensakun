namespace CustomControl
{
    partial class UserControl1
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPageFirst = new System.Windows.Forms.Label();
            this.lblPageEnd = new System.Windows.Forms.Label();
            this.lblNumberOfPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnOutputPdf = new System.Windows.Forms.Button();
            this.txtPageMain = new CustomControl.CustomTextBox();
            this.wbEnd = new CustomControl.CustomWebBrowser();
            this.wbMid = new CustomControl.CustomWebBrowser();
            this.txtInputPdfFilePath = new CustomControl.CustomTextBox();
            this.wbFirst = new CustomControl.CustomWebBrowser();
            this.SuspendLayout();
            // 
            // lblPageFirst
            // 
            this.lblPageFirst.AutoSize = true;
            this.lblPageFirst.Location = new System.Drawing.Point(590, 437);
            this.lblPageFirst.Name = "lblPageFirst";
            this.lblPageFirst.Size = new System.Drawing.Size(35, 12);
            this.lblPageFirst.TabIndex = 8;
            this.lblPageFirst.Text = "label1";
            // 
            // lblPageEnd
            // 
            this.lblPageEnd.AutoSize = true;
            this.lblPageEnd.Location = new System.Drawing.Point(258, 437);
            this.lblPageEnd.Name = "lblPageEnd";
            this.lblPageEnd.Size = new System.Drawing.Size(35, 12);
            this.lblPageEnd.TabIndex = 9;
            this.lblPageEnd.Text = "label1";
            // 
            // lblNumberOfPages
            // 
            this.lblNumberOfPages.AutoSize = true;
            this.lblNumberOfPages.Location = new System.Drawing.Point(457, 457);
            this.lblNumberOfPages.Name = "lblNumberOfPages";
            this.lblNumberOfPages.Size = new System.Drawing.Size(35, 12);
            this.lblNumberOfPages.TabIndex = 10;
            this.lblNumberOfPages.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNext.Location = new System.Drawing.Point(299, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "←";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrev.Location = new System.Drawing.Point(514, 452);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "→";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnOutputPdf
            // 
            this.btnOutputPdf.Location = new System.Drawing.Point(810, 457);
            this.btnOutputPdf.Name = "btnOutputPdf";
            this.btnOutputPdf.Size = new System.Drawing.Size(75, 23);
            this.btnOutputPdf.TabIndex = 13;
            this.btnOutputPdf.Text = "PDF出力";
            this.btnOutputPdf.UseVisualStyleBackColor = true;
            this.btnOutputPdf.Click += new System.EventHandler(this.btnOutputPdf_Click);
            // 
            // txtPageMain
            // 
            this.txtPageMain.AllowDrop = true;
            this.txtPageMain.InputType = CustomControl.InputType.Num;
            this.txtPageMain.Location = new System.Drawing.Point(416, 454);
            this.txtPageMain.Name = "txtPageMain";
            this.txtPageMain.Size = new System.Drawing.Size(35, 19);
            this.txtPageMain.TabIndex = 7;
            this.txtPageMain.Leave += new System.EventHandler(this.txtPageMain_Leave);
            // 
            // wbEnd
            // 
            this.wbEnd.Location = new System.Drawing.Point(3, 28);
            this.wbEnd.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbEnd.Name = "wbEnd";
            this.wbEnd.Size = new System.Drawing.Size(290, 406);
            this.wbEnd.TabIndex = 6;
            // 
            // wbMid
            // 
            this.wbMid.Location = new System.Drawing.Point(299, 28);
            this.wbMid.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMid.Name = "wbMid";
            this.wbMid.Size = new System.Drawing.Size(290, 406);
            this.wbMid.TabIndex = 5;
            // 
            // txtInputPdfFilePath
            // 
            this.txtInputPdfFilePath.AllowDrop = true;
            this.txtInputPdfFilePath.InputType = CustomControl.InputType.Num;
            this.txtInputPdfFilePath.Location = new System.Drawing.Point(3, 3);
            this.txtInputPdfFilePath.Name = "txtInputPdfFilePath";
            this.txtInputPdfFilePath.Size = new System.Drawing.Size(505, 19);
            this.txtInputPdfFilePath.TabIndex = 4;
            this.txtInputPdfFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInputPdfFilePath_DragDrop);
            // 
            // wbFirst
            // 
            this.wbFirst.Location = new System.Drawing.Point(592, 28);
            this.wbFirst.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFirst.Name = "wbFirst";
            this.wbFirst.Size = new System.Drawing.Size(290, 406);
            this.wbFirst.TabIndex = 3;
            // 
            // UserControl1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnOutputPdf);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblNumberOfPages);
            this.Controls.Add(this.lblPageEnd);
            this.Controls.Add(this.lblPageFirst);
            this.Controls.Add(this.txtPageMain);
            this.Controls.Add(this.wbEnd);
            this.Controls.Add(this.wbMid);
            this.Controls.Add(this.txtInputPdfFilePath);
            this.Controls.Add(this.wbFirst);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(893, 481);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UserControl1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomTextBox txtInputPdfFilePath;
        private CustomTextBox txtPageMain;
        private System.Windows.Forms.Label lblPageFirst;
        private System.Windows.Forms.Label lblPageEnd;
        private System.Windows.Forms.Label lblNumberOfPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnOutputPdf;
        private CustomWebBrowser wbFirst;
        private CustomWebBrowser wbMid;
        private CustomWebBrowser wbEnd;
    }
}
