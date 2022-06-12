using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands.PlayerControlsCommands
{
    public class ForwardMusicCommand : CommandBase
    {
        private readonly MusicPlayer _musicplayer;
        private readonly PlayerControlsViewModel playerVm;

        public ForwardMusicCommand(PlayerControlsViewModel playerControlsViewModel, MusicPlayer musicplayer)
        {
            _musicplayer=musicplayer;
            playerVm=playerControlsViewModel;
        }
        public override void Execute(object parameter)
        {
            playerVm.StopCommand.Execute(null);

            if (_musicplayer.playerCurrentSong != _musicplayer.GetMusicList().LastOrDefault())
            {
                _musicplayer.playerBackwarded = false;
                MusicFile nextSong = _musicplayer.GetMusicFileByIndex(_musicplayer.playerCurrentSong.index + 1);
                playerVm.SetSongCommand.Execute(nextSong);
            }
            else 
            { 
                MusicFile FirstSong = _musicplayer.GetMusicList().FirstOrDefault();
                playerVm.SetSongCommand.Execute(FirstSong);
            }
            
            playerVm.PlayCommand.Execute(null);
        }
    }
}
