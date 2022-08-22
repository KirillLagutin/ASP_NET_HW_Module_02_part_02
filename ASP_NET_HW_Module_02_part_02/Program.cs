using Ninject;
using Autofac;
using ASP_NET_HW_Module_02_part_02;
using ASP_NET_HW_Module_02_part_02.Task1_ninject;
using ASP_NET_HW_Module_02_part_02.Task2_ninject;
using ASP_NET_HW_Module_02_part_02.Task3_autofac;
using ASP_NET_HW_Module_02_part_02.Task4_autofac;

/*Задание 1
    Создайте приложение, которое выводит информацию 
о коктейлях. Информация может быть сокращенная 
и полная. Предусмотрите отображение, как на экран,
так и в файл. Используйте при работе с этим проектом 
Autofac или Ninject*/

Console.WriteLine("\n===================\n" + 
                    "Задание 1 (ninject)\n" +
                    "===================\n");

IKernel kernel1 = new StandardKernel(new AllCoctailes());
IEnumerable<IInfo> coctailes = kernel1.GetAll<IInfo>();

new ConsoleOutput(coctailes, "task1_ninject");



/*Задание 2
    Создайте иерархию классов игровых персонажей. 
Например: пехотинец, копейщик, лучник и т.д. 
Реализуйте методы для получения информации о фигуре, 
проведения атаки. Предусмотрите отображение, как 
на экран, так и в файл. Используйте при работе с этим 
проектом Autofac или Ninject*/

Console.WriteLine("\n===================\n" +
                    "Задание 2 (ninject)\n" +
                    "===================\n");

IKernel kernel2 = new StandardKernel(new Characters());
IEnumerable<IInfo> characters = kernel2.GetAll<IInfo>();

new ConsoleOutput(characters, "task2_ninject");


/*Задание 3
    Создайте приложение, которое выводит информацию 
о геометрических фигурах. Информация может быть 
сокращенная и полная. Предусмотрите отображение,
как на экран, так и в файл. Используйте при работе с 
этим проектом Autofac или Ninject.*/

Console.WriteLine("\n===================\n" +
                    "Задание 3 (autofac)\n" +
                    "===================\n");

var builder = new ContainerBuilder();
builder.RegisterType<Circle>().As<IInfo>();
builder.RegisterType<Square>().As<IInfo>();
var container = builder.Build();
var figures = container.Resolve<IEnumerable<IInfo>>();

new ConsoleOutput(figures, "task3_autofac");


/*Задание 4
    Создайте приложение, которое выводит информацию 
об устройствах. Например: кофемолка, миксер, 
блендер и т.д. Информация может быть сокращенная 
и полная. Предусмотрите отображение, как на экран, 
так и в файл. Используйте при работе с этим проектом 
Autofac или Ninject.*/

/*Console.WriteLine("\n===================\n" +
                      "Задание 4 (autofac)\n" +
                      "===================\n");*/

