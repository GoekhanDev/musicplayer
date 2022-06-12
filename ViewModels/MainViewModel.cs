using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Stores;

namespace RecodedMusicPlayer.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly MusicPlayer _musicPlayer;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(MusicPlayer musicplayer, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _musicPlayer = musicplayer;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
