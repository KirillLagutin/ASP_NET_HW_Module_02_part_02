namespace ASP_NET_HW_Module_02_part_02.Task4_autofac
{
    public class CoffeeGrinder : IKitchenAppliances
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Кофемолка";
        public string Action { get; set; } = "молит";
    }
}
