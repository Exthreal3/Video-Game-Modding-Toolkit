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
using MessageBox = System.Windows.MessageBox;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Windows.Interop;

namespace X3LToolBar
{

    public partial class ToolBar : Window
    {
        public ToolBar()
        {
            InitializeComponent();
        }

        public void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        void xERTools_Click(object sender, RoutedEventArgs e)
        {
            ERTools wERTools = new ERTools();
            wERTools.ShowDialog();
        }
        private void xConfigWindow_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindow configWindow = new ConfigWindow();
            configWindow.ShowDialog();
        }
        void xBG3Tools_Click(object sender, RoutedEventArgs e)
        {
            BG3Tools wBG3Tools = new BG3Tools();
            wBG3Tools.Show();
            this.Close();
        }

        void xCloseProgram_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); 

        }

        void xMinimizeProgram_Click(object sender, RoutedEventArgs e)
        {
            MaximizeButton maximizeButton = new MaximizeButton();
            maximizeButton.Show();
            this.Close();
        }

        void xCMD_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe");
        }

        void xPowershell_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\Powershell.exe");
        }

        void xOverwatch_Click(object sender, RoutedEventArgs e)
        {
            Overwatch xOverwatch = new Overwatch();
            xOverwatch.ShowDialog();
        }

        void xYTDLP_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin(".\\yt-dlp.bat");
        }

    }
}
