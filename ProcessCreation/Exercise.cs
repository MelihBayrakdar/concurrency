using System;
using System.Diagnostics;

/// This example shows how to define a process and start it.
/// Check here: https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process?view=netcore-3.1


namespace Exercise
{
    public class ProcessCreation
    {
        public virtual void createProcess()
        {
            // Todo: Create an object from ProcessStartInfo
            // Implement your code here ...
            ProcessStartInfo prInfo = new ProcessStartInfo();

            // Todo: Provide the path and the name of your executable file
            // Implement your code here
            prInfo.FileName = "open";
            // prInfo.Arguments = "notepad.txt";
            prInfo.Arguments = "../Processes/bin/Debug/net6.0/Processes.dll";

            // This means start the process in a new window
            prInfo.CreateNoWindow = false;

            prInfo.UseShellExecute = false;

            try
            {
                // Todo: Start your process and then wait for its exit
                // Implement your code here
                using (Process exeProcess = Process.Start(prInfo))
                {
                    exeProcess.WaitForExit();
                }

            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }

        }
    }
}
