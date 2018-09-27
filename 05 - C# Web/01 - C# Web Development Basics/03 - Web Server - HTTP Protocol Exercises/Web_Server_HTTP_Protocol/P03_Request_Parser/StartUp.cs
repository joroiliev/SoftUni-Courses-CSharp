﻿namespace P03_Request_Parser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Path> paths = GetListOfValidPaths();

            string[] httpRequest = Console.ReadLine().Split();
            string requestMethod = httpRequest[0].ToLower();
            string requestPath = httpRequest[1].TrimStart('/');
            //string httpVer = httpRequest[2];

            //Path path = new Path(requestPath);

            foreach (Path path in paths)
            {
                path.CheckRequestIsValid(requestPath, requestMethod);
            }
        }

        private static List<Path> GetListOfValidPaths()
        {
            List<Path> paths = new List<Path>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] pathArgs = input.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string mainPath = pathArgs[0];
                string method = pathArgs[1];

                //if (paths.Select(x => x.MainPath).Contains(mainPath))
                if (paths.Any(x => x.MainPath == mainPath))
                {
                    paths.First(x => x.MainPath == mainPath).Methods.Add(method);
                }
                else
                {
                    Path currentPath = new Path(mainPath);
                    currentPath.Methods.Add(method);
                    paths.Add(currentPath);
                }
                
                input = Console.ReadLine();
            }

            return paths;
        }

        
    }
}
