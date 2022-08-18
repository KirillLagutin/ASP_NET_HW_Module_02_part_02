using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_NET_HW_Module_02_part_02.Task1
{
    public class Mojito : IInfo
    {
        public string Info()
        {
            var result = "Мохито: \n" +
                "Белый ром — 50 мл\n" +
                "Сахарный сироп — 20 мл\n" +
                "Содовая (минеральная вода с лимоном или sprite) — 50 мл\n" +
                "Мята — 15 грамм\n" +
                "Лайм — 3 дольки\n";
            return result;
        }
    }
}
