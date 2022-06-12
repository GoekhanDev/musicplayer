using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecodedMusicPlayer.Commands.TitleBarCommands
{
    public class MinimizeWindowCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            ((Window)parameter).WindowState = WindowState.Minimized;
        }
    }
}
