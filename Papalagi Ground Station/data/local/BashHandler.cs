using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papalagi_Ground_Station.data.local
{
   public class BashHandler
    {
        public const string abFile = "D:\\Programs\\Yazilim\\GeneralProjects\\Papalagi\\GraundStation\\ab.bat";
        public const string startFile = "D:\\Programs\\Yazilim\\GeneralProjects\\Papalagi\\GraundStation\\start.bat";
        public const string createTextFile = "D:\\Programs\\Yazilim\\GeneralProjects\\Papalagi\\GraundStation\\create.bat";


        

        public string run()
        {
         

            Process process = new Process();
            process.StartInfo.FileName = abFile;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            Thread.Sleep(3000); // wait for 3 seconds
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            int exitCode = process.ExitCode;
          //  MessageBox.Show(error.ToString());
            return output;
        }

        public void runCommand(String command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = false;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();
        }
    }
}
