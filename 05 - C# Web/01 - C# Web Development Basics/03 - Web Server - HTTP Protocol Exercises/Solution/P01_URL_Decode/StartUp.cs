namespace P01_URL_Decode
{
    using System;
    using System.Net;

    public class StartUp
    {
        public static void Main()
        {
            string encodedURL = Console.ReadLine();
            string decodedURL = WebUtility.UrlDecode(encodedURL);
            Console.WriteLine(decodedURL);
        }
    }
}
