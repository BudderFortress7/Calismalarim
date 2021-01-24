using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kerem");
            isimler.Add("Ömer");
            foreach (var itm in isimler.Items)
            {
                Console.WriteLine(itm);
            }
            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(1343);
            sayilar.Add(021354);
            foreach (int sad in sayilar.Items)
            {
                Console.WriteLine(sad);
            }
            Console.ReadLine();
        }
    }
}
