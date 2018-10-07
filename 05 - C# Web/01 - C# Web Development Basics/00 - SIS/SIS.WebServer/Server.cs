namespace SIS.WebServer
{
    using SIS.WebServer.Routing;
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;

    public class Server
    {
        private const string LocalhostIpAddress = "127.0.0.1";

        private readonly int port;

        private const string DateTimeFormat = "dd.MM.yyyy HH:mm:ss";

        private readonly TcpListener listener;

        private readonly ServerRoutingTable serverRoutingTable;

        private bool isRunning;

        public Server(int port, ServerRoutingTable serverRoutingTable)
        {
            this.port = port;
            this.listener = new TcpListener(IPAddress.Parse(LocalhostIpAddress), port);

            this.serverRoutingTable = serverRoutingTable;
        }

        public void Run()
        {
            this.listener.Start();
            this.isRunning = true;

            Console.WriteLine($"Server started at http://{LocalhostIpAddress}:{port}");

            Task task = Task.Run(this.ListenLoop);
            task.Wait();
        }

        public async Task ListenLoop()
        {
            while (this.isRunning)
            {
                Socket client = await this.listener.AcceptSocketAsync();
                
                StringBuilder result = new StringBuilder();
                result.AppendLine(new string('=', 60));
                result.AppendLine($"Client Connected on {DateTime.Now.ToString(DateTimeFormat)}");
                result.AppendLine(new string('=', 60));
                Console.WriteLine(result.ToString());

                ConnectionHandler connectionHandler = new ConnectionHandler(client, this.serverRoutingTable);
                Task responseTask = connectionHandler.ProcessRequestAsync();
                responseTask.Wait();
            }
        }
    }
}
