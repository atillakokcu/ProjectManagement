using PYS.Application.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PYS.Application.Security;
using System.CodeDom;
using System.Security.Cryptography;
using System.Security.Policy;

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

                if (KisiKaydi == null)
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
                        result = true;
                    }

                }
            }
            catch (Exception ex)
            {

                Mesaj = ex.Message;
            }


            return result;

        }

        // hatakodu = -1001
        internal TResult DoRegister(TKullaniciKisiIletisim KisiBilgileri)// TResult tipinde değer alacaz ama geri değer döndürdüğümüz verinin içinde şifre olmayacak
        {

            TResult result = null;
            try
            {
                TblKisi Kisi = KisiBilgileri.Kisi;
                TblKullanicilar Kullanicilar = KisiBilgileri.Kullanicilar;
                TblKisiFirma KisiFirma = KisiBilgileri.KisiFirma;
                List<TblKisiIletisim> KisiIletisimler = KisiBilgileri.KisiIletisim;

                if (ExistUser(KisiBilgileri))
                {
                    Db.TblKisi.Add(Kisi);
                    Db.SaveChanges();

                    Kullanicilar.KisiId = Kisi.KisiId;
                    Kullanicilar.Sifre = PYSSecurity.StrToMd5(Kullanicilar.Sifre);
                    Db.TblKullanicilar.Add(Kullanicilar);
                    Db.SaveChanges();

                    KisiFirma.KisiId = Kisi.KisiId;
                    Db.TblKisiFirma.Add(KisiFirma);
                    Db.SaveChanges();

                    foreach (var Iletisim in KisiIletisimler)
                    {
                        Iletisim.KisiId = Kisi.KisiId;
                        Db.TblKisiIletisim.Add(Iletisim);
                        Db.SaveChanges();
                    }
                    Kullanicilar.Sifre = "";
                    result.StatusCode = 200;
                    result.Success = true;
                    result.Data.Add(Kisi);
                    result.Data.Add(Kullanicilar);
                    result.Data.Add(KisiFirma);
                    result.Data.Add(KisiIletisimler);


                }

            }
            catch (Exception  )
            {

                result.Message = "Hata Meydana geldi";
                result.StatusCode = -1001;
            }

            return result;
        }


        private bool ExistUser(TKullaniciKisiIletisim KisiBilgileri) // kullanıcı varmı yokmu kontrol edecek sonrasında doregister metoduna gidip kaydedecek
        {
            bool result = false;

            var Kisi = (from data in Db.TblKisi where data.Tc == KisiBilgileri.Kisi.Tc select data).FirstOrDefault();

            if (Kisi != null)
            {
                result = true;


            }
            return result;

        }


    }
}
