using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json; 
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace personelApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GetPersonelListAsync();
        }


        public class Personel
        {
            public int Id { get; set; }

            [Column("AdSoyad")]
            public string AdSoyad { get; set; } = string.Empty;

            [Column("KullanilanIzin")]
            public int KullanilanIzin { get; set; }

            [Column("KalanIzin")]
            public int KalanIzin { get; set; }

            [Column("Maas")]
            public decimal? Maas { get; set; }

            [Column("Unvan")]
            public string Unvan { get; set; } = string.Empty;
        }

        private async Task GetPersonelListAsync()
        {


            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            };

            var client = new HttpClient(handler);
            var response = await client.GetAsync("https://localhost:7001/api/Personeller");





            try
            {

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();


                    List<Personel> personeller = JsonConvert.DeserializeObject<List<Personel>>(jsonResponse);


                    dgvPersoneller.DataSource = personeller;


                    foreach (var p in personeller)
                    {
                        Console.WriteLine($"Ad: {p.AdSoyad}, Unvan: {p.Unvan}, Maaş: {p.Maas}");
                    }
                }
                else
                {
                    Console.WriteLine("API çağrısı başarısız oldu. Kod: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            GetPersonelListAsync();
        }


        private void dgvPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPersoneller.Rows[e.RowIndex];

                txtAdSoyad.Text = row.Cells["AdSoyad"].Value?.ToString();
                textBox4.Text = row.Cells["Unvan"].Value?.ToString();
                txtMaas.Text = row.Cells["Maas"].Value?.ToString();
                txtKullanilanIzin.Text = row.Cells["KullanilanIzin"].Value?.ToString();
                txtKalanIzin.Text = row.Cells["KalanIzin"].Value?.ToString();
            }
        }


        private void dgvPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var yeniPersonel = new Personel
            {
                AdSoyad = txtAdSoyad.Text,
                Unvan = textBox4.Text,
                Maas = decimal.Parse(txtMaas.Text),
                KullanilanIzin = int.Parse(txtKullanilanIzin.Text),
                KalanIzin = int.Parse(txtKalanIzin.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7001/");

                HttpResponseMessage response = await client.PostAsJsonAsync("api/personeller", yeniPersonel);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Personel başarıyla eklendi!");
                    await GetPersonelListAsync();
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız: " + response.StatusCode);
                }
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells["ID"].Value);

                var guncellenenPersonel = new Personel
                {
                    Id = id,
                    AdSoyad = txtAdSoyad.Text,
                    Unvan = textBox4.Text,
                    Maas = decimal.Parse(txtMaas.Text),
                    KullanilanIzin = int.Parse(txtKullanilanIzin.Text),
                    KalanIzin = int.Parse(txtKalanIzin.Text)
                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7001/");

                    HttpResponseMessage response = await client.PutAsJsonAsync($"api/personeller/{id}", guncellenenPersonel);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Personel başarıyla güncellendi.");
                        await GetPersonelListAsync();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız: " + response.StatusCode);
                    }
                }
            }
        }

      
            private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin.");
                return;
            }
         
            var selectedRow = dgvPersoneller.CurrentRow;
            if (selectedRow.Cells["Id"].Value == null)
            {
                MessageBox.Show("Seçilen satırda ID bulunamadı.");
                return;
            }

            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync($"https://localhost:7001/api/Personeller/{id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Personel başarıyla silindi.");
                    await GetPersonelListAsync(); 
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu. Kod: " + response.StatusCode);
                }
            }
        }

    }
}


