namespace P02_Validate_URL
{
    using System;
    using System.Linq;
    using System.Net;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                string encodedURL = Console.ReadLine();
                string decodedURL = WebUtility.UrlDecode(encodedURL);

                Uri uri = new Uri(decodedURL);
                string uriScheme = uri.Scheme;
                string uriHost = uri.Host;
                int uriPort = uri.Port;
                string uriPath = uri.AbsolutePath;
                string uriQuery = uri.Query;
                string uriFragment = uri.Fragment;

                Console.WriteLine(uriScheme);
                Console.WriteLine(uriHost);
                Console.WriteLine(uriPort);
                Console.WriteLine(uriPath);
                Console.WriteLine(uriQuery);
                Console.WriteLine(uriFragment);
            }
        }
    }
}
