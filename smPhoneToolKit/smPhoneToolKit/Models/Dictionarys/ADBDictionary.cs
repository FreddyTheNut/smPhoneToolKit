using smPhoneToolKit.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Models.Dictionarys
{
    public class ADBDictionary
    {
        private readonly Dictionary<ADBCommands, string> dic = new Dictionary<ADBCommands, string>();

        public ADBDictionary()
        {
            //ADB
            this.dic.Add(ADBCommands.EXECUTE, "adb");

            this.dic.Add(ADBCommands.DEVICES, "adb devices");
            this.dic.Add(ADBCommands.REBOOT, "adb reboot");
            this.dic.Add(ADBCommands.RECOVERY, "adb recovery");
            this.dic.Add(ADBCommands.BOOTLOADER, "adb bootloader");

            this.dic.Add(ADBCommands.PUSH, "adb push -p");
            this.dic.Add(ADBCommands.PULL, "adb pull -p");
            this.dic.Add(ADBCommands.INSTALL, "adb install");

            this.dic.Add(ADBCommands.SHELL, "adb shell");
            this.dic.Add(ADBCommands.SHELLROOT, "adb shell \"su -c '");
            this.dic.Add(ADBCommands.GETPROP, "adb shell getprop");
            this.dic.Add(ADBCommands.SETPROP, "adb shell \"su -c 'setprop");

            this.dic.Add(ADBCommands.STOPSERVER, "adb kill-server");

            //FASTBOOT
            this.dic.Add(ADBCommands.UNLOCK, "fastboot flashing unlock");
            this.dic.Add(ADBCommands.FLASHRECOVERY, "fastboot flash recovery");
            this.dic.Add(ADBCommands.FLASHVENDOR, "fastboot flash vendor");

            //SIDELOAD
            this.dic.Add(ADBCommands.SIDELOADFLASH, "adb sideload /update.zip");
        }

        public Dictionary<ADBCommands, string> GetDictionary()
        {
            return this.dic;
        }
    }
}
