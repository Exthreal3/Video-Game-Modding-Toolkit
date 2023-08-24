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
    public partial class BG3Tools : Window
    {
        public BG3Tools()
        {
            InitializeComponent();
        }

        void bBG3Table_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\BG3Table.CT");
        }

        void bBG3_DX11Table_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\BG3_DX11Table.CT");
        }

        void bModManager_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\ModManager\\BG3ModManager.exe");
        }

        void bExportTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\ExportTool\\ConverterApp.exe");
        }

        void bCameraTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\CameraTool\\IGCSClient.exe");
        }

        void bMiniTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\MiniTool\\BG3 Mini Tool.exe");
        }

        void bMultiTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\MultiTool\\bg3-modders-multitool.exe");
        }

        void bSaveFiles_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\jayan\\AppData\\Local\\Larian Studios\\Baldur's Gate 3\\PlayerProfiles\\Public\\");
        }

        void bMods_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\jayan\\AppData\\Local\\Larian Studios\\Baldur's Gate 3\\Mods\\");
        }

        void bGameData_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\New folder\\Baldurs Gate 3\\Data\\");
        }

        void bGameBin_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("E:\\New folder\\Baldurs Gate 3\\Bin\\");
        }

        void bUnpackedFiles_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\MultiTool\\UnpackedData\\");
        }

        void bReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void bMinimizeProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}