using Ninject.Modules;

namespace ASP_NET_HW_Module_02_part_02.Task2
{
    public class Characters : NinjectModule
    {
        public override void Load()
        {
            Bind<IInfo>().To<Infantryman>();
            Bind<IInfo>().To<Spearman>();
            Bind<IInfo>().To<Archer>();
        }
    }
}
