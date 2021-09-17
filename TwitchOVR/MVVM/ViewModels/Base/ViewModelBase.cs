using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TwitchOVR.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            if (handler is null) return;
            var e = new PropertyChangedEventArgs(propertyName);
            handler(this, e);
        }

        private void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] is not null) return;
            var msg = $"Invalid property name: {propertyName}";
            throw new Exception(msg);
        }
    }
}