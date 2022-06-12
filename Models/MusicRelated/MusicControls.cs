using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace RecodedMusicPlayer.Models
{
    public class MusicControls
    {
        private readonly WindowsMediaPlayer _musicControls;

        public MusicControls()
        {
            _musicControls = new WindowsMediaPlayer();
        }

        public void setSong(MusicFile file)
        {
            _musicControls.URL = file.filePath;
        }

        public void play()
        {
            _musicControls.controls.play();
        }

        public void pause()
        {
            _musicControls.controls.pause();
        }

        public void stop()
        {
            _musicControls.controls.stop();
        }

        public void setPosition(int positionVal)
        {
            _musicControls.controls.currentPosition = positionVal;
        }

        public void setVolume(int volumeVal)
        {
            _musicControls.settings.volume = volumeVal;
        }

        public string getDuration()
        {
            return _musicControls.currentMedia.durationString;
        }
        public double getPosition()
        {
            return _musicControls.controls.currentPosition;
        }
    }
}
