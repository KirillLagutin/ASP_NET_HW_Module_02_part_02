using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET_HW_Module_02_part_02
{
    public class SaveToFile
    {
        private IEnumerable<IInfo> info;
        public SaveToFile(IEnumerable<IInfo> info)
        {
            this.info = info;
            using FileStream fs = new FileStream("../../../App_Data/data.txt", FileMode.Create);
            using StreamWriter sw = new StreamWriter(fs);

            foreach (var i in info)
            {
                sw.WriteLine(i.Info());
            }
        }
    }
}
