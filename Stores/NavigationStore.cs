using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentviewmodel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentviewmodel;
            set
            {
                _currentviewmodel = value;
                OnCurrentViewModelChanged();
         
            } 
        }

        public event Action CurrentViewModelChanged;

        public void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
