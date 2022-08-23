namespace ASP_NET_HW_Module_02_part_02.Task4_autofac
{
    public class Mixer : IKitchenAppliances
    {
        public int Id { get; set; } = 2;
        public string Name { get; set; } = "Миксер";
        public string Action { get; set; } = "взбивает";
    }
}
