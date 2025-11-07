using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DllLib
{
    public class Class1
    {
        public void GetChiefLibrarian(string name) { Console.WriteLine($"Имя текущего главного библеотекаря {name}"); }//метод вывода глав.библеотекаря
        public void GetLibName(string name) { Console.WriteLine($"Название библеотеки {name}"); }//метод вывода названия библеотеки
        public string SetChiefLibrarian(string name, List<string> sotrud) //метод назначения нового глав.библеотекаря 
        {
            Console.WriteLine("Список сотрудников");
            Console.WriteLine(string.Join(",",sotrud));
            Console.WriteLine("Введите имя нового главного библеотекаря");
            string newname = Console.ReadLine();
            if (sotrud.Contains(newname)) { return  newname; }//если сотрудник есть в списке то козращаем его имя
            else { return name = "Такого имени нет в списке сотрудников"; }
        }
        public string GenerateBookCode(List<string> category) 
        {
            Random random = new Random();
            int number = random.Next(0,100);//случайны номер книги
            string randomCat = category[random.Next(category.Count)];//случайная категория из готового списка
            return $"{randomCat}_{number}";
        }
        public void GetStaff(List<string> sotrud) 
        {
            Console.WriteLine("Список сотрудников");
            Console.WriteLine(string.Join(",", sotrud)); 
        }
        public List<string> AddStaff(string newmemb, List<string> sotrud) 
        {
            sotrud.Add(newmemb);//добавляем введенное имя в список
            Console.WriteLine("Список сотрудников");
            Console.WriteLine(string.Join(",", sotrud));
            return sotrud;
        }
    }
    
}
