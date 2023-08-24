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

        void bBinderTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\BinderTool\\");
        }

        void bCameraTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Camera Tools\\IGCSClient.exe");
        }

        void bDSAnimStudio_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\DS Anim Studio\\DS ANIM STUDIO.exe");
        }

        void bDSMapStudio_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\DSMapStudio\\DSMapStudio.exe");
        }

        void bGideon_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Gideon\\Gideon.exe");
        }

        void bModelTemplates_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Model Templates\\");
        }

        void bMTDEditor_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\MTD Editor\\MTD-Editor.exe");
        }

        void bSMDTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\SMD Tool\\");
        }

        void bUXMUnpacker_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\UXM Unpacker\\UXM Selective Unpack.exe");
        }

        void bWwiseUnpacker_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Wwise Unpacker\\");
        }
        void bX3LTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\X3L Tool\\X3L Elden Ring Tool.exe");
        }
        void bYabber_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Yabber\\");
        }
        void bYapped_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\Yapped\\Yapped-Rune-Bear.exe");
        }
        void bAquaModelTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\ER\\AquaModelTool\\SoulsModelTool.exe");
        }
        void bERGame_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\SteamLibrary\\steamapps\\common\\ELDEN RING\\Game\\");
        }
        void bReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}