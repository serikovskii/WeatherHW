using System.Windows;
using WheatherHW.Models;

namespace WheatherHW
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void InitialCity()
        {
            var city = new Request();
            cityName.Text = city.Query;
        }

        
    }
}
