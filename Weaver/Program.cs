﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Weaver
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.isfdb.org/cgi-bin/pl.cgi?359157";

            if (String.IsNullOrEmpty(url))
            {
                Console.WriteLine("Need a URL.");
                Console.ReadLine();
                return;
            }

            Spider spider = new Spider();
            spider.Go(url);
        }
    }
}