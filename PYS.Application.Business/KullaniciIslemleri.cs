using PYS.Application.Data;
using PYS.Application.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYS.Application.Business
{
    internal class KullaniciIslemleri:BaseKullaniciIslemleri
    {
        public string GetToken(string KullaniciBilgisi, string Sifre,out string Mesaj)
        {
            VwKisiKullaniciIletisim KullaniciKisi = null;
            string Result = "";
            
            bool Success= base.DoLogin(KullaniciBilgisi, Sifre,out KullaniciKisi,out Mesaj);

            if (Success)
            {
                if (KullaniciKisi!=null)
                {
                    Result = KullaniciKisi.Guid.Value + "|" +
                                            KullaniciKisi.FirmaKodu + "|" +
                                            KullaniciKisi.KisiId + "|" +
                                            KullaniciKisi.Tc + "|" +
                                            KullaniciKisi.KullaniciAdi + "|" +
                                            KullaniciKisi.KullaniciId + "|" +
                                            Guid.NewGuid().ToString();

                    Result = PYSSecurity.Encrypt(Result, KullaniciKisi.Guid.Value.ToString());
                }
                

            }
            return Result;
        }


    }
}
