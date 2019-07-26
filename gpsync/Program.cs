using System;
using se.interbellum.gpsync.lib;

namespace se.interbellum.gpsync.cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Uri gpUri = null; // applicationsettings;
            PhotoService photoService = new PhotoService(gpUri);
        }
    }
}
