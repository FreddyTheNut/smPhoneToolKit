using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smPhoneToolKit.Logic
{
    static class ADB
    {
        private static readonly string WorkingDirectory = Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "adb")) ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "adb") : Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "adb");

        private static ProcessStartInfo ProcessInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            WorkingDirectory = ADB.WorkingDirectory,
            UseShellExecute = false,
            CreateNoWindow = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };

        public static string ExecuteCommand(string command)
        {
            ADB.ProcessInfo.Arguments = "/C " + command;

            Process process = Process.Start(ADB.ProcessInfo);

            string error = process.StandardError.ReadToEnd();

            return String.IsNullOrEmpty(error) ? process.StandardOutput.ReadToEnd() : error;
        }
    }
}
