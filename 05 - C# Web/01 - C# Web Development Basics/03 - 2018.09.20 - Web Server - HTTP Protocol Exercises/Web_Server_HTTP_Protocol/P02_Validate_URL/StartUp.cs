namespace P02_Validate_URL
{
    using System;
    using System.Net;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Uri uri = GetURI();

                string uriScheme = uri.Scheme;
                string uriHost = uri.Host;
                int uriPort = CheckIfPortValid(uri);
                string uriPath = uri.AbsolutePath;
                string uriQuery = uri.Query.TrimStart('?');
                string uriFragment = uri.Fragment.TrimStart('#');

                PrintOutput(uriScheme, uriHost, uriPort, uriPath, uriQuery, uriFragment);
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Invalid URL");
            }
        }

        private static Uri GetURI()
        {
            string encodedURL = Console.ReadLine();
            string decodedURL = WebUtility.UrlDecode(encodedURL);
            Uri uri = new Uri(decodedURL);
            return uri;
        }

        private static int CheckIfPortValid(Uri uri)
        {
            if ((uri.Scheme == "http" && uri.Port != 80) ||
                (uri.Scheme == "https" && uri.Port != 443))
            {
                throw new UriFormatException();
            }

            return uri.Port;
        }

        private static void PrintOutput(string uriScheme, string uriHost, int uriPort, string uriPath, string uriQuery, string uriFragment)
        {
            Console.WriteLine($"Protocol: {uriScheme}");
            Console.WriteLine($"Host: {uriHost}");
            Console.WriteLine($"Port: {uriPort}");
            Console.WriteLine($"Path: {uriPath}");
            if (uriQuery != string.Empty)
            {
                Console.WriteLine($"Query: {uriQuery}");
            }
            if (uriFragment != string.Empty)
            {
                Console.WriteLine($"Fragment: {uriFragment}");
            }
        }
    }
}