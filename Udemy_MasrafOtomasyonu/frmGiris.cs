using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;

namespace Udemy_MasrafOtomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            //if (OnDenetleme())
            if(OnDenetleme() == true)
                return; // Hata varsa alttaki kodların işlememesi sağlanır.

            PersonelIslemleri pi = new PersonelIslemleri();
            Personel personel = pi.PersonelLogin(txtKullaniciAdi.Text, txtSifre.Text);

            if (personel != null)
            {
                // Giriş başarılı..
                this.Hide();

                frmAnaForm frm = new frmAnaForm();
                frm.GirisYapanPersonel = personel;
                frm.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı.","Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool OnDenetleme()
        {
            bool result = false;

            errorProvider1.Clear();     // Eğer ekranda hata gösteriliyorsa bunları temizler..

            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi))
            {
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı adı boş geçilemez..");
                result = true;
            }

            if (string.IsNullOrEmpty(sifre))
            {
                errorProvider1.SetError(txtSifre, "Şifre boş geçilemez..");
                result = true;
            }

            return result;
        }
    }
}
