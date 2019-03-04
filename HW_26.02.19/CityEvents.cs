using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_26._02._19
{
    public enum Events { Пожар, ДеньГорода, Ограбление }
    public delegate void DelEvents(Events e);
    public class CityEvents

    {
        Random rnd = new Random();
        public event DelEvents delEv;
        public void StartEvent()
        {
            Events t = (Events)rnd.Next(Enum.GetNames(typeof(Events)).Length);            
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(t);
            System.Console.ForegroundColor = ConsoleColor.White;

            delEv(t);
        }
    }
    public class FireMan
    {
        public void Message(Events ev)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            if (ev == Events.Пожар)
                Console.WriteLine("Пожарные тушат огонь");
            else if (ev == Events.ДеньГорода)
                Console.WriteLine("Пожарные отдыхают");
            else if (ev == Events.Ограбление)
                Console.WriteLine("Пожарные ничего не делают");     
                System.Console.ForegroundColor = ConsoleColor.White;

        }
    }
    public class Managers
    {
        public void Message(Events ev)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            if (ev == Events.Пожар)
                Console.WriteLine("Менеджеры сидят дома");
            else if (ev == Events.ДеньГорода)
                Console.WriteLine("Менеджеры организовывают день города");
            else if (ev == Events.Ограбление)
                Console.WriteLine("Менеджеры закрываются в доме");
            System.Console.ForegroundColor = ConsoleColor.White;

        }
    }
    public class Police
    {
        public void Message(Events ev)
        {
            System.Console.ForegroundColor = ConsoleColor.Blue;
            if (ev == Events.Пожар)
                Console.WriteLine("Полицейские едут на помощь");
            else if (ev == Events.ДеньГорода)
                Console.WriteLine("Полицейские отдыхают");
            else if (ev == Events.Ограбление)
                Console.WriteLine("Полицейские ищут преступника");
            System.Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
