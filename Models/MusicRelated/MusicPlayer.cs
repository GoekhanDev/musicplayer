using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Models
{
    public class MusicPlayer
    {
        private readonly MusicLibrary _musicLibrary;
        private readonly PlayerControls _playerControls;
        private readonly MusicControls _musicControls;

        public MusicPlayer()
        {
            _musicLibrary = new MusicLibrary();
            _musicControls = new MusicControls();
            _playerControls = new PlayerControls(_musicControls);

            _playerControls.currentSong = GetMusicList().FirstOrDefault();
        }

        //Music Library
        public List<MusicFile> GetMusicFileBySearch(string Title)
        {
            return _musicLibrary.GetMusicBySearch(Title);
        }

        public MusicFile GetMusicFileByIndex(int Index)
        {
            return _musicLibrary.GetMusicByIndex(Index);
        }
        
        public MusicFile GetMusicFileByTitle(string title)
        {
            return _musicLibrary.GetMusicByTitle(title);
        }

        public MusicFile GetMusicByRandom()
        {
            return _musicLibrary.GetRandomMusic();
        }

        public List<MusicFile> GetMusicList()
        {
            return _musicLibrary.GetMusicList();
        }

        public List<MusicFile> SortMusicByTitle()
        {
            return _musicLibrary.SortListByTitle();
        }

        public List<MusicFile> SortMusicByDuration()
        {
            return _musicLibrary.SortListByDuration();
        }

        public void AddMusicToLibrary(MusicFile file)
        {
            _musicLibrary.AddMusic(file);
        }

        public void DeleteMusicFromLibrary(MusicFile file)
        {
            _musicLibrary.DeleteMusic(file);
        }


        //Player controls
        public void playerSetSong(MusicFile file)
        {
            _playerControls.setSong(file);
        }

        public void playerPlay()
        {
            _playerControls.play();
        }

        public void playerPause()
        {
            _playerControls.pause();
        }

        public void playerStop()
        {
            _playerControls.stop();
        }

        public bool playerPlaying { 
            get => _playerControls.playing;
            set => _playerControls.playing = value;
        }

        public bool playerBackwarded
        {
            get => _playerControls.backWarded;
            set => _playerControls.backWarded = value;
        }

        public bool playerRepeat
        {
            get => _playerControls.repeat;
            set => _playerControls.repeat = value;

        }

        public MusicFile playerCurrentSong
        {
            get => _playerControls.currentSong;
            set => _playerControls.currentSong = value;
        }


        //MusicControls
        public void playerSetPosition(int positionVal)
        {
            _musicControls.setPosition(positionVal);
        }

        public void playerSetVolume(int volumeVal)
        {
            _musicControls.setVolume(volumeVal);
        }

        public string playerGetDuration()
        {
            return _musicControls.getDuration();
        }
        public double playerGetPosition()
        {
            return _musicControls.getPosition();
        }
    }
}
