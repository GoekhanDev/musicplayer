using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Stores;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands
{
    public class ListViewSelectMusicCommand : CommandBase
    {
        private MainPageViewModel _mainPageViewModel;
        private PlayerControlsViewModel playerVm;

        public ListViewSelectMusicCommand(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
            playerVm = App._playerControlsViewModel;
        }
        public override void Execute(object parameter)
        {
            playerVm.SetSongCommand.Execute(parameter);
            playerVm.PlayCommand.Execute(null);
        }
    }
}
