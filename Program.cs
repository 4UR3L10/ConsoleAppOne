using System;

namespace ConsoleAppOne
{
    class Program
    {
        // Aurelio Martinez Only
        static void Main(string[] args)
        {
            // Creating Objects.
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();
            
            // Phrase Message
            Console.WriteLine(class1.returnPhrase() + class2.returnPhrase()/* + class3.returnPhrase()*/);              
        }
    }
}
