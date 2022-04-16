using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class AddImageCommand : CommandBase
    {
        private FactoryViewModel _viewModel { get; set; }

        private BitmapImage image = new();
        private string albumcover;

        public AddImageCommand(FactoryViewModel viewModel)
        {
            _viewModel = viewModel;
            
        }

        public override void Execute(object parameter)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Select Album Cover";


            //settings for the box
            dialog.Filter = "Image Files|*.jpg;*.png;*.svg;*.jpe;*.dib;*.tif;*.bmp;*.pcx";
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;

            // This displays the dialog + boolean for when its closed
            Nullable<bool> result = dialog.ShowDialog();

            if (result == true)
            { // here is the logic for the information transfer

                image = new BitmapImage(new Uri(dialog.FileName));
                albumcover = dialog.FileName;
                


                _viewModel._albumCover = albumcover;

                _viewModel.AlbumCover = image; // path of image

            }


        }
    }
}
