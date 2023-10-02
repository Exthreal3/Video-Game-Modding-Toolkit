using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace X3LToolBar
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigWindow()
        {
            InitializeComponent();
            // Load existing settings if needed
            // Example: txtBG3ModManagerPath.Text = Properties.Settings.Default.BG3ModManagerPath;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Save the selected file paths to application settings
            // Example: Properties.Settings.Default.BG3ModManagerPath = txtBG3ModManagerPath.Text;
            // ...

            // Save the settings
            // Example: Properties.Settings.Default.Save();

            // Close the settings window
            Close();
        }
        private void BrowseBG3ModManager_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
            openFileDialog.Title = "Select BG3ModManager Executable";

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path and set it to the TextBox
                txtBG3ModManagerPath.Text = openFileDialog.FileName;
            }
        }
        private void BrowseLSLib_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
            openFileDialog.Title = "Select LSLib Executable";

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path and set it to the TextBox
                txtLSLibPath.Text = openFileDialog.FileName;
            }
        }
        private void BrowseMultiTool_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
            openFileDialog.Title = "Select MultiTool Executable";

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path and set it to the TextBox
                txtMultiToolPath.Text = openFileDialog.FileName;
            }
        }
        private void BrowseMiniTool_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe|All Files|*.*";
            openFileDialog.Title = "Select MiniTool Executable";

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path and set it to the TextBox
                txtMiniToolPath.Text = openFileDialog.FileName;
            }
        }
        private void DownloadBG3ModManager_Click(object sender, RoutedEventArgs e)
        {
            // Show a confirmation dialog for downloading BG3ModManager
            bool installBG3ModManager = ShowInstallConfirmation("BG3ModManager");

            if (installBG3ModManager)
            {
                string downloadUrl = "https://github.com/LaughingLeader/BG3ModManager/releases/latest/download/BG3ModManager_Latest.zip";
                string downloadFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Downloads");
                string zipFilePath = System.IO.Path.Combine(downloadFolderPath, "BG3ModManager_Latest.zip");

                try
                {
                    // Create the download folder if it doesn't exist
                    Directory.CreateDirectory(downloadFolderPath);

                    // Download the ZIP file
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(downloadUrl, zipFilePath);

                    // Handle successful download
                    MessageBox.Show("BG3ModManager downloaded successfully.", "Download Complete", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    // Handle download error here
                    MessageBox.Show($"Error: {ex.Message}", "Download Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void BG3ModManager_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                // The download completed successfully
                MessageBox.Show("BG3ModManager downloaded successfully.", "Download Complete", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Handle download error here
                MessageBox.Show($"Error: {e.Error.Message}", "Download Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Re-enable the download button
            DownloadBG3ModManager.IsEnabled = true;
        }
        private void DownloadMultiTool_Click(object sender, RoutedEventArgs e)
        {
            // Show a confirmation dialog for downloading MultiTool
            bool installMultiTool = ShowInstallConfirmation("BG3 Modder's MultiTool");

            if (installMultiTool)
            {
                string downloadUrl = "https://github.com/ShinyHobo/BG3-Modders-MultiTool/releases/latest/download/BG3-Modders-MultiTool.zip";
                string downloadFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Downloads");
                string zipFilePath = System.IO.Path.Combine(downloadFolderPath, "BG3-Modders-MultiTool.zip");

                try
                {
                    // Create the download folder if it doesn't exist
                    Directory.CreateDirectory(downloadFolderPath);

                    // Download the ZIP file
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(downloadUrl, zipFilePath);

                    // Handle successful download
                    MessageBox.Show("BG3 Modder's MultiTool downloaded successfully.", "Download Complete", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    // Handle download error here
                    MessageBox.Show($"Error: {ex.Message}", "Download Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void MultiTool_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                // The download completed successfully
                MessageBox.Show("BG3 Modder's MultiTool downloaded successfully.", "Download Complete", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Handle download error here
                MessageBox.Show($"Error: {e.Error.Message}", "Download Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Re-enable the download button
            DownloadMultiTool.IsEnabled = true;
        }
        private bool ShowInstallConfirmation(string programName)
        {
            MessageBoxResult result = MessageBox.Show(
                $"Do you want to install {programName}?",
                "Software Installation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
            );

            return result == MessageBoxResult.Yes;
        }
    }
}