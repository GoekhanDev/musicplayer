using RecodedMusicPlayer.Models.Soundcloud;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecodedMusicPlayer.Views
{
    /// <summary>
    /// Interaction logic for DownloaderView.xaml
    /// </summary>
    public partial class DownloaderView : UserControl
    {
        private static DownloaderViewModel vm;
        private bool DurationSorted { get; set; }
        private bool TitleSorted { get; set; }
        public DownloaderView()
        {
            InitializeComponent();
            vm = new DownloaderViewModel();
            DataContext = vm;
            App._navigationStore.CurrentViewModel = vm;
        }

        //Source: https://stackoverflow.com/a/6972726
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            
            if (tb.Text == string.Empty)
            {
                tb.Text = "Search Music";
                tb.GotFocus += TextBox_GotFocus;
            }
        }

        private void ListMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }

        void ResetScroll(ListView ResetList)
        {
            (((VisualTreeHelper.GetChild(ResetList, 0) as Border).Child) as ScrollViewer).ScrollToVerticalOffset(0);
        }

        void ResetColumnsAndList()
        {
            foreach (TextBlock tb in new TextBlock[] { TitleColumnText, DurationColumnText })
                tb.Foreground = Brushes.White;

     

            ResetScroll(ListMain);
        }

        private void SortByTitle(object sender, MouseButtonEventArgs e)
        {
            ResetColumnsAndList(); DurationSorted = false;

            if (!TitleSorted)
            {
                TitleColumnText.Foreground = (Brush)new BrushConverter().ConvertFrom("#675ef7"); ;
               

                TitleSorted = true;
            }
            else
            {
                ResetColumnsAndList();
                TitleSorted = false;
            }

            ResetScroll(ListMain);
        }

        private void SortByDuration(object sender, MouseButtonEventArgs e)
        {
            ResetColumnsAndList(); TitleSorted = false;

            if (!DurationSorted)
            {
                DurationColumnText.Foreground = (Brush)new BrushConverter().ConvertFrom("#675ef7");
          

                DurationSorted = true;
            }
            else
            {
                ResetColumnsAndList();
                DurationSorted = false;
            }

            ResetScroll(ListMain);
        }

        private void DockPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock tb = (TextBlock)((DockPanel)sender).Tag;

            if (tb.Text != "Downloaded" && tb != null)
                tb.Text = "Click To Download";
        }

        private void DockPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tb = (TextBlock)((DockPanel)sender).Tag;
            
            if (tb.Text != "Downloaded" && tb != null)
                tb.SetBinding(TextBlock.TextProperty, new Binding("durationString"));
        }

        private void Duration_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            SoundCloudFile song = ((SoundCloudFile)ListMain.SelectedItem);

            if (ListMain.SelectedItem != null && tb != null && tb.Text != "Downloaded") {

                vm.DownloadMusicCommand.Execute(ListMain.SelectedItem);
        
                tb.Foreground = Brushes.Green;
                tb.Text = "Downloaded";
            }
        }

        private void Duration_MouseEnter(object sender, MouseEventArgs e)
        {

            TextBlock tb = (TextBlock)sender;

            if (tb.Text != "Downloaded" && tb != null)
                tb.Foreground = (Brush)new BrushConverter().ConvertFrom("#675ef7");
            
        }

        private void Duration_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            
            if (tb.Text != "Downloaded" && tb != null)
                tb.Foreground = Brushes.Gray;
            
        }
    }
}
