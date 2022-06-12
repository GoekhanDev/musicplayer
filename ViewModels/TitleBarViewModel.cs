using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RecodedMusicPlayer.Commands.TitleBarCommands;

namespace RecodedMusicPlayer.ViewModels
{
    public class TitleBarViewModel : ViewModelBase
    {
        public ICommand CloseWindowCommand { get; }
        public ICommand MinimizeWindowCommand { get; }
        public ICommand MaximizeWindowCommand { get; }

        public TitleBarViewModel()
        {
            CloseWindowCommand = new CloseWindowCommand();
            MinimizeWindowCommand = new MinimizeWindowCommand();
            MaximizeWindowCommand = new MaximizeWindowCommand();
        }
    }
}
