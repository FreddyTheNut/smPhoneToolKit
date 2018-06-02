using smPhoneToolKit.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Models.Dictionarys
{
    public class StatusDictionary
    {
        private readonly Dictionary<String, Status> dic = new Dictionary<string, Status>();

        public StatusDictionary()
        {
            this.dic.Add("unauthorized", Status.Unauthorized);
            this.dic.Add("device", Status.ADB);
            this.dic.Add("recovery", Status.Recovery);
            this.dic.Add("sideload", Status.Sideload);
            this.dic.Add("nodevice", Status.NoDevice);
        }

        public Dictionary<string, Status> GetStatusDictionary()
        {
            return this.dic;
        }
    }
}
