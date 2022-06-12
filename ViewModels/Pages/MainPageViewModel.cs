using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RecodedMusicPlayer.Commands;
using RecodedMusicPlayer.Stores;
using RecodedMusicPlayer.Models;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace RecodedMusicPlayer.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //Source: https://youtu.be/7K0lvy9iJso?t=1055
        public static List<MusicFile> Songs { get; set; }
        
        private PlayerControlsViewModel _playerControlsViewModel;
        public MainPageViewModel()
        {
            _playerControlsViewModel = App._playerControlsViewModel;
            Songs = App._musicplayer.GetMusicList();

            AlbumCoverImage = _playerControlsViewModel.AlbumCoverImage;
            SongTitle =_playerControlsViewModel.SongTitleText;
            Artists = _playerControlsViewModel.ArtistTitleText;

            ListViewSelectMusicCommand = new ListViewSelectMusicCommand(this);
            MainPageUpdateViewCommand = new MainPageUpdateViewCommand(this);
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

        private List<MusicFile> _listViewItemSource = Songs;
        public List<MusicFile> ListViewItemSource
        {
            get 
            { 
                return _listViewItemSource; 
            }
            set 
            { 
                _listViewItemSource = value; 
                OnPropertyChanged(nameof(ListViewItemSource)); 
            }
        }

        private string _listViewSearch = "Search Text";
        public string ListViewSearch
        {
            get
            {
                return _listViewSearch;
            }
            set
            {   
                _listViewSearch = value;

                if (!(String.IsNullOrEmpty(value) || value == "Search Music"))
                {
                    ListViewItemSource = App._musicplayer.GetMusicFileBySearch(value.ToLower());
                }
                else ListViewItemSource = App._musicplayer.GetMusicList();

                OnPropertyChanged(nameof(ListViewSearch));
            }
        }

        private string _songtitle;
        public string SongTitle
        {
            get
            {
                return _songtitle;
            }
            set
            {
                _songtitle = value;
                OnPropertyChanged(nameof(SongTitle));
            }
        }

        private string _artits;
        public string Artists
        {
            get
            {
                return _artits;
            }
            set
            {
                _artits = value;
                OnPropertyChanged(nameof(Artists));
            }
        }

        private string _songcount;
        public string SongCount
        {
            get
            {
                return Songs.Count.ToString() + " Songs";
            }
            set
            {
                _songcount = value;
                OnPropertyChanged(nameof(SongCount));
            }
        }

        public ICommand ListViewSelectMusicCommand { get; }
        public ICommand MainPageUpdateViewCommand { get; }
    }
}
