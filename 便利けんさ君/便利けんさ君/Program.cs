using Common;
using System;
using System.Windows.Forms;

namespace 便利けんさ君
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //Mutexクラスの作成
                //"MyName"の部分を適当な文字列に変えてください
                System.Threading.Mutex mutex = new System.Threading.Mutex(false, "MyName");
                //ミューテックスの所有権を要求する
                if (mutex.WaitOne(0, false) == false)
                {
                    //すでに起動していると判断して終了
                    MessageBox.Show("多重起動はできません。");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

                //ミューテックスを解放する
                mutex.ReleaseMutex();
            }
            catch(Exception ex)
            {
                Log.OutPutErrorLog(ex.Message);
            }
        }
    }
}
