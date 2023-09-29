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

    public partial class ToolBarBackground : Window
    {
        public static class WindowsServices
        {
            const int WS_EX_TRANSPARENT = 0x00000020;
            const int GWL_EXSTYLE = (-20);

            [DllImport("user32.dll")]
            static extern int GetWindowLong(IntPtr hwnd, int index);

            [DllImport("user32.dll")]
            static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

            public static void SetWindowExTransparent(IntPtr hwnd)
            {
                var extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
            }
        }
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            var hwnd = new WindowInteropHelper(this).Handle;
            WindowsServices.SetWindowExTransparent(hwnd);
        }
        public ToolBarBackground()
        {
            InitializeComponent();
            new MaximizeButton();
        }

    }
}
