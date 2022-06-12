using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;

namespace RecodedMusicPlayer.Commands.SideMenuCommands
{
    public class DownloadPageCommand : CommandBase
    {
        private SideMenuViewModel _sideMenuViewModel;
        private MusicPlayer _musicPlayer;

        public DownloadPageCommand(SideMenuViewModel sideMenuViewModel, MusicPlayer musicplayer)
        {
            _sideMenuViewModel=sideMenuViewModel;
            _musicPlayer=musicplayer;
        }

        public override void Execute(object parameter)
        {
            App._navigationStore.CurrentViewModel = new DownloaderViewModel();

            _sideMenuViewModel.DownloadBTNOpacity = 1.0;
            _sideMenuViewModel.MainPageBTNOpacity = 0.2;
        }
    }
}
