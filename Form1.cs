using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "005bec145c16210a8131e65a05b7391c";


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", SearchBox.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                conditionlbl.Text = Info.weather[0].main;
                detailslbl.Text = Info.weather[0].description;
                SunsetValuelbl.Text = convertDateTime(Info.sys.sunset).ToString();
                SunriseValuelbl.Text = convertDateTime(Info.sys.sunrise).ToString();
                WindValuelbl.Text = Info.wind.speed.ToString();
                PressureValuelbl.Text = Info.main.pressure.ToString();

                string hello = "hello";


            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(millisec).ToLocalTime();
            return dateTime;

        }
    }
}
