using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using RecodedMusicPlayer.Commands.SideMenuCommands;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Stores;

namespace RecodedMusicPlayer.ViewModels
{
    public class SideMenuViewModel : ViewModelBase
    {

        private double _downloadBTNOpacity;
        public double DownloadBTNOpacity
        {
            get
            {
                return _downloadBTNOpacity;
            }
            set
            {
                _downloadBTNOpacity = value;
                OnPropertyChanged(nameof(DownloadBTNOpacity));
            }
        }

        private double _mainPageBTNOpacity;
        public double MainPageBTNOpacity
        {
            get
            {
                return _mainPageBTNOpacity;
            }
            set
            {
                _mainPageBTNOpacity = value;
                OnPropertyChanged(nameof(MainPageBTNOpacity));
            }
        }

        public ICommand MainPageCommand { get; }
        public ICommand DownloaderCommand { get; }

        public SideMenuViewModel(MusicPlayer musicplayer)
        {
            DownloadBTNOpacity = 0.2;
            MainPageBTNOpacity = 1.0;

            MainPageCommand = new MainPageCommand(this, musicplayer);
            DownloaderCommand = new DownloadPageCommand(this, musicplayer);
        }
    }
}
