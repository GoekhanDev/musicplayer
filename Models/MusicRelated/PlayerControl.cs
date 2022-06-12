using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace RecodedMusicPlayer.Models
{
    public class PlayerControls
    {
        private readonly WindowsMediaPlayer _playerControls;
        private readonly MusicControls _musicControls;

        public bool playing { get; set; } = false;
        public bool repeat { get; set; } = false;
        public bool backWarded { get; set; } = true;
        public MusicFile currentSong { get; set; }

        public PlayerControls(MusicControls musicControls)
        {
            _playerControls = new WindowsMediaPlayer();
            _musicControls = musicControls;
        }

        public void setSong(MusicFile song)
        {
            _musicControls.setSong(song);
        }

        public void play()
        {
            _musicControls.play();
        }

        public void pause()
        {
            _musicControls.pause();
        }

        public void stop()
        {
            _musicControls.stop();
        }
    }
}
