﻿namespace AssemblyWithBase.Simple
{
    using System.ComponentModel;

    public class BaseClassWithVirtualProperty : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual string Property1 { get; set; }

        public virtual void OnPropertyChanged(string text1)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(text1));
            }
        }
    }
}
