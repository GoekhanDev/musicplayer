using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using RecodedMusicPlayer.Stores;

namespace RecodedMusicPlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static MusicPlayer _musicplayer;
        
        public static NavigationStore _navigationStore;
       
        public static MainPageViewModel _mainPageViewModel;
        public static PlayerControlsViewModel _playerControlsViewModel;

        public App()
        {
            _musicplayer = new MusicPlayer();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            //Source https://stackoverflow.com/questions/13301053/directory-getfiles-of-certain-extension

            //Console.WriteLine(String.Join(", ", Directory.GetFiles(String.Format(@"C:\Users\{0}\Music", Environment.UserName))));

            List<string> musicFiles = Directory.GetFiles(String.Format(@"C:\Users\{0}\Music", Environment.UserName), "*.*", SearchOption.AllDirectories)
                  .Where(file => new string[] { ".aiff", ".asf", ".au", ".cda", ".mid", ".mp3", ".mp4", ".wav", ".wma" }
                  .Contains(Path.GetExtension(file)))
                  .ToList();

            int index = 0;

            foreach (var file in musicFiles) 
            {
                MusicFile song = new MusicFile(file, index++);

                if (song.duration.TotalSeconds != 0)
                {
                    _musicplayer.AddMusicToLibrary(song);
                }
            }


            PlayerControlsViewModel vm = new PlayerControlsViewModel(_musicplayer);
            vm.SetSongCommand.Execute(_musicplayer.GetMusicList().FirstOrDefault());
            _playerControlsViewModel = vm;
            
            vm.StopCommand.Execute(null);

            _navigationStore.CurrentViewModel = new MainPageViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_musicplayer, _navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
