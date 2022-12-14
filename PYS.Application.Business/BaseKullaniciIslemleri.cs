using PYS.Application.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PYS.Application.Security;
using System.CodeDom;

namespace PYS.Application.Business
{
    public class BaseKullaniciIslemleri
    {

        private DbPYSEntities Db;

        internal BaseKullaniciIslemleri()
        {
            Db = new DbPYSEntities();

        }

        internal bool DoLogin(string KullaniciBilgisi, string Sifre, out VwKisiKullaniciIletisim KullaniciKisi, out string Mesaj)
        {
            KullaniciKisi = null;
            Mesaj = "";

            bool result = false;

            try
            {
                var KisiKaydi = (from data in Db.VwKisiKullaniciIletisim 
                                 where data.Iletisim == KullaniciBilgisi || data.KullaniciAdi == KullaniciBilgisi 
                                 select data).FirstOrDefault();

                if (KisiKaydi==null)
                {
                    Mesaj = "Kullanıcı bilgileri hatalı";
                }

                else
                {
                    if (KisiKaydi.Sifre != PYSSecurity.StrToMd5(Sifre))
                    {
                        Mesaj = "Kullanıcı bilgileri hatalı";
                    }
                    else
                    {
                        KullaniciKisi = KisiKaydi;
                        result= true;
                    }

                }
            }
            catch (Exception ex)
            {

                Mesaj = ex.Message;
            }


            return result;

        }

    }
}
