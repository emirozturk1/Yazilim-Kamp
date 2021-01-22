using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<string, string> kisiler = new MyDictionaryList<string, string>();
            kisiler.Add("177", "Emir");
            kisiler.Add("158", "Emre");

            foreach (var boy in kisiler.Keys)
            {
                Console.WriteLine(boy);
            }

            foreach (var isim in kisiler.Values)
            {
                Console.WriteLine(isim);
            }

            Console.ReadLine();
        }
    }
}
