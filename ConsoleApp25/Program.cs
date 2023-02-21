using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{    internal class Rabota
        {
         struct Den_Rojdenie
            {
                int God, Den, Mesyaz;
                public DateTime dt;
                public Den_Rojdenie(int g, int d, int m)
                {
                    dt = new DateTime(g, d, m);
                    God = g;
                    Den = d;
                    Mesyaz = m;
                }
                public void Nedelya_Rojdeniya()
                {
                    Console.WriteLine("День недели для {0:d} , {1}.", dt, dt.DayOfWeek);
                }
                public void God_Rojdeinya(int y)
                {
                    DateTime bufer = new DateTime(y, Mesyaz, Den);
                    Console.WriteLine("День недели для {0:d} , {1}.", bufer, bufer.DayOfWeek);
                }
                public void Data_rozhdeniya()
                {
                    var current = DateTime.Today;
                    int god = 0;
                    if (current.Month > Mesyaz || current.Month == Mesyaz && current.Day > Den)
                        god = current.Year + 1;
                    else
                        god = current.Year;

                    var days = (new DateTime(god, Mesyaz, Den) - current).TotalDays;
                    Console.WriteLine("Den' rozhdeniya proydet  " + days + " Dni");
                }
            }
            static void Main(string[] args)
            {
                Den_Rojdenie birth = new Den_Rojdenie(16, 2, 2023);
                birth.Nedelya_Rojdeniya();
                birth.God_Rojdeinya(2024);
                birth.Data_rozhdeniya();
            }
        }
    }
