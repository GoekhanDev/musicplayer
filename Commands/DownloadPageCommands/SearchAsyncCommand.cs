using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Models.Soundcloud;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands
{
    public class SearchAsyncCommand : CommandBase
    {
        private DownloaderViewModel _downloaderViewModel;

        public SearchAsyncCommand(DownloaderViewModel downloaderViewModel)
        {
            _downloaderViewModel = downloaderViewModel;
        }

        public override async void  Execute(object parameter)
        {
            try 
            {
                _downloaderViewModel.ListViewItemSource = null;
                _downloaderViewModel.NoSongText = "Searching Songs...";

                List<SoundCloudFile> songs = await Soudcloud.SearchMusic((string)parameter);
                _downloaderViewModel.ListViewItemSource = songs;
               
                if (_downloaderViewModel.ListViewItemSource.Count >= 1)
                    _downloaderViewModel.NoSongText = "";
                else
                    _downloaderViewModel.NoSongText = "No Songs Found";

            }
            catch (InvalidOperationException) 
            { 
                try
                {
                    if (!(_downloaderViewModel.ListViewItemSource.Count >= 1))
                        _downloaderViewModel.NoSongText = "No Songs Found";

                } catch (NullReferenceException) 
                {
                    _downloaderViewModel.ListViewItemSource = null;
                    _downloaderViewModel.NoSongText = "No Songs Found";
                }
            }

        }
    }
}
