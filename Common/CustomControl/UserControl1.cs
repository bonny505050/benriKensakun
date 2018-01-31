using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class UserControl1 : UserControl
    {
        public string TempDirectoryPath { get; private set; }
        public string OriginalDirectoryPath { get; private set; }
        public string OriginalFileNmae { get; private set; }
        public List<string> PdfFilePathList { get; private set; }
        private List<string> _directoryPathList = new List<string>();



        List<WebBrowser> bList = new List<WebBrowser>();

        public UserControl1()
        {
            InitializeComponent();
            //bList.Add(wbFirst);
        }

        public string MainPdfFilePath
        {
            get { return PdfFilePathList[GetMainPageIndex]; }
        }

        public void InsertPdf(string pdfFilePath)
        {
            PdfFilePathList.Insert(txtPageMain.IntValue.Value, pdfFilePath);
            txtPageMain.Text = (txtPageMain.IntValue.Value + 1).ToString();
            SetNumberOfPages();
            DisplayPdf();
        }

        public void DeletePdf()
        {
            PdfFilePathList.RemoveAt(GetMainPageIndex);
            SetNumberOfPages();
            DisplayPdf();

        }

        private void ClearBrowser()
        {
            wbFirst.Navigate(string.Empty);
            wbMid.Navigate(string.Empty);
            wbEnd.Navigate(string.Empty);

            //wbFirst = new CustomWebBrowser();
            //wbMid = new CustomWebBrowser();
            //wbEnd = new CustomWebBrowser();
        }



        private int GetMainPageIndex
        {
            get { return txtPageMain.IntValue.Value - 1; }
        }


        public void DeleteTempDirectory()
        {
            DeleteTempDirectory(TempDirectoryPath);
        }

        public void DeleteTempDirectory(string directoryPath)
        {
            ClearBrowser();

            wbFirst.Dispose();
            wbMid.Dispose();
            wbEnd.Dispose();

            foreach (string path in _directoryPathList)
            {
                if (!string.IsNullOrEmpty(path)) Directory.Delete(path, true);
            }
        }



        private void SetPdfPathList()
        {
            PdfReader reader = new PdfReader(txtInputPdfFilePath.Text);
            Document document = new Document();
            PdfCopy copy = null;
            PdfFilePathList = new List<string>();

            OriginalDirectoryPath = Path.GetDirectoryName(txtInputPdfFilePath.Text);

            TempDirectoryPath = Path.Combine(OriginalDirectoryPath, "PDF_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            _directoryPathList.Add(TempDirectoryPath);

            OriginalFileNmae = Path.GetFileNameWithoutExtension(txtInputPdfFilePath.Text);

            Directory.CreateDirectory(TempDirectoryPath);

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                PdfFilePathList.Add(Path.Combine(TempDirectoryPath, OriginalFileNmae) + "_" + i.ToString() + ".pdf");
                using (var fs = new FileStream(PdfFilePathList.Last(), FileMode.Create, FileAccess.Write))
                {
                    try
                    {
                        document = new Document(reader.GetPageSizeWithRotation(1));
                        copy = new PdfCopy(document, fs);
                        document.Open();
                        copy.AddPage(copy.GetImportedPage(reader, i));
                    }
                    finally
                    {
                        document.Close();
                        copy.Close();

                    }
                }
            }

            reader.Close();

            SetNumberOfPages();
            txtPageMain.Text = "1";
            DisplayPdf();

            document.Dispose();
            copy.Dispose();
            reader.Dispose();

        }

        private void SetNumberOfPages()
        {
            lblNumberOfPages.Text = PdfFilePathList.Count().ToString();
        }

        private void txtInputPdfFilePath_DragDrop(object sender, DragEventArgs e)
        {

            //SetPdfPathList();
            //ControlButtonEnabled();
        }

        private void DisplayPdf()
        {
            // ツールバー等を非表示にする　→　"#toolbar=0&navpanes=0"

            ClearBrowser();

            wbMid.Navigate(PdfFilePathList[GetMainPageIndex] + "#toolbar=0&navpanes=0");

            if (txtPageMain.IntValue.Value == 1)
            {
                wbFirst.Navigate(string.Empty);
                lblPageFirst.Text = string.Empty;
            }
            else
            {
                wbFirst.Navigate(PdfFilePathList[GetMainPageIndex - 1] + "#toolbar=0&navpanes=0");
                lblPageFirst.Text = (GetMainPageIndex - 1).ToString();
            }

            if (txtPageMain.IntValue.Value == int.Parse(lblNumberOfPages.Text))
            {
                wbEnd.Navigate(string.Empty);
                lblPageEnd.Text = string.Empty;
            }
            else
            {
                wbEnd.Navigate(PdfFilePathList[GetMainPageIndex + 1] + "#toolbar=0&navpanes=0");
                lblPageEnd.Text = (GetMainPageIndex + 1).ToString();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtPageMain.Text = (txtPageMain.IntValue.Value + 1).ToString();
            //ClearBrowser();
            ControlButtonEnabled();
            DisplayPdf();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            txtPageMain.Text = (txtPageMain.IntValue.Value - 1).ToString();
            //ClearBrowser();
            ControlButtonEnabled();
            DisplayPdf();
        }

        private void ControlButtonEnabled()
        {
            if (txtPageMain.IntValue == 1)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            else if (txtPageMain.IntValue == int.Parse(lblNumberOfPages.Text))
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
            }
            else if (!txtPageMain.IntValue.HasValue)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }


        }

        /// <summary>
        /// PDF出力ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutputPdf_Click(object sender, EventArgs e)
        {
            PdfCopy copy;
            var reader = new PdfReader(PdfFilePathList[0]);
            var document = new Document(reader.GetPageSizeWithRotation(1));
            reader.Close();

            string newPdfFilePath = Path.Combine(OriginalDirectoryPath, OriginalFileNmae);
            using (var fs = new FileStream(newPdfFilePath + "_New.pdf", FileMode.Create, FileAccess.Write))
            {
                copy = new PdfCopy(document, fs);
                document.Open();
                try
                {
                    foreach (string pdfPath in PdfFilePathList)
                    {
                        reader = new PdfReader(pdfPath);
                        copy.AddPage(copy.GetImportedPage(reader, 1));
                        reader.Close();
                    }
                }
                finally
                {
                    document.Close();
                    reader.Close();
                    copy.Close();
                }
            }

            MessageBox.Show(OriginalDirectoryPath);

            try
            {
                var oldPdfFilePath = Path.Combine(OriginalDirectoryPath, OriginalFileNmae);
                System.IO.File.Move(oldPdfFilePath + ".pdf", oldPdfFilePath + "_old.pdf");
                System.IO.File.Move(newPdfFilePath + "_New.pdf", newPdfFilePath + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }

        }

        private void txtPageMain_Leave(object sender, EventArgs e)
        {
            if (txtPageMain.TextLength <= 0) return;

            DisplayPdf();
            ControlButtonEnabled();
        }

        private void UserControl1_DragEnter(object sender, DragEventArgs e)
        {
            //ファイルがドラッグされている場合、カーソルを変更する
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }


        }

        private void UserControl1_DragDrop(object sender, DragEventArgs e)
        {



            //ドロップされたファイルの一覧を取得
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileName.Length <= 0) return;

            //TextBoxの内容をファイル名に変更
            txtInputPdfFilePath.Text = fileName[0];
            Focus();


            SetPdfPathList();
            ControlButtonEnabled();


        }
    }

}
