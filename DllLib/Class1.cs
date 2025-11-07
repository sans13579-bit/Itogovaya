using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DllLib
{
    public class Class1
    {
        public void GetChiefLibrarian(string name) { Console.WriteLine($"Имя текущего главного библеотекаря {name}"); }
        public void GetLibName(string name) { Console.WriteLine($"Название библеотеки {name}"); }
        public string SetChiefLibrarian(string name, List<string> sotrud) 
        {
            Console.WriteLine("Список сотрудников");
            Console.WriteLine(string.Join(",",sotrud));
            Console.WriteLine("Введите имя нового главного библеотекаря");
            string newname = Console.ReadLine();
            if (sotrud.Contains(newname)) { return  newname; }
            else { return name = "Такого имени нет в списке сотрудников"; }
        }
        public string GenerateBookCode(List<string> category) 
        {
            Random random = new Random();
            int number = random.Next(0,100);
            string randomCat = category[random.Next(category.Count)];
            return $"{randomCat}_{number}";
        }
        public void GetStaff(List<string> sotrud) 
        {
            Console.WriteLine("Список сотрудников");
            Console.WriteLine(string.Join(",", sotrud)); 
        }
        public List<string> AddStaff(string newmemb, List<string> sotrud) 
        {
            sotrud.Add(newmemb);
            Console.WriteLine("Список сотрудников");
            Console.WriteLine(string.Join(",", sotrud));
            return sotrud;
        }
    }
    
}
