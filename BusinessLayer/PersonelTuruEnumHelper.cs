using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonelTuruEnumHelper
    {
        public static string GetText(byte id)
        {
            switch (id)
            {
                case 1:
                    //PersonelTuruEnum.Calisan
                    return "Çalışan";
                case 2:
                    //PersonelTuruEnum.BirimYoneticisi
                    return "Birim Yöneticisi";
                case 3:
                    //PersonelTuruEnum.Yonetici
                    return "Yönetici";
                case 4:
                    //PersonelTuruEnum.Muhasebe
                    return "Muhasebe";
                default:
                    return string.Empty;
            }
        }

        public static string GetText(PersonelTuruEnum e)
        {
            switch (e)
            {
                case PersonelTuruEnum.Calisan:
                    return "Çalışan";
                case PersonelTuruEnum.BirimYoneticisi:
                    return "Birim Yöneticisi";
                case PersonelTuruEnum.Yonetici:
                    return "Yönetici";
                case PersonelTuruEnum.Muhasebe:
                    return "Muhasebe";
                default:
                    return string.Empty;
            }
        }
    }
}
