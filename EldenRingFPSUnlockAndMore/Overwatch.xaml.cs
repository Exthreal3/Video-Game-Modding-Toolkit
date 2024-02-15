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

namespace X3LToolBar
{
    public partial class Overwatch : Window
    {
        public Overwatch()
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

        void xMinimizeProgram_Click(object sender, RoutedEventArgs e)
        {
            ToolBar toolBar = new ToolBar();
            toolBar.Show();
            this.Close();
        }

        void xCloseProgram_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }

        void xOverwatch_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin("\\bin\\Overwatch\\Overwatch.bat");
        }

        void xCinematics_Click(object sender, RoutedEventArgs e)
        {
            ExecuteAsAdmin("\\bin\\Overwatch\\Cinematics.bat");
        }
    }

}