using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecodedMusicPlayer.Views
{
    /// <summary>
    /// Interaction logic for titleBarView.xaml
    /// </summary>
    public partial class titleBarView : UserControl
    {
        public titleBarView()
        {
            InitializeComponent();
            DataContext = new TitleBarViewModel();
        }

        Window window = Window.GetWindow(Application.Current.MainWindow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void WindowDrag(object sender, MouseButtonEventArgs e)
        {

            //Maximizes the Window on double click+ and vice versa
            if (e.ClickCount > 1)
            {

                if (window.WindowState == System.Windows.WindowState.Normal)
                    window.WindowState = WindowState.Maximized;

                else if (window.WindowState == System.Windows.WindowState.Maximized)
                    window.WindowState = WindowState.Normal;
            }

            window.DragMove();

            //Releasing the Window when maximized
            ReleaseCapture();
            SendMessage(new WindowInteropHelper(window).Handle,
                0xA1, (IntPtr)0x2, (IntPtr)0);
        }
    }
}
