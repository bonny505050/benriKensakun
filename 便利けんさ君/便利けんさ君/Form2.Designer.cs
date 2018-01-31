namespace 便利けんさ君
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtDataFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.chkAddStartUp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDataFilePath
            // 
            this.txtDataFilePath.Location = new System.Drawing.Point(83, 12);
            this.txtDataFilePath.Name = "txtDataFilePath";
            this.txtDataFilePath.Size = new System.Drawing.Size(323, 19);
            this.txtDataFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "データファイル";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(331, 83);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(412, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(412, 10);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(77, 23);
            this.btnFileSelect.TabIndex = 2;
            this.btnFileSelect.Text = "ファイル選択";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // chkAddStartUp
            // 
            this.chkAddStartUp.AutoSize = true;
            this.chkAddStartUp.Location = new System.Drawing.Point(12, 37);
            this.chkAddStartUp.Name = "chkAddStartUp";
            this.chkAddStartUp.Size = new System.Drawing.Size(136, 16);
            this.chkAddStartUp.TabIndex = 5;
            this.chkAddStartUp.Text = "スタートアップに登録する";
            this.chkAddStartUp.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 113);
            this.Controls.Add(this.chkAddStartUp);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.CheckBox chkAddStartUp;
    }
}