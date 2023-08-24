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
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;

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

        void bERTools_Click(object sender, RoutedEventArgs e)
        {
            ERTools wERTools = new ERTools();
            wERTools.ShowDialog();
        }

        void bBG3Tools_Click(object sender, RoutedEventArgs e)
        {
            BG3Tools wBG3Tools = new BG3Tools();
            wBG3Tools.ShowDialog();
        }

        void bCloseProgram_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); 

        }

        async void bMinimizeProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void bCMD_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin("C:\\Windows\\System32\\cmd.exe");
        }

        void bPowershell_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin("C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\Powershell.exe");
        }

        void bOverwatch_Click(object sender, RoutedEventArgs e)
        {
            Overwatch wOverwatch = new Overwatch();
            wOverwatch.ShowDialog();
        }

    }
}
