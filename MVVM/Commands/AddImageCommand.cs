using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class AddImageCommand : CommandBase
    {
        private FactoryViewModel _viewModel;

        public AddImageCommand(FactoryViewModel viewModel)
        {
            _viewModel = viewModel;
            // CURRENT PROBLEM: might not edit array in view model, but just the clone of it
        }

        public override void Execute(object parameter)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Select Album Cover";

            // This supposidly creates the dialog
            Nullable<bool> result = dialog.ShowDialog();

            //settings for the box
            dialog.Filter = "Image Files|*.jpg;*.png;*.svg;*.jpe;*.dib;*.tif;*.bmp;*.pcx";
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;

            if (result == true)
            { // here is the logic for the information transfer

                _viewModel.AlbumCover = dialog.FileName; // path of image

            }


        }
    }
}
