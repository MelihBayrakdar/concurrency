using System;
using System.IO;
using System.IO.Pipes;
using System.Linq;

namespace Exercise
{
    public class IPCNamedClient2
    {
        public virtual void ipcClientCommunicate2()
        {
            Console.WriteLine("Pipe Client is being executed ...");
            Console.WriteLine("[Client] Enter a path to a file to be executed:");

            var server = new NamedPipeServerStream("PipesOfConcurrency");
            server.WaitForConnection();

            StreamReader reader = new StreamReader(server);
            StreamWriter writer = new StreamWriter(server);

            while (true)
            {
                String input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) // Finish if nothing is entered
                    break;
                else
                {
                    Console.WriteLine($"[Client] Sending path to server: {input}"); // Print the message received
                    writer.WriteLine(input);
                    writer.Flush();
                    

                }
            }
        }
    }
}