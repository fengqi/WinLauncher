using System;

namespace WinLauncher.Models {
    [Serializable]
    public class AppInfo {
        public string Name { get; set; }
        public string CustomName { get; set; }
        public string ExePath { get; set; }
        public string Args { get; set; }
        public string IconPath { get; set; }
        public int LaunchCount { get; set; }
        public int Sort { get; set; }
        public bool Deleted { get; set; }
        public string Pinyin { get; set; }
    }
}
