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
    public partial class ERTools
    {
        public ERTools()
        {
            InitializeComponent();
        }

        void xBinderTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\BinderTool\\");
        }

        void xCameraTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Camera Tools\\IGCSClient.exe");
        }

        void xDSAnimStudio_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\DS Anim Studio\\DS ANIM STUDIO.exe");
        }

        void xDSMapStudio_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\DSMapStudio\\DSMapStudio.exe");
        }

        void xGideon_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Gideon\\Gideon.exe");
        }

        void xModelTemplates_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Model Templates\\");
        }

        void xMTDEditor_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\MTD Editor\\MTD-Editor.exe");
        }

        void xSMDTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\SMD Tool\\");
        }

        void xUXMUnpacker_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\UXM Unpacker\\UXM Selective Unpack.exe");
        }

        void xWwiseUnpacker_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Wwise Unpacker\\");
        }
        void xX3LTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\X3L Tool\\X3L Elden Ring Tool.exe");
        }
        void xYabber_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Yabber\\");
        }
        void xYapped_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Yapped\\Yapped-Rune-Bear.exe");
        }
        void xAquaModelTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\AquaModelTool\\SoulsModelTool.exe");
        }
        void xERGame_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\SteamLibrary\\steamapps\\common\\ELDEN RING\\Game\\");
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
    }

}