using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp22._07._2022
{
    //Участники соревнований по спорт. орентированию
    class Uchastniki
    {
        string Enter(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static int Enter_age(string text)
        {
            try
            {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода!");
                return Enter_age(text);
            }
        }

        public Uchastniki(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Uchastniki(int id)
        {
            Id = id;
            Name = Enter("Введите ФИО участника: ");
            Age = Enter_age("Введите возраст участника: ");
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID Участника: {Id}, \nФИО Участника: {Name}\nВозраст Участника: {Age}";
        }
    }
}
