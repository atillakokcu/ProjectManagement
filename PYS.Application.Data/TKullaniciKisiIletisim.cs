using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYS.Application.Data
{
    public class TKullaniciKisiIletisim
    {
        public TblKisi Kisi { get; set; }
        public TblKullanicilar Kullanicilar { get; set; }
        public TblKisiFirma KisiFirma { get; set; }
        public List<TblKisiIletisim> KisiIletisim { get; set; }
        public TKullaniciKisiIletisim()
        {
            KisiIletisim = new List<TblKisiIletisim>();
        }
    }
}
