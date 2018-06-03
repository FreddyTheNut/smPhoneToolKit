using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using smPhoneToolKit.ViewModels.Helper;
using smPhoneToolKit.Models;
using smPhoneToolKit.Logic;
using smPhoneToolKit.Models.Enums;
using smPhoneToolKit.ViewModels.Logic;

namespace smPhoneToolKit.ViewModels.Models
{
    public class SmartphoneDetailsViewModel : NotifyPropertyChanged
    {
        private readonly SmartphoneDetails smartphoneDetails = new SmartphoneDetails();
        private readonly SmartphoneDetailsLoader smartphoneDetailsLoader = new SmartphoneDetailsLoader();

        public void LoadSmartphoneDetails()
        {
            //General
            this.Manufacturer = this.smartphoneDetailsLoader.GetManufacturer();
            this.Brand = this.smartphoneDetailsLoader.GetBrand();
            this.Model = this.smartphoneDetailsLoader.GetModel();
            this.Device = this.smartphoneDetailsLoader.GetDevice();

            //Hardware
            this.CpuModel = this.smartphoneDetailsLoader.GetCpuModel();
            this.CpuISA = this.smartphoneDetailsLoader.GetCpuISA();
            this.Cores = this.smartphoneDetailsLoader.GetCores();
            this.Gpu = this.smartphoneDetailsLoader.GetGPU();
            this.Ram = this.smartphoneDetailsLoader.GetRam();

            //System
            this.AndroidVersoin = this.smartphoneDetailsLoader.GetAndroidVersion();
            this.ApiLevel = this.smartphoneDetailsLoader.GetApiLevel();
            this.BuildNumber = this.smartphoneDetailsLoader.GetBuildNumber();
            this.BuildFingerprint = this.smartphoneDetailsLoader.GetBuildFingerprint();
            this.BuildId = this.smartphoneDetailsLoader.GetBuildId();
            this.BuildDate = this.smartphoneDetailsLoader.GetBuildDate();
            this.SecurityPatch = this.smartphoneDetailsLoader.GetSecurityPatch();

            //Storage
            this.Memory = this.smartphoneDetailsLoader.GetMemory();

            //Display
            this.Resolution = this.smartphoneDetailsLoader.GetResolution();
            this.PixelDensity = this.smartphoneDetailsLoader.GetPixelDensity();
            this.Size = this.smartphoneDetailsLoader.GetSize();

            //Battery
            this.Technologie = this.smartphoneDetailsLoader.GetTechnologie();
            this.Capacity = this.smartphoneDetailsLoader.GetCapacity();

            //Others
            this.SerialNumber = this.smartphoneDetailsLoader.GetSerialNumber();
            this.HostName = this.smartphoneDetailsLoader.GetHostName();
            this.BluetoothName = this.smartphoneDetailsLoader.GetBluetoothName();

        }

        private SmartphoneDetails SmartphoneDetails
        {
            get { return this.smartphoneDetails; }
        }

        public string Manufacturer
        {
            get { return this.smartphoneDetails.Manufacturer; }
            set
            {
                if(this.Manufacturer != value)
                {
                    this.smartphoneDetails.Manufacturer = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Brand
        {
            get { return this.smartphoneDetails.Brand; }
            set
            {
                if (this.Brand != value)
                {
                    this.smartphoneDetails.Brand = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Model
        {
            get { return this.smartphoneDetails.Model; }
            set
            {
                if (this.Model != value)
                {
                    this.smartphoneDetails.Model = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Device
        {
            get { return this.smartphoneDetails.Device; }
            set
            {
                if (this.Device != value)
                {
                    this.smartphoneDetails.Device = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Soc
        {
            get { return this.smartphoneDetails.Soc; }
            set
            {
                if (this.Soc != value)
                {
                    this.smartphoneDetails.Soc = value;
                    OnPropertyChanged();
                }
            }
        }
        public string CpuModel
        {
            get { return this.smartphoneDetails.CpuModel; }
            set
            {
                if (this.CpuModel != value)
                {
                    this.smartphoneDetails.CpuModel = value;
                    OnPropertyChanged();
                }
            }
        }
        public string CpuISA
        {
            get { return this.smartphoneDetails.CpuISA; }
            set
            {
                if (this.CpuISA != value)
                {
                    this.smartphoneDetails.CpuISA = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Cores
        {
            get { return this.smartphoneDetails.Cores; }
            set
            {
                if (this.Cores != value)
                {
                    this.smartphoneDetails.Cores = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Gpu
        {
            get { return this.smartphoneDetails.Gpu; }
            set
            {
                if (this.Gpu != value)
                {
                    this.smartphoneDetails.Gpu = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Ram
        {
            get { return this.smartphoneDetails.Ram; }
            set
            {
                if (this.Ram != value)
                {
                    this.smartphoneDetails.Ram = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Os
        {
            get { return this.smartphoneDetails.Os; }
            set
            {
                if (this.Os != value)
                {
                    this.smartphoneDetails.Os = value;
                    OnPropertyChanged();
                }
            }
        }
        public string AndroidVersoin
        {
            get { return this.smartphoneDetails.AndroidVersoin; }
            set
            {
                if (this.AndroidVersoin != value)
                {
                    this.smartphoneDetails.AndroidVersoin = value;
                    OnPropertyChanged();
                }
            }
        }
        public string ApiLevel
        {
            get { return this.smartphoneDetails.ApiLevel; }
            set
            {
                if (this.ApiLevel != value)
                {
                    this.smartphoneDetails.ApiLevel = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BuildNumber
        {
            get { return this.smartphoneDetails.BuildNumber; }
            set
            {
                if (this.BuildNumber != value)
                {
                    this.smartphoneDetails.BuildNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BuildFingerprint
        {
            get { return this.smartphoneDetails.BuildFingerprint; }
            set
            {
                if (this.BuildFingerprint != value)
                {
                    this.smartphoneDetails.BuildFingerprint = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BuildId
        {
            get { return this.smartphoneDetails.BuildId; }
            set
            {
                if (this.BuildId != value)
                {
                    this.smartphoneDetails.BuildId = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BuildDate
        {
            get { return this.smartphoneDetails.BuildDate; }
            set
            {
                if (this.BuildDate != value)
                {
                    this.smartphoneDetails.BuildDate = value;
                    OnPropertyChanged();
                }
            }
        }
        public string SecurityPatch
        {
            get { return this.smartphoneDetails.SecurityPatch; }
            set
            {
                if (this.SecurityPatch != value)
                {
                    this.smartphoneDetails.SecurityPatch = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Memory
        {
            get { return this.smartphoneDetails.Memory; }
            set
            {
                if (this.Memory != value)
                {
                    this.smartphoneDetails.Memory = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Resolution
        {
            get { return this.smartphoneDetails.Resolution; }
            set
            {
                if (this.Resolution != value)
                {
                    this.smartphoneDetails.Resolution = value;
                    OnPropertyChanged();
                }
            }
        }
        public string PixelDensity
        {
            get { return this.smartphoneDetails.PixelDensity; }
            set
            {
                if (this.PixelDensity != value)
                {
                    this.smartphoneDetails.PixelDensity = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Size
        {
            get { return this.smartphoneDetails.Size; }
            set
            {
                if (this.Size != value)
                {
                    this.smartphoneDetails.Size = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Technologie
        {
            get { return this.smartphoneDetails.Technologie; }
            set
            {
                if (this.Technologie != value)
                {
                    this.smartphoneDetails.Technologie = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Capacity
        {
            get { return this.smartphoneDetails.Capacity; }
            set
            {
                if (this.Capacity != value)
                {
                    this.smartphoneDetails.Capacity = value;
                    OnPropertyChanged();
                }
            }
        }
        public string SerialNumber
        {
            get { return this.smartphoneDetails.SerialNumber; }
            set
            {
                if (this.SerialNumber != value)
                {
                    this.smartphoneDetails.SerialNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public string HostName
        {
            get { return this.smartphoneDetails.HostName; }
            set
            {
                if (this.HostName != value)
                {
                    this.smartphoneDetails.HostName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string BluetoothName
        {
            get { return this.smartphoneDetails.BluetoothName; }
            set
            {
                if (this.BluetoothName != value)
                {
                    this.smartphoneDetails.BluetoothName = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
