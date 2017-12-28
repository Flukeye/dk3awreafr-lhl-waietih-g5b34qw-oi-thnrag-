using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_code
{

    class Natural
    {
        private int frux0;
        public int Frux0
        {
            get             
            {
                return frux0;
            }
            set
            {
                if (value > 0)
                {
                    frux0 = value;
                }
                else
                {
                    Console.WriteLine("Ti 3,14door");
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////public void SetFrux0(int chislo)
        //////////////////////////////////////////////////////////////////////////////////////{
        //////////////////////////////////////////////////////////////////////////////////////    if (chislo < 10)
        //////////////////////////////////////////////////////////////////////////////////////    {
        //////////////////////////////////////////////////////////////////////////////////////        Frux0 = chislo;
        //////////////////////////////////////////////////////////////////////////////////////    }
        //////////////////////////////////////////////////////////////////////////////////////    else
        //////////////////////////////////////////////////////////////////////////////////////    {
        //////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("Olyo? vi sho ebobo?");
        //////////////////////////////////////////////////////////////////////////////////////    }
        //////////////////////////////////////////////////////////////////////////////////////}
    }

    static class MichaelCirkul
    {
        public static double Square(int radiation)
        {
            return Math.PI * radiation * radiation;
        }
        public static double SqLengthuare(int radiation)
        {
            return 2 * Math.PI * radiation;
        }
    }

    class St4tlc
    {
        public static int a;
        public int b;
        public St4tlc(int b)
        {
            this.b = b;
            Console.WriteLine("Ti @ ya @");
        }
        static St4tlc()
        {
            a = 6;
            Console.WriteLine("Ya rodilsya");
        }
        public static void bedjoke(int a)
        {
            St4tlc.a = a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //St4tlc aa = new St4tlc(11);
            //St4tlc bb = new St4tlc(22);
            //Console.WriteLine(St4tlc.a);
            //St4tlc.bedjoke(777);
            Natural aa = new Natural();
            aa.Frux0 = -50;
            Console.ReadKey();
        }
    }
}
