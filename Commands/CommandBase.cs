using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RecodedMusicPlayer.Commands.TitleBarCommands;

namespace RecodedMusicPlayer.Commands
{
    public abstract class CommandBase : ICommand
    {
        //Source https://youtu.be/DNez3wIpHeE?t=148

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);

        protected void OnCanExceutedChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
