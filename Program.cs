﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinLauncher {
    internal static class Program {
        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            SetProcessDPIAware();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
