using FontAwesome.WPF;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
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
using RecodedMusicPlayer;
using System.Windows.Controls.Primitives;

namespace RecodedMusicPlayer.Views
{
    /// <summary>
    /// Interaction logic for playerMenu.xaml
    /// </summary>
    public partial class playerMenu : UserControl
    {

        public playerMenu()
        {
            InitializeComponent();

            DataContext = App._playerControlsViewModel;
        }

        private void volumeSlider_MouseEnter(object sender, MouseEventArgs e)
        {
            volumeSlider.Visibility = Visibility.Visible;
        }

        private void volumeSlider_MouseLeave(object sender, MouseEventArgs e)
        {
            volumeSlider.Visibility = Visibility.Collapsed;
        }

        private void VolumeValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (volumeSlider.Value == 0)
            {
                volumeIcon.Icon = FontAwesomeIcon.VolumeOff;
                volumeIcon.Width = 8;
            }
            else if (volumeSlider.Value < 50)
            {
                volumeIcon.Icon = FontAwesomeIcon.VolumeDown;
                volumeIcon.Width = 12;
            }
            else if (volumeSlider.Value > 50)
            {
                volumeIcon.Icon = FontAwesomeIcon.VolumeUp;
                volumeIcon.Width = 13;
            }
        }
    }
}
