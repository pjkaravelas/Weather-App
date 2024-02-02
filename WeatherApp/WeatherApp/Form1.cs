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

        string apikey = "b388c81e5747ebac9e4e46e5d03cac16";

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            getWeather();
        }

        double lon;
        double lat;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",cities.Text, apikey);
                var json = web.DownloadString(url);
                WeatherFetch.rootfetch Info = JsonConvert.DeserializeObject<WeatherFetch.rootfetch>(json);

                labcondition.Text = Info.weather[0].main;
                labdetails.Text = Info.weather[0].description;
                labtemp.Text = (Info.main.temp - 273.15).ToString();
                labhumidity.Text = Info.main.humidity.ToString();
                labfeelslike.Text = (Info.main.feels_like-273.15).ToString();
                labwindspeed.Text = Info.wind.speed.ToString();
                labpressure.Text = Info.main.pressure.ToString();
                labname.Text = cities.Text;

                lon = Info.coord.lon;
                lat = Info.coord.lat;

            }
        }

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast/daily?lat={0}&lon={1}&cnt=3&appid={3}", lat, lon, apikey);
                var json = web.DownloadString(url);
                ForecastFetch.forecastinfo forecastInfo = JsonConvert.DeserializeObject<ForecastFetch.forecastinfo>(json);

            }
        }
    }
}
