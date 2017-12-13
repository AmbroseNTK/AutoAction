using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoActionLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\default"))
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\default");
            }
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "AutoAction.exe";
            process.StartInfo = startInfo;
            process.Start();
           

        }
    }
}
