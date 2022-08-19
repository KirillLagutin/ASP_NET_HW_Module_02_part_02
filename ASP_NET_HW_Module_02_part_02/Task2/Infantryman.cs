namespace ASP_NET_HW_Module_02_part_02.Task2
{
    public class Infantryman : IInfo
    {
        public string Info()
        {
            var result = "Пехотинец атакует в ближнем бою.\n";
            return result;
        }
    }
}
