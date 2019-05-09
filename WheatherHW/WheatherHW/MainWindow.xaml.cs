using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WheatherHW.Models;
using WheatherHW.Serialize;

namespace WheatherHW
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CityWeather("astana");
        }

        public void CityWeather(string cityName)
        {
            var json = new DeserializeJson();
            var result = json.Start(cityName);

            if (result.Data.Request == null)
            {
                MessageBox.Show("Введите город на латинице или такого города нет");
                return;
            }
            else
            {
                var hourlyToWeather = 4;
                cityNameBlock.Text = result.Data.Request.ToArray()[0].Query.ToUpper();

                for (int i = 0; i < 7; i++)
                {
                    imageDay7.Source = ImageInit(result.Data.Weather.ToArray()[i].Hourly.ToArray()[hourlyToWeather].WeatherIconUrl.ToArray()[0].Value);
                    groupDay7.Header = result.Data.Weather.ToArray()[i].Date;
                    day7.Text = ($"{result.Data.Weather.ToArray()[i].Hourly.ToArray()[hourlyToWeather].TempC}'C" +
                        $"\n{result.Data.Weather.ToArray()[i].Hourly.ToArray()[hourlyToWeather].FeelsLikeC}'C" +
                         $"\n{result.Data.Weather.ToArray()[i].Hourly.ToArray()[hourlyToWeather].Humidity}% " +
                        $"\n{result.Data.Weather.ToArray()[i].Hourly.ToArray()[hourlyToWeather].WindspeedKmph}km/h");
                    
                    switch (i + 1)
                    {
                        case 1: groupDay1.Header = groupDay7.Header; day1.Text = day7.Text; imageDay1.Source = imageDay7.Source; break;
                        case 2: groupDay2.Header = groupDay7.Header; day2.Text = day7.Text; imageDay2.Source = imageDay7.Source; break;
                        case 3: groupDay3.Header = groupDay7.Header; day3.Text = day7.Text; imageDay3.Source = imageDay7.Source; break;
                        case 4: groupDay4.Header = groupDay7.Header; day4.Text = day7.Text; imageDay4.Source = imageDay7.Source; break;
                        case 5: groupDay5.Header = groupDay7.Header; day5.Text = day7.Text; imageDay5.Source = imageDay7.Source; break;
                        case 6: groupDay6.Header = groupDay7.Header; day6.Text = day7.Text; imageDay6.Source = imageDay7.Source; break;
                    }

                }
            }
        }

        public BitmapImage ImageInit(string path)
        {

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path);
            bitmap.EndInit();

            return bitmap;
        }

        public void Button_Click(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (string.IsNullOrEmpty(searchCityNameBox.Text))
                {
                    MessageBox.Show("Введите корректное название города");
                    return;
                }
                CityWeather(searchCityNameBox.Text);
            }
        }
    }
}
