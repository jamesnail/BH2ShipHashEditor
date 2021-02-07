using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace BH2ShipHashEditor
{
    /// <summary>
    /// Interaction logic for MD5Hasher.xaml
    /// </summary>
    public partial class MD5Hasher : Window
    {
        public string MD5Hash(string s)
        {
            // a function that hashes something using MD5.
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(s));
            byte[] result = md5.Hash;
            StringBuilder generatedHash = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                generatedHash.Append(result[i].ToString("x2"));
            }
            return generatedHash.ToString();
        }
        public MD5Hasher()
        {
            InitializeComponent();
            this.Background = App.settings.window_color;
        }

        private void ToHash_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultingHash.Text = MD5Hash(ToHash.Text);
        }

        private void ResultingHash_TextChanged(object sender, TextChangedEventArgs e)
        {
            // do nothing if final hash is changed.
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToHash.Text = Clipboard.GetText();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(ResultingHash.Text);
        }
    }
}
