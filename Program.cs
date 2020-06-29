using System;
using System.Linq.Expressions;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            dongvat x;

            Console.WriteLine(" chon con vat ban yeu thich ");
            Console.WriteLine("1. cho 2. meo 3. ga 4. vit 5. chim ");
            i = Console.ReadLine();
            switch (i)
            {
                case "1":
                    x = new cho();
                    x.eat();
                    x.run();
                    x.sound();
                    break;
                case "2":
                    x.eat();
                    x.run();
                    x.sound();
                    break;
                case "3":
                    x.eat();
                    x.run();
                    x.sound();
                    break;
                case "4":
                    x.eat();
                    x.run();
                    x.sound();
                    break;
                case "5":
                    x.eat();
                    x.run();
                    x.sound();
                    break;

            }
                 
                    
                
        }
    }
}
