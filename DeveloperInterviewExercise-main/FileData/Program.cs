using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using Utility;

namespace FileData
{
    public static class Program
    {
        /// <summary>
        /// we can also use Dependency injection for it 
        /// to create object 
        /// which we have done manually
        /// </summary>
        private static Factory factory = new FileDetailsManager();
        public static void Main(string[] args)
        {

            //checking if command line or input is added
            if (args.Length>0)
            {
                //getting instance of filemanager class
                var fileDetailsManager = factory.GetInstance();
                // main prototype
                Console.WriteLine(fileDetailsManager.GetFileDetails(args[0], args[1]));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please Add Command Line Arguments");
                Console.ReadLine();
            }
           

        }
    }
}
