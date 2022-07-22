using System;
using System.Collections.Generic;

namespace Csharp22._07._2022
{
    class Program
    {
        static void Main(string[] args)
        {


            //Uchastniki[] uchasniki = new Uchastniki[3];
            List<Uchastniki> uchasniki = new List<Uchastniki>();

            int count = Uchastniki.Enter_age("Введите кол-во участников: ");
            for (int i = 0; i < count; i++)
            {
                uchasniki.Add(new Uchastniki(i + 1));
            }

            void vyvod()
            {
                Console.WriteLine("Все участники: ");

                foreach (var item in uchasniki)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine("[1] Добавить участника\n[2] Удалить участника");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        uchasniki.Add(new Uchastniki(uchasniki.Count + 1));
                        /*Array.Resize(ref uchasniki, uchasniki.Length + 1);
                        uchasniki[uchasniki.Length - 1] = new Uchastniki(uchasniki.Length);*/
                        vyvod();
                        break;
                    }
                case "2":
                    {
                        vyvod();
                        uchasniki.RemoveAt(Uchastniki.Enter_age("Введите id:") - 1);
                        vyvod();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
