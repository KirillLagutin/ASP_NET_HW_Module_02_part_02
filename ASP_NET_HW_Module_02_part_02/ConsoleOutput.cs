namespace ASP_NET_HW_Module_02_part_02
{
    public class ConsoleOutput
    {
        public ConsoleOutput(IEnumerable<IInfo> infos, string nameFile)
        {
            foreach (var item in infos)
            {
                Console.WriteLine(item.Info());
            }

            Console.WriteLine("------------------------------------------------------------------------\n" +
                              "Введите 's' чтобы записать в файл, или другую клавишу для отмены записи:\n" +
                              "------------------------------------------------------------------------\n");

            string choice = Console.ReadLine();
            if (choice == "s")
            {
                new SaveToFile(infos, nameFile);
                Console.WriteLine("----------------------------\n" + 
                                  "Информация добавлена в файл!\n" +
                                  "----------------------------\n");
            }
            else
            {
                Console.WriteLine("-----------------------\n" + 
                                  "Запись в файл отменена!\n" + 
                                  "-----------------------\n");
            }
        }
    }
}
