using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    /// Interaction logic for MainPageView.xaml
    /// </summary>
    public partial class MainPageView : UserControl
    {
        private static MainPageViewModel vm;

        private bool DurationSorted { get; set; }
        private bool TitleSorted { get; set; }

        public MainPageView()
        {
            InitializeComponent();
            vm = new MainPageViewModel();
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
            if (ListMain.SelectedItem != null)
                vm.ListViewSelectMusicCommand.Execute(ListMain.SelectedItem);
        }

        void ResetScroll(ListView ResetList)
        {
            (((VisualTreeHelper.GetChild(ResetList, 0) as Border).Child) as ScrollViewer).ScrollToVerticalOffset(0);
        }

        void ResetColumnsAndList()
        {
            foreach (TextBlock tb in new TextBlock[] { TitleColumnText, DurationColumnText})
                tb.Foreground = Brushes.White;

            vm.ListViewItemSource = App._musicplayer.GetMusicList();

            ResetScroll(ListMain);
        }

        private void SortByTitle(object sender, MouseButtonEventArgs e)
        {
            ResetColumnsAndList(); DurationSorted = false;

            if (!TitleSorted)
            {
                TitleColumnText.Foreground = (Brush)new BrushConverter().ConvertFrom("#675ef7"); ;
                vm.ListViewItemSource = App._musicplayer.SortMusicByTitle();

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
                vm.ListViewItemSource = App._musicplayer.SortMusicByDuration();

                DurationSorted = true;
            }
            else
            {
                ResetColumnsAndList();
                DurationSorted = false;
            }

            ResetScroll(ListMain);
        }
    }
}
