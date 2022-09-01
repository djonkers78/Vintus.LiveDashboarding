using CefSharp;
using CefSharp.DevTools;
using CefSharp.Internals.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Vintus.LiveDashboarding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        private string _url = "https://app.powerbi.com/?tenant=&UPN=";
        private string _whatToRefresh = "javascript:jQuery(\"#exploration-container-app-bars\").hide();jQuery(\"#navBar\").hide();jQuery(\"#appNavPane\").hide();jQuery(\"#reportAppBarRefreshBtn\").click();";

        public MainWindow()
        {
            InitializeComponent();
            browser.Address = _url;
            timer.Tick += (sender, ef) =>
            {
                browser.Address = "javascript:";
                browser.Address = _whatToRefresh;
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                cmbSeconds.IsEnabled = true;
                btnRefresh.Content = "Auto Refresh";
                timer.Stop();
            }
            else
            {
                cmbSeconds.IsEnabled = false;
                timer.Interval = TimeSpan.FromSeconds(Convert.ToInt32(((ComboBoxItem)cmbSeconds.SelectedItem).Tag));
                btnRefresh.Content = "Stop running";
                browser.Address = "javascript:";
                browser.Address = _whatToRefresh;
                
                timer.Start();
            }
        }
    }
}

