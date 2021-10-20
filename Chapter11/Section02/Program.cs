using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section02
{
    class Program
    {
        static void Main(string[] args)
        {
         var xdoc = XDocument.Load("novelist.xml");
            var elements = xdoc.Root.Elements()
                   .Where(x => x.Element("name").Value == "菊池　寛");

            elements.Remove();
            xdoc.Save("novelist.xml");
        }
    }
}
