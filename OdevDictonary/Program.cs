using System;
using System.Collections.Generic;

namespace OdevDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdPuan = new Dictionary<string, int> ();
           // Console.WriteLine(AdPuan[0]);
            AdPuan.Add("Sağre", 58);
            AdPuan.Add("Furkan", 89);
            AdPuan.Add("Gül", 96);
            AdPuan.Add("Kemal", 78);
            AdPuan.Add("Veli", 98);
            AdPuan.Add("Can", 18);
            AdPuan.Add("Güler", 15);
            Console.WriteLine(AdPuan.Count);
        }
    }
}
