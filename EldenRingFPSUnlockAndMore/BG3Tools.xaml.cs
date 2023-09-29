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

        void xBG3Table_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\BG3Table.CT");
        }

        void xBG3_DX11Table_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\BG3_DX11Table.CT");
        }

        void xModManager_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\ModManager\\BG3ModManager.exe");
        }

        void xExportTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\ExportTool\\ConverterApp.exe");
        }

        void xCameraTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\CameraTool\\IGCSClient.exe");
        }

        void xMiniTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\MiniTool\\BG3 Mini Tool.exe");
        }

        void xMultiTool_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("bin\\BG3\\MultiTool\\bg3-modders-multitool.exe");
        }

        void xSaveFiles_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Xavier\\AppData\\Local\\Larian Studios\\Baldur's Gate 3\\PlayerProfiles\\Public\\");
        }

        void xMods_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Xavier\\AppData\\Local\\Larian Studios\\Baldur's Gate 3\\Mods\\");
        }

        void xGameData_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\SteamLibrary\\steamapps\\common\\Baldurs Gate 3\\Data\\");
        }

        void xGameBin_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\SteamLibrary\\steamapps\\common\\Baldurs Gate 3\\Bin\\");
        }

        void xUnpackedFiles_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("UnpackedData\\");
        }

        void xReturn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        void xMinimizeProgram_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}