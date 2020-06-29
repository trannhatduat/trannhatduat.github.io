using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    public abstract class dongvat
    {
        public abstract void sound();

        public virtual void eat()
        {
            Console.WriteLine("dong vat an gi ?");
        }
        public virtual void run()
        {
            Console.WriteLine(" di chuyen nhu the nao?");
        }
        
    }

    public class meo : dongvat
    {
        public override void sound()
        {
            Console.WriteLine("meo keu meo meo meo ");
            
        }
        public override void eat()
        {
            Console.WriteLine(" dong vat an tap ");
        }
        public override void run()
        {
            Console.WriteLine(" di chuyen bang 4 chan  ");
        }
    }

    public class cho : dongvat
    {
        public override void sound()
        {
            Console.WriteLine("cho keu gau gau gau ");

        }
        public override void eat()
        {
            Console.WriteLine(" dong vat an chay ");
        }
        public override void run()
        {
            Console.WriteLine(" di chuyen bang 4 chan ");
        }
    }

    public class ga : dongvat
    {
        public override void sound()
        {
            Console.WriteLine("ga keu o o o  ");

        }
        public override void eat()
        {
            Console.WriteLine(" dong vat an co ");
        }
        public override void run()
        {
            Console.WriteLine(" di chuyen bang 2 chan");
        }
    }

    public class vit : dongvat
    {
        public override void sound()
        {
            Console.WriteLine("vit keu cac cac cac ");

        }
        public override void eat()
        {
            Console.WriteLine(" dong vat an co ");
        }
        public override void run()
        {
            Console.WriteLine(" dong vat 2 chan biet boi  ");
        }
    }

    public class chim : dongvat
    {
        public override void sound()
        {
            Console.WriteLine("chim keu chip chip chip ");

        }
        public override void eat()
        {
            Console.WriteLine(" dong vat an hat ");
        }
        public override void run()
        {
            Console.WriteLine(" di chuyen bang canh ");
        }
    }


}
