using System;
using System.Linq;

namespace linq4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задния 1");
            Text();
            Console.WriteLine("--------------------------------");


            Console.WriteLine("Задания 3");
            Rtext();
            Console.WriteLine("--------------------------------");


            Console.WriteLine("Задания 4");
            Camel();
            Console.WriteLine("--------------------------------");

        }

        static void Text()
        {
            string text = "hello";
            var result = string.Join("",text.Select(p=>(p=='a')?'1':(p=='e')?'2':(p=='i')?'3':(p=='o')?'4':(p=='u')?'5':p));
            Console.WriteLine(result);
        }

        static void Rtext()
        {
            string text="h3 th2r2";
            var result = string.Join("",text.Select(p => (p == '1') ? 'a' : (p == '2') ? 'e' : (p == '3') ? 'i' : (p == '4') ? 'o' : (p == '5') ? 'u' : p));
            Console.WriteLine(result);
        }        
        
        static void Camel()
        {
            string text = "camelCasing";
            string result = string.Join("",text.Select(p => (p.ToString() == p.ToString().ToUpper()) ?" " + p.ToString() : p.ToString()));
            Console.WriteLine(result);
        }

    }
}
