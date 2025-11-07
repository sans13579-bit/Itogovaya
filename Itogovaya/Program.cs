using DllLib;
int count = 0;
Class1 deist = new Class1();
string free,randombook,newstaff;
string LibName = "Городская библиотека г. Чита";
string GlavBib = "Иванова Мария Петровна";
List<string> sotrud = new List<string>
{
     "Петров П.С.","Сидорова А.В.","Козлов И.Д.","Иванова М.П."
};
List<string> cat = new List<string>
{"Научная книга","Научно-популярная книга","Производственно-практическая книга",
"Учебная книга","Справочная книга","Информационная книга",
};
do
{
    Console.WriteLine();
    Console.WriteLine("Выберите действие \n 1 - Вывести ФИО главного библиотекаря \n 2 - Вывести название библиотеки \n 3 - Вывод сотрудников библиотеки \n 4 - Установить нового главного билиотекаря \n 5 - Сгенерировать книгу  \n 6 - Добавить сотрудника");
    try
    {
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (c)
        {
            case 1:
                deist.GetChiefLibrarian(GlavBib);
                break;
            case 2:
                deist.GetLibName(LibName);
                break;
            case 3:
                deist.GetStaff(sotrud);
                break;
            case 4:
                GlavBib = deist.SetChiefLibrarian(LibName, sotrud);
                Console.Clear();
                if (GlavBib.Contains($"Такого"))
                { Console.WriteLine("Такого имени нет в списке сотрудников"); }
                else { Console.WriteLine($"Новый главный библиотекарь " + GlavBib); }
                break;
            case 5:
                randombook = deist.GenerateBookCode(cat);
                Console.WriteLine(randombook);
                break;
            case 6:
                Console.WriteLine("Введите имя нового сотрудника");
                newstaff = Console.ReadLine();
                deist.AddStaff(newstaff, sotrud);
                break ;
        }
}
    catch (System.FormatException) { Console.WriteLine("Не число"); }

}
while (count == 0);