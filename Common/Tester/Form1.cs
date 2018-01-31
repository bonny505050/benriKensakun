using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HotKey.RegistHotKey(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg.Equals(HotKey.WMHotKey))
            {
                if (((int)m.WParam).Equals(HotKey.HotKeyId))
                {
                    /* ホットキーの処理 */
                    MessageBox.Show("Alt+Aが押されました。");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ホットキーの登録抹消
            HotKey.UnregitsHotKey(this.Handle);
        }
    }



}
