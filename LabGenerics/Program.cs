using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> stringlist = new GenericList<string>();
            stringlist.Add("Suleyman");
            stringlist.Add("Naib");
            stringlist.Add("Gunay");
            stringlist.Add("Nermin");
            stringlist.Add("FazilAbi");
            //foreach (var item in stringlist)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stringlist.Contains("heci"));
            stringlist.Remove("Nermin");

            foreach (var item in stringlist)
            {
                Console.WriteLine(item);
            }

        }
    }
}
