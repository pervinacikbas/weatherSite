using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech;
using System.Speech.AudioFormat;
using System.Globalization;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Net.Http;
using System.Threading.Channels;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;

namespace weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EQLPKL0\\SQLEXPRESS;Initial Catalog=havaDurumuDb;Integrated Security=True");

        public void button1_Click(object sender, EventArgs e)
        {

            var apiKey = "f3d0e2a3dfcc549a117025cfc9c5156d";
            var apiUrl = "https://api.openweathermap.org/data/2.5/weather";
            string city = Convert.ToString(konum.Text).ToUpper();
            var url = $"{apiUrl}?q={city}&appid={apiKey}&units=Metric";



            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                List<string> konumlar = new List<string>()
        {
            "Adana",
            "Adýyaman",
            "Afyonkarahisar",
            "Aðrý",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydýn",
            "Balýkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankýrý",
            "Çorum",
            "Denizli",
            "Diyarbakýr",
            "Edirne",
            "Elazýð",
            "Erzincan",
            "Erzurum",
            "Eskiþehir",
            "Gaziantep",
            "Giresun",
            "Gümüþhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "Ýstanbul",
            "Ýzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kýrklareli",
            "Kýrþehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraþ",
            "Mardin",
            "Muðla",
            "Muþ",
            "Nevþehir",
            "Niðde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdað",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Þanlýurfa",
            "Uþak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kýrýkkale",
            "Batman",
            "Þýrnak",
            "Bartýn",
            "Ardahan",
            "Iðdýr",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce",
            "Adalar", "Arnavutköy", "Ataþehir", "Avcýlar", "Baðcýlar", "Bahçelievler", "Bakýrköy",
            "Baþakþehir", "Bayrampaþa", "Beþiktaþ", "Beykoz", "Beylikdüzü", "Beyoðlu", "Büyükçekmece",
            "Çatalca", "Çekmeköy", "Esenler", "Esenyurt", "Eyüp", "Fatih", "Gaziosmanpaþa", "Güngören",
            "Kadýköy", "Kaðýthane", "Kartal", "Küçükçekmece", "Maltepe", "Pendik", "Sancaktepe", "Sarýyer",
            "Silivri", "Sultanbeyli", "Sultangazi", "Þile", "Þiþli", "Tuzla", "Ümraniye", "Üsküdar", "Zeytinburnu",
            "Akyurt", "Altýndað", "Ayaþ", "Bala", "Beypazarý", "Çamlýdere", "Çankaya", "Çubuk",
            "Elmadað", "Etimesgut", "Evren", "Gölbaþý", "Güdül", "Haymana", "Kalecik", "Kýzýlcahamam",
            "Mamak", "Nallýhan", "Polatlý", "Pursaklar", "Sincan", "Þereflikoçhisar", "Yenimahalle"
        };
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;

                    // JSON verisini bir JObject olarak ayrýþtýrma
                    JObject jsonData = JObject.Parse(content);

                    string cityName = jsonData["name"].ToString().ToUpper(new System.Globalization.CultureInfo("en-US"));
                    double temperature = Convert.ToDouble(jsonData["main"]["temp"]);
                    double feelLike = Convert.ToDouble(jsonData["main"]["feels_like"]);
                    string stuaciton = jsonData["weather"][0]["main"].ToString();
                    string wind = jsonData["wind"]["speed"].ToString();
                    DateTime anlikTarih = DateTime.Now;
                    string weatherIconCode = jsonData["weather"][0]["icon"].ToString();// burayý düzelt
                    string ýconLink = $"C:\\Users\\lenovo\\Desktop\\Metal yapý staj\\{weatherIconCode}.png";

                    labelCity.Text = "Konum: " + cityName.ToUpper();
                    labelTemperature.Text = "Sýcaklýk: " + temperature.ToString();
                    labelHissedilen.Text = "Hissedilen sýcaklýk: " + feelLike.ToString();
                    labelHavaDurumu.Text = "Hava durumu: " + stuaciton;
                    labelWind.Text = "Rüzgar hýzý: " + wind;
                    labelTarih.Text = "Tarih: " + anlikTarih.ToString();
                    Iconbox.Image = Image.FromFile(ýconLink);
                }
                else
                {
                    char firstChar = city[0];
                    for (int i = 0; i < konumlar.Count; i++)
                    {
                        string index = konumlar[i];
                        char indexFirstChar = index[0];
                        if (indexFirstChar == firstChar)
                            listBoxKonum.Items.Add(index);
                    }
                    MessageBox.Show("Hata: " + response.ReasonPhrase + " Önerilerden seçebilirisniz.", "Hata");
                    konum.Clear();
                }
            }

        }

        private void labelCity_Click(object sender, EventArgs e)
        {
            Size = new Size(800, 80);
        }

        private void listBoxKonum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = listBoxKonum.Items[listBoxKonum.SelectedIndex].ToString();
            konum.Text = selected;
            listBoxKonum.Items.Clear();

        }

        private void recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            konum.Text += e.Result.Text;
        }

        public SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        private void buttonKaydedici_Click_1(object sender, EventArgs e)
        {

            konum.Clear();
            recognizer.SetInputToDefaultAudioDevice();
            Grammar grammar = new DictationGrammar();
            recognizer.LoadGrammar(grammar);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognition_SpeechRecognized);
            recognizer.RecognizeAsync(RecognizeMode.Multiple);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            recognizer.RecognizeAsyncStop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}