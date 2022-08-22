namespace ASP_NET_HW_Module_02_part_02.Task2_ninject
{
    public class Archer : IInfo
    {
        public string Info()
        {
            var result = "Лучник атакует на дальней дистанции.\n";
            return result;
        }
    }
}
