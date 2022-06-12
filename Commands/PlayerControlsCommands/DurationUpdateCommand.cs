using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace RecodedMusicPlayer.Commands.PlayerControlsCommands
{
    public class DurationUpdateCommand : CommandBase
    {
        private readonly MusicPlayer _musicplayer;
        private readonly PlayerControlsViewModel playerVm;

        public DurationUpdateCommand(PlayerControlsViewModel playerControlsViewModel, MusicPlayer musicplayer)
        {
            _musicplayer=musicplayer;
            playerVm=playerControlsViewModel;
        }

        public override void Execute(object parameter)
        {

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += UpdateDurationSlider;
            timer.Start();

        }

        private void UpdateDurationSlider(object sender, EventArgs e)
        {
            playerVm.DurationChangedBySystem = true;
            playerVm.DurationSlider = _musicplayer.playerGetPosition();
            playerVm.DurationChangedBySystem = false;

            if ((int)_musicplayer.playerGetPosition() == (int)_musicplayer.playerCurrentSong.durationTotalSeconds)
                playerVm.ForwardCommand.Execute(null);
        }
   
    }
}
