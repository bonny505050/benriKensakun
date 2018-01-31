using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomControl
{
    public partial class OonoKun : UserControl
    {
        #region メンバ変数

        private List<CustomWebBrowser> _browserList;

        #endregion

        public OonoKun()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            _browserList = new List<CustomWebBrowser>();
        }

        /// <summary>
        /// ユーザーコントロール上にブラウザを追加します。
        /// </summary>
        /// <param name="urlString">ブラウザに表示させるURL</param>
        public void AddBrowser(string urlString)
        {
            int index = _browserList.Count + 1;
            var browser = new CustomWebBrowser();
            this.Controls.Add(browser);

            browser.Size = new Size(250, 250);
            browser.Location = new Point(1, (browser.Size.Height + 2) * _browserList.Count);
            browser.BringToFront();

            _browserList.Add(browser);
        }
    }
}
