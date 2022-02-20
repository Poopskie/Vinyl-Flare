using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Vinyl_Flare.Core
{
    internal class Observable_Object : INotifyPropertyChanged // No clue what this does rn
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
