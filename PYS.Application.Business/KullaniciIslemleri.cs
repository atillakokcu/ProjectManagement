using PYS.Application.Data;
using PYS.Application.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYS.Application.Business
{
    public class KullaniciIslemleri : BaseKullaniciIslemleri
    {
        public TResult GetToken(string KullaniciBilgisi, string Sifre)
        {
            VwKisiKullaniciIletisim KullaniciKisi = null;
            TResult Result = new TResult();
            Result.StatusCode = -1000;
            string Message, Token = "";
            bool Success = base.DoLogin(KullaniciBilgisi, Sifre, out KullaniciKisi, out Message);

            if (Success)
            {
                if (KullaniciKisi != null)
                {
                    Token = DoCreateToken(KullaniciKisi);

                }
                Result.Success = Success;
                Result.StatusCode = 200;
                Result.Data.Add(Token);
            }
            return Result;
        }

        public TResult Register(TKullaniciKisiIletisim KisiBilgileri)
        {

            return DoRegister(KisiBilgileri);

        }


        private string DoCreateToken(VwKisiKullaniciIletisim KullaniciKisi)
        {

            string Result = KullaniciKisi.Guid.Value + "|" +
                                             KullaniciKisi.FirmaKodu + "|" +
                                             KullaniciKisi.KisiId + "|" +
                                             KullaniciKisi.Tc + "|" +
                                             KullaniciKisi.KullaniciAdi + "|" +
                                             KullaniciKisi.KullaniciId + "|" +
                                             Guid.NewGuid().ToString();

            Result = PYSSecurity.Encrypt(Result, KullaniciKisi.Guid.Value.ToString());
            return Result;


        }



    }
}
