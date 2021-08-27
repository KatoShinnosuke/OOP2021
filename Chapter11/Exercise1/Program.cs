﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample,xml";
            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                            .Select(x => new
                            {
                                Name = xdoc.Element("name").Value,
                                Teammembers = xdoc.Element("teammembers").Value
                            });

        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                            .Select(x => new
                            {
                             Firstplayed = x.Element("firstplayed").Value,
                             Name = x.Element("name").Attribute("kanji").Value
                            }).OrderBy(x=>int.Parse(x.Firstplayed));
            foreach (var sport in sports)
            {
                Console.WriteLine("{0}{1}", sport.Name);
            }
        }

        private static void Exercise1_3(string file)
        {
        }
    }
}
