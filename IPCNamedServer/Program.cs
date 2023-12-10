using Exercise;
//using Solution;

namespace Program
{
    class IPCServer
    {
        static void Main(string[] args)
        {
            new IPCNamedServer2().ipcServerCommunicate2();
            
             //SolutionIPCNamedServer server = new SolutionIPCNamedServer("MessageReversePipe");
             //server.prepareServer();
             //server.communicate();

        }
    }
}