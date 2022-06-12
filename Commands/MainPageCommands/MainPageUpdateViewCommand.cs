using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands
{
    public class MainPageUpdateViewCommand : CommandBase
    {
        private MainPageViewModel _mainPageViewModel;

        public MainPageUpdateViewCommand(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
        }
        public override void Execute(object parameter)
        {
            MusicFile song = ((MusicFile)parameter);

            _mainPageViewModel.AlbumCoverImage = song.cover;
            _mainPageViewModel.SongTitle = song.title;
            _mainPageViewModel.Artists = song.artistsJoined;
        }
    }
}
