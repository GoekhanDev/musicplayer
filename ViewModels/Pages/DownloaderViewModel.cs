using RecodedMusicPlayer.Commands;
using RecodedMusicPlayer.Commands.DownloadPageCommands;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Models.Soundcloud;
using RecodedMusicPlayer.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecodedMusicPlayer.ViewModels
{
    public class DownloaderViewModel : ViewModelBase
    {
        public DownloaderViewModel()
        {
            SearchAsyncCommand = new SearchAsyncCommand(this);
            DownloadMusicCommand = new DownloadMusicCommand(this);
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
                    SearchAsyncCommand.Execute(value);
                }
                else
                {
                    ListViewItemSource = null;
                    NoSongText = "Search shows results from SoundCloud";
                }

                OnPropertyChanged(nameof(ListViewSearch));
            }
        }

        private List<SoundCloudFile> _listViewItemSource = new List<SoundCloudFile>();
        public List<SoundCloudFile> ListViewItemSource
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

        private string _noSongText = "Search shows results from SoundCloud";
        public string NoSongText
        {
            get
            {
                return _noSongText;
            }
            set
            {
                _noSongText = value;
                OnPropertyChanged(nameof(NoSongText));
            }
        }

        public ICommand SearchAsyncCommand { get; }
        public ICommand DownloadMusicCommand { get; }
    }
}
