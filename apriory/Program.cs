using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace apriory
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"F:\abc.csv"); //read from path
            List<string> listA = new List<string>();
            while (!reader.EndOfStream) 
            {
                var line = reader.ReadLine(); //read every row
                var values = line.Split(';'); //split row with ;

                foreach(var item in values)
                {
                    listA.Add(item);                //add to list
                }
                listA.Add(",");
            }

            foreach (var element in listA)
                Console.WriteLine(element);

            Console.ReadLine();
        }
    }
}
