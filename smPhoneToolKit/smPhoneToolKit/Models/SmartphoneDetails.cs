using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Models
{
    public class SmartphoneDetails
    {
        //General
        string manufacturer;
        string brand;
        string model;
        string device;
        //Hardware          
        string soc;
        string cpuModel;
        string cpuISA;
        string cores;
        string gpu;
        string ram;
        //System
        string os;
        string androidVersoin;
        string apiLevel;
        string buildNumber;
        string buildFingerprint;
        string buildId;
        string buildDate;
        string securityPatch;
        //Storage
        string memory;
        //Display
        string resolution;
        string pixelDensity;
        string size;
        //Battery 
        string technologie;
        string capacity;
        //Others    
        string serialNumber;
        string hostName;
        string bluetoothName;

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Device { get => device; set => device = value; }
        public string Soc { get => soc; set => soc = value; }
        public string CpuModel { get => cpuModel; set => cpuModel = value; }
        public string CpuISA { get => cpuISA; set => cpuISA = value; }
        public string Cores { get => cores; set => cores = value; }
        public string Gpu { get => gpu; set => gpu = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Os { get => os; set => os = value; }
        public string AndroidVersoin { get => androidVersoin; set => androidVersoin = value; }
        public string ApiLevel { get => apiLevel; set => apiLevel = value; }
        public string BuildNumber { get => buildNumber; set => buildNumber = value; }
        public string BuildFingerprint { get => buildFingerprint; set => buildFingerprint = value; }
        public string BuildId { get => buildId; set => buildId = value; }
        public string BuildDate { get => buildDate; set => buildDate = value; }
        public string SecurityPatch { get => securityPatch; set => securityPatch = value; }
        public string Memory { get => memory; set => memory = value; }
        public string Resolution { get => resolution; set => resolution = value; }
        public string PixelDensity { get => pixelDensity; set => pixelDensity = value; }
        public string Size { get => size; set => size = value; }
        public string Technologie { get => technologie; set => technologie = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string HostName { get => hostName; set => hostName = value; }
        public string BluetoothName { get => bluetoothName; set => bluetoothName = value; }
    }
}
