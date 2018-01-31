using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using System.ComponentModel;
namespace CustomControl
{
    public class CustomTextBox : TextBox
    {

        #region プロパティ　追加分
        [Browsable(true)]
        [Description("入力タイプ")]
        [Category("動作")]
        public InputType InputType { get; set; }

        public int? IntValue
        { get { return GetIntValue(Text); } }
        #endregion

        #region イベント　オーバーライド
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // 全てのタイプでBackSpaceはOK
            if (e.KeyChar == '\b') return;

            switch (InputType)
            {
                case InputType.Num:
                    if (e.KeyChar < '0' || '9' < e.KeyChar)
                    {
                        //押されたキーが 0～9でない場合は、イベントをキャンセルする
                        e.Handled = true;
                    }
                    break;
            }


        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            ////ドロップされたファイルの一覧を取得
            //string[] fileName = (string[])drgevent.Data.GetData(DataFormats.FileDrop, false);
            //if (fileName.Length <= 0) return;

            ////TextBoxの内容をファイル名に変更
            //Text = fileName[0];
            //Focus();

            base.OnDragDrop(drgevent);


        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);

            ////ファイルがドラッグされている場合、カーソルを変更する
            //if (drgevent.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    drgevent.Effect = DragDropEffects.Copy;
            //}

        }
        #endregion

        #region ユーティリティ
        private int? GetIntValue(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

        #endregion
    }

    public enum InputType
    {
        None,
        Num,

    }
}
