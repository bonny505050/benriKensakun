using Common;
using System;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace 便利けんさ君
{
    public partial class Form1 : Form
    {
        XmlUtil xmlUtil;
        XmlSerializer serializer = new XmlSerializer(typeof(Setting));
        FileAccess fa ;

        public Form1()
        {
            InitializeComponent();
            xmlUtil = new XmlUtil(serializer, @"setting.xml");
            PublicRefer.Setting = (Setting)xmlUtil.Read();
            InitFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HotKey.RegistHotKey(this.Handle);

            lbString.Items.Clear();
            lbMemo.Items.Clear();

            fa.ListString.ForEach(r => lbString.Items.Add(r));
            fa.ListMemo.ForEach(r => lbMemo.Items.Add(r));
        }

        private void InitFile()
        {
            fa = new FileAccess(PublicRefer.Setting.DataFile.Trim());
            PublicRefer.Setting.DataFile = fa.FilePath;
            fa.ReadFile();
            TextChange();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
            HotKey.UnregitsHotKey(this.Handle);

            xmlUtil.Write(PublicRefer.Setting);

        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg.Equals(HotKey.WMHotKey))
            {
                if (((int)m.WParam).Equals(HotKey.HotKeyId))
                {
                    /* ホットキーの処理 */
                    this.Visible = !this.Visible;
                    if (this.Visible) txtSearch.Focus();
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_End_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode.Equals(Keys.Enter))
            {
                // 終了
                Application.Exit();
            }
            else if (e.KeyCode.Equals(Keys.Enter))
            {
                // 非表示
                if(lbString.SelectedIndex >=0) Clipboard.SetText(lbString.SelectedItem.ToString());
                this.Visible = false;
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                if (ActiveControl.Equals(lbString) && !lbString.SelectedIndex.Equals(lbString.Items.Count - 1)) return;
                // フォーカス移動
                SelectNextControl(ActiveControl, true, true, true, true);
            }
            else if( e.KeyCode.Equals(Keys.Up))
            {
                if (ActiveControl.Equals(lbString) && !lbString.SelectedIndex.Equals(0)) return;
                // フォーカス移動
                SelectNextControl(ActiveControl, false, true, true, true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextChange();
        }

        private void TextChange()
        {
            lbString.Items.Clear();
            lbMemo.Items.Clear();

            for (int i = 0; i < fa.ListAll.Count; i++)
            {
                if (fa.ListAll[i].Contains(txtSearch.Text))
                {
                    lbString.Items.Add(fa.ListString[i]);
                    lbMemo.Items.Add(fa.ListMemo[i]);
                }
            }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            if(lbString.Items.Count> 0) lbString.SelectedIndex = 0;
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.ShowDialog();
            InitFile();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(PublicRefer.Setting.DataFile);
            p.WaitForExit();

            InitFile();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            InitFile();
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button.Equals(MouseButtons.Left)) this.Visible = !this.Visible;
        }
    }
}
