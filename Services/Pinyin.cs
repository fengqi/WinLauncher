using System;
using System.Text;

namespace WinLauncher.Services {
    internal class Pinyin {
        private static Encoding gb2312 = Encoding.GetEncoding("GB2312");

        public String GetFirstPro(string name) {
            try {
                if (name.Length != 0) {
                    StringBuilder fullSpell = new StringBuilder();
                    for (int i = 0; i < name.Length; i++) {
                        var chr = name[i];
                        if (chr == '：' || chr == '-' || chr == '_') {
                            continue;
                        }
                        fullSpell.Append(GetSpell(chr)[0]);
                    }
                    return fullSpell.ToString().ToUpper();
                }
            }
            catch (Exception e) {
                Console.WriteLine("出错！" + e.Message);
            }
            return string.Empty;
        }

        public String GetAllPro(string name) {
            try {
                if (name.Length != 0) {
                    StringBuilder fullSpell = new StringBuilder();
                    for (int i = 0; i < name.Length; i++) {
                        var chr = name[i];
                        fullSpell.Append(GetSpell(chr));
                    }
                    return fullSpell.ToString().ToUpper();
                }
            }
            catch (Exception e) {
                Console.WriteLine("出错！" + e.Message);
            }
            return string.Empty;
        }

        private static string GetSpell(char chr) {
            var coverchr = NPinyin.Pinyin.GetPinyin(chr);
            return coverchr;
        }
    }
}
