using Common;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace 便利けんさ君
{
    public partial class Form2 : Form
    {

        // WSHスクリプト名
        string jsFile;

        string aplTitle;
        // ショートカットのリンク名
        string sMnu;
        string lnkFile ;
        // 自身のexeファイル名を取得
        string exeFile ;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            txtDataFilePath.Text = FileDialogUtil.OpenFileDialog(txtDataFilePath.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PublicRefer.Setting.DataFile = txtDataFilePath.Text.Trim();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // WSHスクリプト名
            jsFile = Directory.GetParent(Application.ExecutablePath) + "\\addStartup.js";
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = Attribute.GetCustomAttribute(
              assembly,
              typeof(AssemblyTitleAttribute)
            ) as AssemblyTitleAttribute;
            aplTitle = attribute.Title;
            // ショートカットのリンク名
            sMnu = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            lnkFile = sMnu + "\\" + aplTitle + ".lnk";
            // 自身のexeファイル名を取得
            exeFile = Path.GetFileName(Application.ExecutablePath);

            txtDataFilePath.Text = PublicRefer.Setting.DataFile;
            // スタートアップ有無
            chkAddStartUp.Checked = File.Exists(lnkFile);
            this.chkAddStartUp.CheckedChanged += new System.EventHandler(this.chkAddStartUp_CheckedChanged);
        }

        /// <summary>
        /// [スタートアップに登録]チェックボックスのチェック変更時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAddStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddStartUp.Checked)
            {

                //作成するショートカットのパス
                string shortcutPath = System.IO.Path.Combine(
                Environment.GetFolderPath(System.Environment.SpecialFolder.Startup),
                lnkFile);
                //ショートカットのリンク先
                string targetPath = Application.ExecutablePath;

                //WshShellを作成
                Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8"));
                dynamic shell = Activator.CreateInstance(t);


                //WshShortcutを作成
                var shortcut = shell.CreateShortcut(shortcutPath);

                //リンク先
                shortcut.TargetPath = targetPath;
                //アイコンのパス
                shortcut.IconLocation = Application.ExecutablePath + ",0";
                //その他のプロパティも同様に設定できるため、省略
                //作業フォルダ
                shortcut.WorkingDirectory = Environment.CurrentDirectory;


                //ショートカットを作成
                shortcut.Save();

                //後始末
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(shortcut);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(shell);

                // スタートアップフォルダに登録されたか確認
                if (File.Exists(lnkFile))
                {
                    MessageBox.Show(
                        "スタートアップに登録しました。\n\n" + lnkFile,
                        aplTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "スタートアップへの登録に失敗しました。\n\n" + lnkFile,
                        aplTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

            }
            else
            {
                // スタートアップフォルダに登録済みか確認
                if (File.Exists(lnkFile))
                {
                    try
                    {
                        File.Delete(lnkFile);
                        MessageBox.Show(
                            "スタートアップから削除しました。",
                            aplTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(
                            "スタートアップからの削除に失敗しました。\n\n" + ex.Message,
                            aplTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }

            // スタートアップ有無
            chkAddStartUp.Checked = File.Exists(lnkFile);
        }
    }

}
