namespace ASP_NET_HW_Module_02_part_02.Task4_autofac
{
    public class Blender : IKitchenAppliances
    {
        public int Id { get; set; } = 3;
        public string Name { get; set; } = "Блендер";
        public string Action { get; set; } = "рубит";
    }
}
