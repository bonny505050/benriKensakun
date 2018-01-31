using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomControl
{
    public class CustomWebBrowser : WebBrowser
    {

        #region プロパティ
        public new bool AllowWebBrowserDrop
        {
            get { return false; }
        }
        #endregion

        #region メソッド

        /// <summary>
        /// 指定されたURLをツールバーを表示しない状態で読み込みます。
        /// </summary>
        /// <param name="urlString"></param>
        public void NavigateNoToolbar(string urlString)
        {
            this.Navigate(urlString + "#toolbar=0&navpanes=0");
        }

        #endregion

        #region 
        //protected override void OnDragDrop(DragEventArgs drgevent)
        //{
        //    base.OnDragDrop(drgevent);

        //    //ドロップされたファイルの一覧を取得
        //    string[] fileName = (string[])drgevent.Data.GetData(DataFormats.FileDrop, false);
        //    if (fileName.Length <= 0) return;

        //    //TextBoxの内容をファイル名に変更
        //    Navigate(fileName[0]);
        //}

        //protected override void OnDragEnter(DragEventArgs drgevent)
        //{
        //    base.OnDragEnter(drgevent);
        //    //ファイルがドラッグされている場合、カーソルを変更する
        //    if (drgevent.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        drgevent.Effect = DragDropEffects.Copy;
        //    }

        //}


        #endregion

    }
}
