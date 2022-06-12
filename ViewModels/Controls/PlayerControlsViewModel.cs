using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FontAwesome.WPF;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Commands.PlayerControlsCommands;
using RecodedMusicPlayer.Commands;
using RecodedMusicPlayer.ViewModels;
using System.Windows.Media.Imaging;
using RecodedMusicPlayer.Stores;

namespace RecodedMusicPlayer.ViewModels
{
    public class PlayerControlsViewModel : ViewModelBase
    {

        public static MusicPlayer _musicPlayer;
        
        private bool _durationChangedBySystem = false;
        public  bool DurationChangedBySystem
        {
            get
            {
                return _durationChangedBySystem;
            }
            set
            {
                _durationChangedBySystem = value;
                OnPropertyChanged(nameof(DurationChangedBySystem));
            }
        }

        //Main Stuff

        private double _volumeslider = 20;
        public double VolumeSlider
        {
            get
            {
                return _volumeslider;
            }
            set
            {
                _volumeslider = value;
                _musicPlayer.playerSetVolume((int)value);
                OnPropertyChanged(nameof(VolumeSlider));
            }
        }

        private FontAwesomeIcon _playBTNIcon = FontAwesomeIcon.Play;
        public FontAwesomeIcon PlayBTNIcon
        {
            get
            {
                return _playBTNIcon;
            }
            set
            {
                _playBTNIcon = value;
                OnPropertyChanged(nameof(PlayBTNIcon));
            }
        }

        private string _artistTitleText = "Artist";
        public string ArtistTitleText
        {
            get
            {
                return _artistTitleText;
            }
            set
            {
                _artistTitleText = value;
                OnPropertyChanged(nameof(ArtistTitleText));
            }
        }

        private string _songTitleText = "Song Title";
        public string SongTitleText
        {
            get
            {
                return _songTitleText;
            }
            set
            {
                _songTitleText = value;
                OnPropertyChanged(nameof(SongTitleText));
            }
        }

        private BitmapImage _albumCoverImage;
        public BitmapImage AlbumCoverImage
        {
            get
            {
                return _albumCoverImage;
            }
            set
            {
                _albumCoverImage = value;
                OnPropertyChanged(nameof(AlbumCoverImage));
            }
        }

        //Duration Stuff

        private double _durationslider;
        public double DurationSlider
        {
            get
            {
                return _durationslider;
            }
            set
            {
                _durationslider = value;
                
                if (value == DurationSliderMaxValue)
                {
                    ForwardCommand.Execute(null);

                }
                else
                {
                    if (!DurationChangedBySystem) 
                        _musicPlayer.playerSetPosition((int)value);
            
                    TimeSpan timespan = TimeSpan.FromSeconds((int)_musicPlayer.playerGetPosition());

                    SongCurrentDuration = string.Format("{0}:{1:00}",
                            timespan.Minutes, timespan.Seconds);
                } 

                OnPropertyChanged(nameof(DurationSlider));
            }
        }

        private string _songCurrentDuration = "0:00";
        public string SongCurrentDuration
        {
            get
            {
                return _songCurrentDuration;
            }
            set
            {
                _songCurrentDuration = value;
                OnPropertyChanged(nameof(SongCurrentDuration));
            }
        }

        private string _songSongDuration = "0:00";
        public string SongDuration
        {
            get
            {
                return _songSongDuration;
            }
            set
            {
                _songSongDuration = value;
                OnPropertyChanged(nameof(SongDuration));
            }
        }

        private double _durationSliderMaxValue;
        public double DurationSliderMaxValue
        {
            get
            {
                return _durationSliderMaxValue;
            }
            set
            {
                _durationSliderMaxValue = value;
                OnPropertyChanged(nameof(DurationSliderMaxValue));
            }
        }

        public ICommand SetSongCommand { get; }

        public ICommand PlayCommand { get; }
        public ICommand PauseCommand { get; }
        public ICommand StopCommand { get; }
        
        public ICommand BackwardCommand { get; }
        public ICommand ForwardCommand { get; }

        public ICommand DurationUpdateCommand { get; }

    public PlayerControlsViewModel(MusicPlayer musicplayer)
        {
            _musicPlayer = musicplayer;

            SetSongCommand = new SetMusicCommand(this, musicplayer);
            
            PlayCommand = new PlayMusicCommand(this, musicplayer);
            PauseCommand = new PauseMusicCommand(this, musicplayer);
            StopCommand = new StopMusicCommand(this, musicplayer);
            
            BackwardCommand = new BackwardMusicCommand(this, musicplayer);
            ForwardCommand = new ForwardMusicCommand(this, musicplayer);

            DurationUpdateCommand = new DurationUpdateCommand(this, musicplayer);
        }
    }
}
