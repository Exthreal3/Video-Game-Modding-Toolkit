using System;
using System.Windows;
using System.Threading;
using System.Windows.Media;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.ServiceProcess;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Input;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace X3LEldenRingTool
{
    public partial class MainWindow : Window
    {
        internal Process _gameProc;
        internal IntPtr _gameHwnd = IntPtr.Zero;
        internal IntPtr _gameAccessHwnd = IntPtr.Zero;
        internal static IntPtr _gameAccessHwndStatic;

        private void bCheatEngine_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Elden Ring Modding Tools\\Mod Folders\\X3L Elden Ring Tool\\bin\\X3L Table.CT");
        }

        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Elden Ring Modding Tools\\Mod Folders\\X3L Elden Ring Tool\\bin\\CLOSE ER.bat");
        }

    }
}