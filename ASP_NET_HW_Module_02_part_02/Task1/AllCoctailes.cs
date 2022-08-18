using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace ASP_NET_HW_Module_02_part_02.Task1
{
    public class AllCoctailes : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IInfo>().To<Mojito>();
            Bind<IInfo>().To<Screwdriver>();
        }
    }
}
