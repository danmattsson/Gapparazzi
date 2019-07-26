using System;
using System.Collections.Generic;
using System.Text;

namespace se.interbellum.gpsync.lib
{
    public class PhotoService
    {
        public Uri Location { get; }

        public PhotoService(Uri location)
        {
            Location = location;
        }
    }
}
