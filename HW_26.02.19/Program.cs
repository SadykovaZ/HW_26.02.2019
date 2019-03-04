using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26._02._19
{
    public class Program
    {
        delegate double Mathematic(double a);

        static void Main(string[] args)
        {
            Console.WriteLine("1-Плохая служба, 2-Город и его службы: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Ex01();
            }
            else if (choice == 2)
            {
                CityEvents city = new CityEvents();
                FireMan fireM = new FireMan();
                Managers manager = new Managers();
                Police police = new Police();

                city.delEv += police.Message;
                city.delEv += fireM.Message;
                city.delEv += manager.Message;

                for (int i = 0; i < 4; i++)
                {
                    city.StartEvent();
                    Console.WriteLine("\n");
                }
            }
        }

        public static void Ex01()
        {
            Mathematic m = POW;
            m += SQRT;
            m += MultByTwo;

            Random rnd = new Random();

            for (double i = 0; i < 3; i++)
            {
                double a = rnd.Next(1, 10);

                Console.WriteLine("a = {0}",a);
                foreach (Mathematic mat in m.GetInvocationList())
                {
                    try
                    {
                        double res = mat.Invoke(a);
                        Console.WriteLine(mat.Method.Name + ": " + res);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(mat.Method.Name + ": " + ex.Message);
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static double POW(double x)
        {
            return x * x; ;
        }
        static double SQRT(double x)
        {
            return Math.Sqrt(x);
        }
        static double MultByTwo(double x)
        {
            return x * 2;
        }

    }

}
