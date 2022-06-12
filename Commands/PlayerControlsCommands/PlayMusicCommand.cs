using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;

namespace RecodedMusicPlayer.Commands.PlayerControlsCommands
{
    public class PlayMusicCommand : CommandBase
    {
        private readonly MusicPlayer _musicplayer;
        private readonly PlayerControlsViewModel playerVm;

        public PlayMusicCommand(PlayerControlsViewModel playerControlsViewModel,MusicPlayer musicplayer)
        {
            _musicplayer=musicplayer;
            playerVm=playerControlsViewModel;
        }

        public override void Execute(object parameter)
        {

            if (!_musicplayer.playerPlaying)
            {
                _musicplayer.playerPlaying = true;
                playerVm.PlayBTNIcon = FontAwesome.WPF.FontAwesomeIcon.Pause;

                _musicplayer.playerPlay();

                playerVm.DurationUpdateCommand.Execute(null);
            }
            else if (_musicplayer.playerPlaying) playerVm.PauseCommand.Execute(null);
        }
    }
}
