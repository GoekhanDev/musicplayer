using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands.PlayerControlsCommands
{
    public class BackwardMusicCommand : CommandBase
    {
        private readonly MusicPlayer _musicplayer;
        private readonly PlayerControlsViewModel playerVm;

        public BackwardMusicCommand(PlayerControlsViewModel playerControlsViewModel, MusicPlayer musicplayer)
        {
            _musicplayer=musicplayer;
            playerVm=playerControlsViewModel;
        }

        public override void Execute(object parameter)
        {
            if (_musicplayer.playerPlaying && !_musicplayer.playerBackwarded)
            {
                playerVm.StopCommand.Execute(null);
                _musicplayer.playerBackwarded = true;

                playerVm.PlayCommand.Execute(null);
                
            }
            else if(_musicplayer.playerCurrentSong != _musicplayer.GetMusicList().FirstOrDefault())
            {
                playerVm.StopCommand.Execute(null);
                MusicFile PreviousSong = _musicplayer.GetMusicFileByIndex(_musicplayer.playerCurrentSong.index - 1);

                playerVm.SetSongCommand.Execute(PreviousSong);
                playerVm.PlayCommand.Execute(null);
            }
            else
            {
                playerVm.StopCommand.Execute(null);
                MusicFile LastSong = _musicplayer.GetMusicFileByIndex(_musicplayer.GetMusicList().Count - 1);

                playerVm.SetSongCommand.Execute(LastSong);
                playerVm.PlayCommand.Execute(null);
            }

            playerVm.DurationSlider = 0;
        }
    }
}
