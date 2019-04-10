using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_CoreServices.src.Screens
{
    class AdbBarcodeClient
    {

        public string runADBCommand(string adbCommand)
        {
            Console.WriteLine("Running given command= " + adbCommand + "$$$");
            StringBuilder returnValue = new StringBuilder();
            string line;

            Stream inStream = null;

            try
            {
                Console.WriteLine("adbCommand = " + adbCommand);
                //Process process = Process.Start(adbCommand);

                ProcessStartInfo procStartInfo =
                    new ProcessStartInfo("cmd", "/c" + adbCommand);
                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                Console.WriteLine(result);

                //process.waitFor();/
                inStream = proc.StandardOutput.BaseStream;
                StreamReader brCleanUp = new StreamReader(inStream);

                while ((line = brCleanUp.ReadLine()) != null)
                {
                    if (!line.Equals(""))
                    {
                        Console.WriteLine("After exec");
                        Console.WriteLine("Line " + line);
                    }
                    returnValue.Append(line).Append("\n");
                }
                brCleanUp.Close();
                try
                {
                    proc.WaitForExit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error " + e.ToString());
            }
            Console.WriteLine(returnValue.ToString() + "@@");
            return returnValue.ToString();
        }
    }
}
