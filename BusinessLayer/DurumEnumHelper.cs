using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DurumEnumHelper
    {
        public static string GetText(byte id)
        {
            switch (id)
            {
                case 1:
                    //DurumEnum.OnayBekliyor
                    return "Onay Bekliyor";
                case 2:
                    //DurumEnum.Reddedildi
                    return "Reddedildi";
                case 3:
                    //DurumEnum.Duzeltilecek
                    return "Düzeltilecek";
                case 4:
                    //DurumEnum.Odendi
                    return "Ödendi";
                case 5:
                    //DurumEnum.Onaylandi
                    return "Onaylandı";
                default:
                    return string.Empty;
            }
        }

        public static string GetText(DurumEnum e)
        {
            switch (e)
            {
                case DurumEnum.OnayBekliyor:
                    return "Onay Bekliyor";
                case DurumEnum.Reddedildi:
                    return "Reddedildi";
                case DurumEnum.Duzeltilecek:
                    return "Düzeltilecek";
                case DurumEnum.Odendi:
                    return "Ödendi";
                case DurumEnum.Onaylandi:
                    return "Onaylandı";
                default:
                    return string.Empty;
            }
        }
    }
}
