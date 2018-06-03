using smPhoneToolKit.Logic;
using smPhoneToolKit.Models;
using smPhoneToolKit.Models.Enums;
using smPhoneToolKit.ViewModels.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.ViewModels.Models
{
    public class SmartphoneViewModel : NotifyPropertyChanged
    {
        private readonly Smartphone smartphone = new Smartphone();
        public SmartphoneDetailsViewModel SmartphoneDetails { get; } = new SmartphoneDetailsViewModel();

        public SmartphoneViewModel()
        {
            this.SmartphoneDetails.LoadSmartphoneDetails();
        }

        public string Bezeichnung
        {
            get { return this.smartphone.Bezeichnung; }
            set
            {
                if (this.Bezeichnung != value)
                {
                    this.smartphone.Bezeichnung = value;
                    OnPropertyChanged();
                }
            }
        }
        public Status Status
        {
            get { return this.smartphone.Status; }
            set
            {
                if (this.Status != value)
                {
                    this.smartphone.Status = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
