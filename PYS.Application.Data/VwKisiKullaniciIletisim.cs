//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PYS.Application.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VwKisiKullaniciIletisim
    {
        public int KisiId { get; set; }
        public Nullable<int> UnvanId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<long> Tc { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<bool> Silik { get; set; }
        public byte[] KayitVersiyonu { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.Guid> Guid { get; set; }
        public int IletisimId { get; set; }
        public int IletisimTipiId { get; set; }
        public string IletisimTipi { get; set; }
        public string Iletisim { get; set; }
        public string Unvan { get; set; }
        public string FirmaKodu { get; set; }
        public Nullable<int> FirmaUnvan { get; set; }
    }
}
