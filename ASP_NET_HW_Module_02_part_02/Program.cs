using ASP_NET_HW_Module_02_part_02;
using ASP_NET_HW_Module_02_part_02.Task1;
using ASP_NET_HW_Module_02_part_02.Task2;
using Ninject;

/*Задание 1
    Создайте приложение, которое выводит информа-
цию о коктейлях. Информация может быть сокращенная 
и полная. Предусмотрите отображение, как на экран,
так и в файл. Используйте при работе с этим проектом 
Autofac или Ninject*/

Console.WriteLine("Задание 1\n");

IKernel kernel1 = new StandardKernel(new AllCoctailes());
IEnumerable<IInfo> fullInfo1 = kernel1.GetAll<IInfo>();

foreach(var item in fullInfo1)
{
    Console.WriteLine(item.Info());
}

Console.WriteLine("Введите 's' чтобы записать в файл, или другую клавишу для отмены записи");
string choice1 = Console.ReadLine();
if (choice1 == "s")
{
    new SaveToFile(fullInfo1);
    Console.WriteLine("Информация добавлена в файл");
}
else
{
    Console.WriteLine("Запись в файл отменена");
}



/*Задание 2
    Создайте иерархию классов игровых персонажей. 
Например: пехотинец, копейщик, лучник и т.д. 
Реализуйте методы для получения информации о фигуре, 
проведения атаки. Предусмотрите отображение, как 
на экран, так и в файл. Используйте при работе с этим 
проектом Autofac или Ninject*/

Console.WriteLine("\nЗадание 2\n");

IKernel kernel2 = new StandardKernel(new Characters());
IEnumerable<IInfo> fullInfo2 = kernel2.GetAll<IInfo>();

foreach(var item in fullInfo2)
{
    Console.WriteLine(item.Info());
}

Console.WriteLine("Введите 's' чтобы записать в файл, или другую клавишу для отмены записи");
string choice2 = Console.ReadLine();
if (choice2 == "s")
{
    new SaveToFile(fullInfo2);
    Console.WriteLine("Информация добавлена в файл");
}
else
{
    Console.WriteLine("Запись в файл отменена");
}



/*Задание 3
    Создайте приложение, которое выводит информацию 
о геометрических фигурах. Информация может быть 
сокращенная и полная. Предусмотрите отображение,
как на экран, так и в файл. Используйте при работе с 
этим проектом Autofac или Ninject.*/



/*Задание 4
    Создайте приложение, которое выводит информа-
цию об устройствах. Например: кофемолка, миксер, 
блендер и т.д. Информация может быть сокращенная 
и полная. Предусмотрите отображение, как на экран, 
так и в файл. Используйте при работе с этим проектом 
Autofac или Ninject.*/