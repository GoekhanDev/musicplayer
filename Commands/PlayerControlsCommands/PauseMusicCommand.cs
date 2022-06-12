using FontAwesome.WPF;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands.PlayerControlsCommands
{
    public class PauseMusicCommand : CommandBase
    {
        private readonly MusicPlayer _musicplayer;
        private readonly PlayerControlsViewModel playerVm;

        public PauseMusicCommand(PlayerControlsViewModel playerControlsViewModel, MusicPlayer musicplayer)
        {
            _musicplayer=musicplayer;
            playerVm=playerControlsViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            return _musicplayer.playerPlaying;
        }

        public override void Execute(object parameter)
        {
            _musicplayer.playerPlaying = false;
            playerVm.PlayBTNIcon = FontAwesomeIcon.Play;

            _musicplayer.playerPause();
        }
    }
}
