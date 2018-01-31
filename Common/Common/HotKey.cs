using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Common
{
    /// <summary>
    /// ホットキー登録・削除
    /// </summary>
    public static class HotKey
    {
        const int MOD_ALT = 0x0001;
        const int MOD_CONTROL = 0x0002;
        //const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;

        const int HOTKEY_ID = 0x0001;  // 0x0000～0xbfff 内の適当な値でよい

        [DllImport("user32.dll")]
        extern static int RegisterHotKey(IntPtr HWnd, int ID, int MOD_KEY, int KEY);
        [DllImport("user32.dll")]
        extern static int UnregisterHotKey(IntPtr HWnd, int ID);

        public static int HotKeyId { get { return HOTKEY_ID; } }
        public static int WMHotKey { get { return WM_HOTKEY; } }

        /// <summary>
        /// ホットキーの登録 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="modKey"></param>
        /// <param name="key"></param>
        public static void RegistHotKey(IntPtr handle, int modKey, Keys key)
        {
            RegisterHotKey(handle, HOTKEY_ID, modKey, (int)key);
        }

        /// <summary>
        /// ホットキーの登録 "CTRL + ALT + F"
        /// </summary>
        /// <param name="handle"></param>
        public static void RegistHotKey(IntPtr handle)
        {
            RegistHotKey(handle, MOD_CONTROL + MOD_ALT, Keys.F);
        }

        /// <summary>
        /// ホットキーの登録抹消
        /// </summary>
        /// <param name="handle"></param>
        public static void UnregitsHotKey(IntPtr handle)
        {
            UnregisterHotKey(handle, HOTKEY_ID);
        }

    }
}
