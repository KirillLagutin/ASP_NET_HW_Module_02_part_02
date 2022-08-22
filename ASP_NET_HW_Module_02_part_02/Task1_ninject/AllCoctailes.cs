using Ninject.Modules;

namespace ASP_NET_HW_Module_02_part_02.Task1_ninject
{
    public class AllCoctailes : NinjectModule
    {
        public override void Load()
        {
            Bind<IInfo>().To<Mojito>();
            Bind<IInfo>().To<Screwdriver>();
        }
    }
}
