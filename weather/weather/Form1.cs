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
            "Ad�yaman",
            "Afyonkarahisar",
            "A�r�",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Ayd�n",
            "Bal�kesir",
            "Bilecik",
            "Bing�l",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "�anakkale",
            "�ank�r�",
            "�orum",
            "Denizli",
            "Diyarbak�r",
            "Edirne",
            "Elaz��",
            "Erzincan",
            "Erzurum",
            "Eski�ehir",
            "Gaziantep",
            "Giresun",
            "G�m��hane",
            "Hakk�ri",
            "Hatay",
            "Isparta",
            "Mersin",
            "�stanbul",
            "�zmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "K�rklareli",
            "K�r�ehir",
            "Kocaeli",
            "Konya",
            "K�tahya",
            "Malatya",
            "Manisa",
            "Kahramanmara�",
            "Mardin",
            "Mu�la",
            "Mu�",
            "Nev�ehir",
            "Ni�de",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirda�",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "�anl�urfa",
            "U�ak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "K�r�kkale",
            "Batman",
            "��rnak",
            "Bart�n",
            "Ardahan",
            "I�d�r",
            "Yalova",
            "Karab�k",
            "Kilis",
            "Osmaniye",
            "D�zce",
            "Adalar", "Arnavutk�y", "Ata�ehir", "Avc�lar", "Ba�c�lar", "Bah�elievler", "Bak�rk�y",
            "Ba�ak�ehir", "Bayrampa�a", "Be�ikta�", "Beykoz", "Beylikd�z�", "Beyo�lu", "B�y�k�ekmece",
            "�atalca", "�ekmek�y", "Esenler", "Esenyurt", "Ey�p", "Fatih", "Gaziosmanpa�a", "G�ng�ren",
            "Kad�k�y", "Ka��thane", "Kartal", "K���k�ekmece", "Maltepe", "Pendik", "Sancaktepe", "Sar�yer",
            "Silivri", "Sultanbeyli", "Sultangazi", "�ile", "�i�li", "Tuzla", "�mraniye", "�sk�dar", "Zeytinburnu",
            "Akyurt", "Alt�nda�", "Aya�", "Bala", "Beypazar�", "�aml�dere", "�ankaya", "�ubuk",
            "Elmada�", "Etimesgut", "Evren", "G�lba��", "G�d�l", "Haymana", "Kalecik", "K�z�lcahamam",
            "Mamak", "Nall�han", "Polatl�", "Pursaklar", "Sincan", "�erefliko�hisar", "Yenimahalle"
        };
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;

                    // JSON verisini bir JObject olarak ayr��t�rma
                    JObject jsonData = JObject.Parse(content);

                    string cityName = jsonData["name"].ToString().ToUpper(new System.Globalization.CultureInfo("en-US"));
                    double temperature = Convert.ToDouble(jsonData["main"]["temp"]);
                    double feelLike = Convert.ToDouble(jsonData["main"]["feels_like"]);
                    string stuaciton = jsonData["weather"][0]["main"].ToString();
                    string wind = jsonData["wind"]["speed"].ToString();
                    DateTime anlikTarih = DateTime.Now;
                    string weatherIconCode = jsonData["weather"][0]["icon"].ToString();// buray� d�zelt
                    string �conLink = $"C:\\Users\\lenovo\\Desktop\\Metal yap� staj\\{weatherIconCode}.png";

                    labelCity.Text = "Konum: " + cityName.ToUpper();
                    labelTemperature.Text = "S�cakl�k: " + temperature.ToString();
                    labelHissedilen.Text = "Hissedilen s�cakl�k: " + feelLike.ToString();
                    labelHavaDurumu.Text = "Hava durumu: " + stuaciton;
                    labelWind.Text = "R�zgar h�z�: " + wind;
                    labelTarih.Text = "Tarih: " + anlikTarih.ToString();
                    Iconbox.Image = Image.FromFile(�conLink);
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
                    MessageBox.Show("Hata: " + response.ReasonPhrase + " �nerilerden se�ebilirisniz.", "Hata");
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