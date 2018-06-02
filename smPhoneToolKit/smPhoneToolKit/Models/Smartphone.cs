using smPhoneToolKit.Models.Enums;
using smPhoneToolKit.ViewModels.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Models
{
    public class Smartphone : NotifyPropertyChanged
    {
        private string bezeichnung;
        private Status status;

        public string Bezeichnung
        {
            get { return this.bezeichnung; }
            set
            {
                if(this.Bezeichnung != value)
                {
                    this.bezeichnung = value;
                    OnPropertyChanged();
                }
            }     
        }

        public Status Status
        {
            get { return this.status; }
            set
            {
                if(this.Status != value)
                {
                    this.status = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
