using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using RecodedMusicPlayer.ViewModels;

namespace RecodedMusicPlayer.Views
{
    /// <summary>
    /// Interaction logic for sideMenu.xaml
    /// </summary>
    public partial class sideMenu : UserControl
    {
        public sideMenu()
        {
            InitializeComponent();
            DataContext = new SideMenuViewModel(App._musicplayer);
        }
    }
}
