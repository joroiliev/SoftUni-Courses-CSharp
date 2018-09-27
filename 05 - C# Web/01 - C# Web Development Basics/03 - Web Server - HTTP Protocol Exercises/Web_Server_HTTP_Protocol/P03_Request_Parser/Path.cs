namespace P03_Request_Parser
{
    using System.Collections.Generic;
    using System.Text;

    class Path
    {
        private const string OK = "OK";
        private const string NotFound = "NotFound";

        public Path(string path)
        {
            this.MainPath = path;
            this.Methods = new List<string>();
            this.statusMessage = NotFound;
            this.statusCode = 404;
        }

        private string statusMessage;
        private int statusCode;

        public string MainPath { get; }
        public List<string> Methods { get; }

        public bool CheckRequestIsValid(string mainPath, string method)
        {
            if (this.Methods.Contains(method) && this.MainPath == mainPath)
            {
                this.statusMessage = OK;
                this.statusCode = 200;

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"HTTP/1.1 {statusCode} {statusMessage}");
            sb.AppendLine($"Content-Length: {statusMessage.Length}");
            sb.AppendLine($"Content-Type: text/plain");
            sb.AppendLine();
            sb.Append($"{statusMessage}");

            return sb.ToString();
        }
    }
}