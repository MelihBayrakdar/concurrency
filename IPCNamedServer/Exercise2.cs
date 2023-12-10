using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;

namespace Exercise
{
    public class IPCNamedServer2
    {
        public virtual void ipcServerCommunicate2()
        {
            Console.WriteLine("Pipe Server is being executed ...");
            Console.WriteLine("[Server] Waiting for path to a file to be executed ...");

            //Client
            var client = new NamedPipeClientStream("PipesOfConcurrency");
            client.Connect();

            StreamWriter writer = new StreamWriter(client);
            StreamReader reader = new StreamReader(client);

            while (true)
            {
                String path = reader.ReadLine();
                if (String.IsNullOrEmpty(path))
                    break;
                else
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = "open",
                        Arguments = path,
                        CreateNoWindow = false,
                        UseShellExecute = false
                    };

                    try
                    {
                        // Todo: Start your process and then wait for its exit
                        // Implement your code here
                        using (Process exeProcess = Process.Start(startInfo))
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
    }
}