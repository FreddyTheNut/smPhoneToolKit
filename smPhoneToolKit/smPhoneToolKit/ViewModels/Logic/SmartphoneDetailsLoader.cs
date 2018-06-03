using smPhoneToolKit.Logic;
using smPhoneToolKit.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace smPhoneToolKit.ViewModels.Logic
{
    public class SmartphoneDetailsLoader
    {
        #region General
        //Manufacturer
        public string GetManufacturer()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.product.manufacturer"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }  
        }
        //Brand
        public string GetBrand()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.product.brand"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Model
        public string GetModel()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.product.model"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Device
        public string GetDevice()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.product.device"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        #endregion General

        #region Hardware
        //CPU Model
        public string GetCpuModel()
        {   
            try
            {
                string output = ADB.Execute(ADBCommands.SHELL, "cat /proc/cpuinfo | find \"Hardware\"").Replace(" ", "").ToLower();
                return this.CheckOutput(Convert.ToString(output.Substring(output.IndexOf("msm"), 7)).ToUpper());
            }
            catch
            {
                try
                {
                    string output = ADB.Execute(ADBCommands.GETPROP, "ro.product.platform");

                    if (this.CheckOutput(output) == null)
                        output = ADB.Execute(ADBCommands.GETPROP, "ro.board.platform");

                    return this.CheckOutput(output);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                    return null;
                }
            }
        }
        //ToDo: Soc
        //CPU ISA
        public string GetCpuISA()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "cat /proc/cpuinfo | find \"Processor\"").Split(':')[1]);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Cores
        public string GetCores()
        {
            try
            {
                string coresType = this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "dalvik.vm.isa.arm.variant"));
                string coresCount = this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "cat /proc/cpuinfo | find \"architecture\"").Split(':')[1].Trim()[0].ToString());

                if(coresType != null && coresCount != null)
                    return $"{coresType}, {coresCount}x";
                else if(coresType != null && coresCount != null)
                    return coresType ?? coresCount;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //GPU
        public string GetGPU()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "dumpsys SurfaceFlinger | find \"GLES\"").Split(',')[1]);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //RAM
        public string GetRam()
        {
            try
            {
                double ram = Convert.ToDouble(ADB.Execute(ADBCommands.SHELL, "cat /proc/meminfo | find \"MemTotal\"").Split(':')[1].Trim().Split(' ')[0]);
                return Convert.ToString(Math.Round(ram / Math.Pow(1000, 2), 2)) + " GB";
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        #endregion Hardware

        #region System
        //ToDo: OS
        //Android Version
        public string GetAndroidVersion()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.version.release"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Api Level
        public string GetApiLevel()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.version.sdk"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Build Number
        public string GetBuildNumber()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.display.id"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Build Fingerprint
        public string GetBuildFingerprint()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.fingerprint"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Build ID
        public string GetBuildId()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.id"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Build Date
        public string GetBuildDate()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.date"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Security Patch
        public string GetSecurityPatch()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.build.version.security_patch"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        #endregion System

        #region Storage
        //Memory
        public string GetMemory()
        {
            try
            {
                decimal gesamtSpeicher = 0;

                string[] output = ADB.Execute(ADBCommands.SHELL, "df -H").Split(new[] { "\r\n" }, StringSplitOptions.None);

                if (output[1].Contains("No such file or directory"))
                    output = ADB.Execute(ADBCommands.SHELL, "df").Split(new[] { "\r\n" }, StringSplitOptions.None);

                gesamtSpeicher = output
                    .Skip(1)
                    .Select(s => Regex.Match(s, "(\\S+)\\s*(\\S+)\\s.+"))
                    .Where(m => !Regex.IsMatch(m.Groups[1].Value, ".+(?:ext | /sdcard1 | /mnt | /emulated).+"))
                    .Select(m => m.Groups[2].Value)
                    .Distinct()
                    .Select(v => v.EndsWith("G") ? (v, 1000) : (v, 1))
                    .Select(v => decimal.Parse(v.v, CultureInfo.InvariantCulture) * v.Item2)
                    .Sum();

                if (gesamtSpeicher > 0)
                    return Convert.ToString(Math.Ceiling(gesamtSpeicher / 1000)) + " GB";
                else
                    return null;
            }
            catch
            {
                try
                {
                    double dataMemory = Convert.ToDouble(ADB.Execute(ADBCommands.SHELL, "dumpsys devicestoragemonitor | find \"mTotalMemory\"").Split('=')[2].Split('Â')[0].Trim());
                    double systemMemory = Convert.ToDouble(ADB.Execute(ADBCommands.SHELL, "dumpsys diskstats | find \"System Size\"").Split(':')[1].Trim());

                    return Convert.ToString(Math.Round((((dataMemory * 1000000000 + systemMemory) / 1000000000 * 1024 * 1024 * 1024)) / 1000000000, 0)) + " GB";
                }
                catch
                {
                    return null;
                }
            }
        }
        #endregion Storage

        #region Display
        //Resolution
        public string GetResolution()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "dumpsys SurfaceFlinger | find \"* 0:\"").Split(':')[1].Split(',')[0]);
            }
            catch
            {
                try
                {
                    return this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "dumpsys SurfaceFlinger | find \"Display[0]\"").Split(':')[1].Split(',')[0]);
                }
                catch
                {
                    return null;
                }
            }
        }
        //Pixel Density
        public string GetPixelDensity()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.sf.lcd_density"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Size
        public string GetSize()
        {
            string[] output;

            try
            {
                output = ADB.Execute(ADBCommands.SHELL, "dumpsys SurfaceFlinger | find \"* 0:\"").Split(':')[1].Split(',');
            }
            catch
            {
                try
                {
                    output = ADB.Execute(ADBCommands.SHELL, "dumpsys SurfaceFlinger | find \"Display[0]\"").Split(':')[1].Split(',');
                }
                catch
                {
                    return null;
                }
            }

            try
            {
                string xdpi = output[1].Split('=')[1].Trim();
                string ydpi = output[2].Split('=')[1].Trim();

                output = this.GetResolution().Split('x');
                return Convert.ToString(Math.Round(1000000 * Math.Sqrt((((Convert.ToDouble(output[0]) / Convert.ToDouble(xdpi)) * (Convert.ToDouble(output[0]) / Convert.ToDouble(xdpi))) + ((Convert.ToDouble(output[1]) / Convert.ToDouble(ydpi)) * (Convert.ToDouble(output[1]) / Convert.ToDouble(ydpi))))), 2));
            }
            catch
            {
                return null;
            }
        }
        #endregion Display

        #region Battery
        //Technologie
        public string GetTechnologie()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "dumpsys battery | find \"technology\"").Split(':')[1]);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Capacity
        public string GetCapacity()
        {
            try
            {
                string capacity = this.CheckOutput(ADB.Execute(ADBCommands.SHELL, "dumpsys batterystats | find \"Capacity\"").Split(':')[1].Split(',')[0]);

                if(capacity != null)
                    return capacity + " mAh";
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        #endregion Battery

        #region Others
        //Serial Number
        public string GetSerialNumber()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "ro.serialno"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Host Name
        public string GetHostName()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "net.hostname"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        //Bluetooth Name
        public string GetBluetoothName()
        {
            try
            {
                return this.CheckOutput(ADB.Execute(ADBCommands.GETPROP, "net.bt.name"));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }
        #endregion Others

        private string CheckOutput(string output)
        {
            if(!String.IsNullOrWhiteSpace(output))
                return output.Trim();
            else
                return null;
        }
    }
}
