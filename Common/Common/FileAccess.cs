using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Common
{
    public class FileAccess
    {
        private List<string> _list1;
        private List<string> _list2;
        private List<string> _listAll;

        public List<string> ListString
        { get { return _list1; } }
        public List<string> ListMemo
        { get { return _list2; } }
        public List<string> ListAll
        { get { return _listAll; } }

        public string FilePath { get; set; }


        public FileAccess(string path)
        {
            if(File.Exists(path))
            {
                FilePath = path;
            }
            else
            {
                FilePath = Path.Combine(System.Environment.CurrentDirectory, "data.txt");
                MessageBox.Show("データファイルが存在しません。:" + FilePath
                    + System.Environment.NewLine + FilePath + "をデータファイルに設定します。","",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                if (!File.Exists(FilePath)) File.Create(FilePath);
             }
        }

        public bool IsNotExistFile
        {
            get{ return string.IsNullOrWhiteSpace(FilePath); }
        }

        public void ReadFile()
        {
            using (var sr = new StreamReader(FilePath))
            {
                _list1 = new List<string>();
                _list2 = new List<string>();
                _listAll = new List<string>();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    _listAll.Add(line);
                }

                _listAll.Sort();

                foreach(string s in _listAll)
                {
                    string[] ary = s.Split('\t');
                    if (ary.Length.Equals(0))
                    {
                        _list1.Add(string.Empty);
                        _list2.Add(string.Empty);
                    }
                    else if (ary.Length.Equals(1))
                    {
                        _list1.Add(ary[0]);
                        _list2.Add(string.Empty);
                    }
                    else
                    {
                        _list1.Add(ary[0]);

                        string wk = null;
                        for (int i = 1; i < ary.Length;i++)
                        {
                            wk += ary[i] + " ";

                        }

                        _list2.Add(wk);
                    }
                }
            }
        }

    }
}
