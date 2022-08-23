namespace ASP_NET_HW_Module_02_part_02.Task4_autofac
{
    public class InfoKitchenAppliances
    {
        private readonly IGetMethods getMethods;
        public InfoKitchenAppliances(IGetMethods getMethods)
        {
            this.getMethods = getMethods;
        }

        public void ShowAppliances(int id = -1)
        {
            if (id == -1)
            {
                foreach (var item in getMethods.GetKitchenAppliances())
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine(getMethods.GetKitchenApplianceById(id));
            }
        }

        public void SaveAppliances(int id = -1)
        {
            string path = "../../../App_Data/task4_autofac.txt";
            if (id == -1)
            {
                foreach (var item in getMethods.GetKitchenAppliances())
                {
                    File.AppendAllText(path, item);
                }
            }
            else
            {
                File.AppendAllText(path, getMethods.GetKitchenApplianceById(id));
            }
        }

        public void ConsoleOutput()
        {
            Console.WriteLine("----------------------------------------------------------------------------\n" +
                              "Введите '0' для вывода на экран всего списка , или ID техники для её вывода:\n" +
                              "----------------------------------------------------------------------------\n");

            try
            {
                var choiceConsole = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Environment.NewLine);
                if (choiceConsole == 0)
                {
                    ShowAppliances();
                }
                else
                {
                    ShowAppliances(choiceConsole);
                }
            }
            catch
            {
                Console.WriteLine("\nError!!!");
            }

            Console.WriteLine("----------------------------------------------------------------------------\n" +
                              "Введите 's' чтобы записать весь список в файл, или ID техники для её записи:\n" +
                              "----------------------------------------------------------------------------\n");
            try
            {
                var choiceSave = Console.ReadLine();
                if (choiceSave == "s")
                {
                    SaveAppliances();
                }
                else
                {
                    SaveAppliances(Convert.ToInt32(choiceSave));
                }
                Console.WriteLine("----------------------------\n" +
                                      "Информация добавлена в файл!\n" +
                                      "----------------------------\n");
            }
            catch
            {
                Console.WriteLine("\nError!!!");
            }
        }
    }
}
