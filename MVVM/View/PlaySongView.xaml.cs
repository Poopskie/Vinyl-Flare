using System.Windows;
using System.Windows.Controls;

namespace Vinyl_Flare.MVVM.View
{
    /// <summary>
    /// Interaction logic for PlaySongView.xaml
    /// </summary>
    public partial class PlaySongView : UserControl
    {
        public PlaySongView()
        {
            InitializeComponent();
        }

        private void Pause_Button(object sender, RoutedEventArgs e)
        {

        }
        private void Play_Button(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
         //   volumeChange((double)volumeSlider.Value);

        }
    }
}
