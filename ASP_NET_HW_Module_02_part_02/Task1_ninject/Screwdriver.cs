namespace ASP_NET_HW_Module_02_part_02.Task1_ninject
{
    public class Screwdriver : IInfo
    {
        public string Info()
        {
            var result = "Отвёртка: \n" +
                "Водка — 50 мл\n" +
                "Апельсиновый сок — 150 мл\n";
            return result;
        }
    }
}
