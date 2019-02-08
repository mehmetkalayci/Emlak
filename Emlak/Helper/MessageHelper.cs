using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.Helper
{
    public class MessageHelper
    {
        public static DialogResult KayitSil()
        {
            return MessageBox.Show("Seçilen kaydı silmek istediğinize emin misiniz?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult SecilenSatirlariSil()
        {
            return MessageBox.Show("Seçilen satırları silmek istediğinize emin misiniz?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult YazdirilsinMi()
        {
            return MessageBox.Show("Makbuz yazdırılsın mı?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static void KayitSilindi(int num = -1)
        {
            if (num == -1)
            {
                MessageBox.Show("Kayıt silindi!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(num + " adet kayıt silindi!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void KayitEklendi()
        {
            MessageBox.Show("Kayıt eklendi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void KayitBulunamadi()
        {
            MessageBox.Show("Belirtilen kayıt veritabanında bulunamadı!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void IslemTipiSecin()
        {
            MessageBox.Show("İşlem tipi seçin.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        

        public static void TaksitBulunamadi()
        {
            MessageBox.Show("Belirtilen ödeme bilgisi veritabanında bulunamadı!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void KayitGuncellendi()
        {
            MessageBox.Show("Kayıt güncellendi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void BeklenmedikHata()
        {
            MessageBox.Show("Beklenmedik hata meydana geldi! Kayıt işlemi tamamlanamadı!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void GridSatirSecmediniz()
        {
            MessageBox.Show("Kayıt seçmediniz!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void TaksitÖdemesiTamamlandi()
        {
            MessageBox.Show("Taksit ödendi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SozlesmeKaydedildi()
        {
            MessageBox.Show("Sözleşme kaydedildi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SozlesmeGuncellendi()
        {
            MessageBox.Show("Sözleşme güncellendi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void TarafZatenEkli()
        {
            MessageBox.Show("Kişi taraf olarak zaten eklendi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void KiraKaydedildi()
        {
            MessageBox.Show("Kira kaydedildi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void AktarilacakVeriBulunamadi()
        {
            MessageBox.Show("Aktarılacak veri yok.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult KasayaIslensinMi()
        {
            return MessageBox.Show("Kasaya işlensin mi?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static void KasayaIslendi()
        {
            MessageBox.Show("Kasaya işlendi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult SozlesmeIptalEdilsinMi()
        {
            return MessageBox.Show("Seçilen sözleşmeyi iptal etmek istediğinizden emin misiniz?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult SozlesmeAktiveEdilsinMi()
        {
            return MessageBox.Show("Seçilen sözleşmeyi aktive etmek istediğinizden emin misiniz?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static void SozlesmeIptalEdildi()
        {
            MessageBox.Show("Sözleşme iptal edildi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SozlesmeAktiveEdildi()
        {
            MessageBox.Show("Sözleşme aktive edildi.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void AyarlarKaydedildi()
        {
            MessageBox.Show("Ayarlar kaydedildi!\nDeğişikleri almak için programı yeniden başlatmanız gerekir.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}