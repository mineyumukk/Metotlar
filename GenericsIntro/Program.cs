using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emine <3");
            Console.WriteLine(isimler.Length);

            isimler.Add(" Cansu");
            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.Write(item);
            }

            //Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}
