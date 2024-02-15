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
using System.Windows.Interop;
using System.Net;
using System.IO.Compression;

namespace X3LToolBar
{
    public partial class BG3Tools : Window
    {
    private string steamLibraryPath;

        public BG3Tools()
        {
            InitializeComponent();
            // Check if the Baldur's Gate 3 path has been set in application settings
            if (string.IsNullOrEmpty(Properties.Settings.Default.SteamLibraryPath))
            {
                // The path has not been set, prompt the user to select it
                ShowSteamLibraryLocationDialog();
            }
            else
            {
                // The path has been previously set, retrieve it
                steamLibraryPath = Properties.Settings.Default.SteamLibraryPath;
            }
        }

        void xCloseProgram_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

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
            string publicFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Larian Studios\\Baldur's Gate 3\\PlayerProfiles\\Public");
            Process.Start(publicFolderPath);
        }
            void xMods_Click(object sender, RoutedEventArgs e)
        {
            string modsFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Larian Studios\\Baldur's Gate 3\\Mods");
            Process.Start(modsFolderPath);
        }
        private void ShowSteamLibraryLocationDialog()
        {
            // Create and configure the FolderBrowserDialog
            System.Windows.Forms.FolderBrowserDialog folderDialog = new System.Windows.Forms.FolderBrowserDialog
            {
                Description = "Select your Baldur's Gate 3 folder",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = false,
            };

            // Show the dialog and get the result
            System.Windows.Forms.DialogResult result = folderDialog.ShowDialog();

            // Check if the user selected a folder
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                // Save the selected path to application settings
                steamLibraryPath = folderDialog.SelectedPath;
                Properties.Settings.Default.SteamLibraryPath = steamLibraryPath;
                Properties.Settings.Default.Save();
            }
        }

        private void xGameData_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(steamLibraryPath))
            {
                // Access the "data" folder within the Baldur's Gate 3 path
                string dataFolderPath = Path.Combine(steamLibraryPath, "data");

                // Check if the "data" folder exists
                if (Directory.Exists(dataFolderPath))
                {
                    // Perform your action related to the "xGameData" button here using the data folder
                    Process.Start(dataFolderPath);
                }
                else
                {
                    MessageBox.Show("The 'data' folder does not exist in the selected Baldur's Gate 3 location.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    ShowSteamLibraryLocationDialog(); // Allow the user to reselect the folder
                }
            }
            else
            {
                // Prompt the user to select the Baldur's Gate 3 path if it's not set
                ShowSteamLibraryLocationDialog();
            }
        }

        private void xGameBin_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(steamLibraryPath))
            {
                // Access the "bin" folder within the Baldur's Gate 3 path
                string binFolderPath = Path.Combine(steamLibraryPath, "bin");

                // Check if the "bin" folder exists
                if (Directory.Exists(binFolderPath))
                {
                    // Perform your action related to the "xGameBin" button here using the bin folder
                    Process.Start(binFolderPath);
                }
                else
                {
                    MessageBox.Show("The 'bin' folder does not exist in the selected Baldur's Gate 3 location.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    ShowSteamLibraryLocationDialog(); // Allow the user to reselect the folder
                }
            }
            else
            {
                // Prompt the user to select the Baldur's Gate 3 path if it's not set
                ShowSteamLibraryLocationDialog();
            }
        }

        private void xChangeLibrary_Click(object sender, RoutedEventArgs e)
        {
            // Allow the user to change the Baldur's Gate 3 location
            ShowSteamLibraryLocationDialog();
        }
    
        void xUnpackedFiles_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("UnpackedData\\");
        }

        void xMinimizeProgram_Click(object sender, RoutedEventArgs e)
        {
            ToolBar toolBar = new ToolBar();
            toolBar.Show();
            this.Close();
        }

    }

}