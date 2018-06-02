using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Models.Enums
{
    public enum Status
    {
        NoDevice,
        Unauthorized,
        ADB,
        Root,       // + ADB
        Recovery,    // + Root
        Sideload,

        //Just for Converters!
        RootXRecovery,
        RootXRecoveryXSideload,
        RecoveryXSideload
    }
}
