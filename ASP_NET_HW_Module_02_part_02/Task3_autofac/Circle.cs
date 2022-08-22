using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET_HW_Module_02_part_02.Task3_autofac
{
    public class Circle : IInfo
    {
        public string Info()
        {
            var result = "Круг\n";
            return result;
        }
    }
}
