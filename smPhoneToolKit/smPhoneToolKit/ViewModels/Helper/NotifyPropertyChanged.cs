﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.ViewModels.Helper
{
    public abstract class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string callerName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
        }
    }
}
