using smPhoneToolKit.ViewModels.Helper;
using smPhoneToolKit.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace smPhoneToolKit.ViewModels.Views
{
    public class MainWindowViewModel : NotifyPropertyChanged
    {
        #region Variables
        public PageViewModel[] Pages { get; protected set; } = { new PageViewModel("InfoPage", "InfoPage.xaml"), new PageViewModel("BackupPage", "BackupPage.xaml") };

        private int activePageIndex = 0;
        public int ActivePageIndex
        {
            get { return this.activePageIndex; }
            set
            {
                if (this.ActivePageIndex != value)
                {
                    this.activePageIndex = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(this.ActivePageSource));
                }
            }
        }

        public PageViewModel ActivePageSource
        {
            get { return this.Pages[this.ActivePageIndex]; }
        }
        #endregion Variables

        public MainWindowViewModel()
        {
        }
    }
}
