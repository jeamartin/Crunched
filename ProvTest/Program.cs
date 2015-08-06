using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crunched;

namespace ProvTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadImporter t = new Crunched.ReadImporter();
            t.DoImport();
            Console.WriteLine("{0} component(s) are imported successfully.", t.AvailableNumberOfProtocol);
            var result = t.EnumerateAllComponents();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
