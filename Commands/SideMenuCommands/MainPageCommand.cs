using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecodedMusicPlayer.ViewModels;
using System.Windows.Controls;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Stores;

namespace RecodedMusicPlayer.Commands.SideMenuCommands
{
    public class MainPageCommand : CommandBase
    {
        private SideMenuViewModel _sideMenuViewModel;
        private PlayerControlsViewModel _playerControlsViewModel;
        
        private MusicPlayer _musicPlayer;


        public MainPageCommand(SideMenuViewModel sideMenuViewModel,  MusicPlayer musicplayer)
        {
            _sideMenuViewModel=sideMenuViewModel;
            _playerControlsViewModel= App._playerControlsViewModel;
            _musicPlayer=musicplayer;
        }

        public override void Execute(object parameter)
        {
            App._navigationStore.CurrentViewModel = new MainPageViewModel();
            
            _sideMenuViewModel.MainPageBTNOpacity = 1.0;
            _sideMenuViewModel.DownloadBTNOpacity = 0.2;
        }
    }
}
