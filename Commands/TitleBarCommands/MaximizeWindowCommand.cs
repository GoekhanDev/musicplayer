using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RecodedMusicPlayer.Commands.TitleBarCommands
{
    public class MaximizeWindowCommand : CommandBase
    {
        public override void Execute(object parameter)
        {

            Window window = (Window)parameter;

            if (window.WindowState == WindowState.Normal)
                window.WindowState = WindowState.Maximized;

            else if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
        }
    }
}
