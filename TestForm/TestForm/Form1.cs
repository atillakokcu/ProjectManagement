using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PYS.Application.Security;
using PYS.Application.Business;
using PYS.Application.Data;
using Newtonsoft.Json;

namespace PYS.Application.Security.TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TxtEncryptText.Text = PYS.Application.Security.PYSSecurity.Encrypt(TxtCleantext.Text.ToString(), "asdasdas");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDecryptText.Text = PYS.Application.Security.PYSSecurity.Decrypt(TxtEncryptText.Text.ToString(), "asdsa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kullaniciIslemleri = new Business.KullaniciIslemleri();
            string mesaj;
            string Token = kullaniciIslemleri.GetToken("adasd", "asdasd", out mesaj);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TKullaniciKisiIletisim kullaniciKisiIletisim = new TKullaniciKisiIletisim();
            kullaniciKisiIletisim.Kullanicilar = new TblKullanicilar();
            kullaniciKisiIletisim.Kisi = new TblKisi();
            kullaniciKisiIletisim.KisiIletisim = new List<TblKisiIletisim>();
            kullaniciKisiIletisim.KisiIletisim.Add(new TblKisiIletisim(){

            });
            
            kullaniciKisiIletisim.KisiFirma = new TblKisiFirma();
            

            string JsonText = JsonConvert.SerializeObject(kullaniciKisiIletisim);

            textBox1.Text = JsonText;
        }
    }
}
