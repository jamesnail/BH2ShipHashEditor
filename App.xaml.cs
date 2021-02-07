using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Security.Cryptography;

namespace BH2ShipHashEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// 
    /// This controls how the app handles passing of internal information around.
    /// 
    /// </summary>

    public class Settings : Window
    {
        public SolidColorBrush window_color { get; set; }
        public Settings()
        {
            window_color = new SolidColorBrush(Color.FromRgb(byte.Parse("184"), byte.Parse("134"), byte.Parse("11")));
        }
    }
    public partial class App : Application
    {
        public static Settings settings = new Settings();
    }
}
