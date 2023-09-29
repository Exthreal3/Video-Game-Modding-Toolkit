using System;
using System.Windows;

namespace X3LToolBar
{
    public partial class App : Application
    {
    public App()
        {
            InitializeComponent();
            var timer = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Start();
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                var page = new ToolBar();
                page.Show();
            };
        }
    }
}
