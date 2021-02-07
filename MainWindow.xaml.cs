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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace BH2ShipHashEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private void init()
        {
            // initialization function
            R = new TextBox();
            G = new TextBox();
            B = new TextBox();
            this.NewHash = new TextBox();
            this.OldHash = new TextBox();
            this.Debug = new TextBox();
            this.Elite = new CheckBox();
            Stat1 = new TextBox();
            Stat2 = new TextBox();
            Stat3 = new TextBox();
            Stat4 = new TextBox();
            Stat5 = new TextBox();
            Stat6 = new TextBox();
            Stat7 = new TextBox();
            Mission2_Score = new TextBox();
            Mission1_Phrase = new TextBox();
            Mission2_PhraseDifficulty = new TextBox();
            Mission3_Phrase = new TextBox();
            Mission3_Unknown = new TextBox();
            Mission3_Score = new TextBox();
            Mission3_Difficulty = new TextBox();
            FirstName = new TextBox();
            LastName = new TextBox();
            MkX = new TextBox();
            UnknownBits = new TextBox();
        }
        public bool IsElite = false;
        public char[] hash;
        // our actual ship hash
        public string GenerateShip()
        {
            // first, dictate the available characters.
            char[] available_bits = "0123456789abcdef".ToCharArray();
            // next, randomly roll for each ship section.
            List<char> shipHash = new List<char>();
            // next, randomly seed the ship generator.
            Random rand = new Random();
            shipHash.Add('0');
            // next, we randomly generate some stats.
            for(int i = 1; i < 32; i++)
            {
                shipHash.Add(available_bits[rand.Next(0, available_bits.Length)]);
            }
            return string.Join("", shipHash);
            // finally, return a string that is the ship hash.
        }

        public void AutoSetFields(char[] shipHash)
        {
            if(shipHash[0] == '!')
            {
                this.Elite.IsChecked = true;
            } else
            {
                this.Elite.IsChecked = false;
            }
            // now that we have established elite status, establish statline stuff.
            // shipHash[0]

            Stat1.Text = shipHash[1].ToString();
            Stat2.Text = shipHash[2].ToString();
            Stat3.Text = shipHash[3].ToString();
            Stat4.Text = shipHash[4].ToString();
            Stat5.Text = shipHash[5].ToString();
            Stat6.Text = shipHash[6].ToString();
            Stat7.Text = shipHash[7].ToString();

            // shipHash[7] is last index.
            switch (shipHash[8])
            {
                case '0':
                    Manufacturers.Text = "Brute Inc. [0]";
                    break;
                case '1':
                    Manufacturers.Text = "Brute Inc. [1]";
                    break;
                case '2':
                    Manufacturers.Text = "Mosquito Systems [2]";
                    break;
                case '3':
                    Manufacturers.Text = "Mosquito Systems [3]";
                    break;
                case '4':
                    Manufacturers.Text = "Cra$y Thief Hackers [4]";
                    break;
                case '5':
                    Manufacturers.Text = "Cra$y Thief Hackers [5]";
                    break;
                case '6':
                    Manufacturers.Text = "Cra$y Thief Hackers [6]";
                    break;
                case '7':
                    Manufacturers.Text = "Scorched Earth [7]";
                    break;
                case '8':
                    Manufacturers.Text = "Scorched Earth [8]";
                    break;
                case '9':
                    Manufacturers.Text = "General Industries [9]";
                    break;
                case 'a':
                    Manufacturers.Text = "General Industries [a]";
                    break;
                case 'b':
                    Manufacturers.Text = "Blazer Labs [b]";
                    break;
                case 'c':
                    Manufacturers.Text = "Blazer Labs [c]";
                    break;
                case 'd':
                    Manufacturers.Text = "War Bringer Cartel [d]";
                    break;
                case 'e':
                    Manufacturers.Text = "War Bringer Cartel [e]";
                    break;
                case 'f':
                    Manufacturers.Text = "War Bringer Cartel [f]";
                    break;
                default:
                    Manufacturers.Text = "Brute Inc. [1]";
                    break;
            }

            // shipHash[9]
            Mission2_Score.Text = shipHash[9].ToString();
            Mission1_Phrase.Text = shipHash[10].ToString() + shipHash[11].ToString() + shipHash[12].ToString() + shipHash[13].ToString();
            Mission2_PhraseDifficulty.Text = shipHash[14].ToString() + shipHash[15].ToString();
            Mission3_Phrase.Text = shipHash[16].ToString() + shipHash[17].ToString();
            Mission3_Unknown.Text = shipHash[18].ToString();
            Mission3_Score.Text = shipHash[19].ToString();

            // shipHash[20] is skipped, so shipHash[21].
            Mission3_Difficulty.Text = shipHash[21].ToString();
            FirstName.Text = shipHash[22].ToString() + shipHash[23].ToString();
            LastName.Text = shipHash[24].ToString() + shipHash[25].ToString();
            MkX.Text = shipHash[26].ToString();
            UnknownBits.Text = shipHash[27].ToString() + shipHash[28].ToString() + shipHash[29].ToString() + shipHash[30].ToString() + shipHash[31].ToString();
        }
        public MainWindow()
        {
            init();
            InitializeComponent();
            MainWindow1.Background = App.settings.window_color;
        }

        private void Manufacturers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem itm = (ComboBoxItem)Manufacturers.SelectedItem;
            hash = this.NewHash.Text.ToCharArray();
            switch (itm.Content)
            {
                case "Brute Inc. [0]":
                    hash[8] = '0';
                    break;
                case "Brute Inc. [1]":
                    hash[8] = '1';
                    break;
                case "Mosquito Systems [2]":
                    hash[8] = '2';
                    break;
                case "Mosquito Systems [3]":
                    hash[8] = '3';
                    break;
                case "Cra$y Thief Hackers [4]":
                    hash[8] = '4';
                    break;
                case "Cra$y Thief Hackers [5]":
                    hash[8] = '5';
                    break;
                case "Cra$y Thief Hackers [6]":
                    hash[8] = '6';
                    break;
                case "Scorched Earth [7]":
                    hash[8] = '7';
                    break;
                case "Scorched Earth [8]":
                    hash[8] = '8';
                    break;
                case "General Industries [9]":
                    hash[8] = '9';
                    break;
                case "General Industries [a]":
                    hash[8] = 'a';
                    break;
                case "Blazer Labs [b]":
                    hash[8] = 'b';
                    break;
                case "Blazer Labs [c]":
                    hash[8] = 'c';
                    break;
                case "War Bringer Cartel [d]":
                    hash[8] = 'd';
                    break;
                case "War Bringer Cartel [e]":
                    hash[8] = 'e';
                    break;
                case "War Bringer Cartel [f]":
                    hash[8] = 'f';
                    break;
                default:
                    this.NewHash.Text = "ERROR: ComboBox content not recognized.  Tell ceph.";
                    break;
            }
            this.NewHash.Text = new string(hash);
        }

        private void OldHash_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(OldHash.Text.Length == 32)
            {
                this.NewHash.Text = this.OldHash.Text;
                AutoSetFields(this.OldHash.Text.ToLower().ToCharArray());
            } else
            {
                this.NewHash.Text = "Invalid hash!";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Elite_Checked(object sender, RoutedEventArgs e)
        {
            IsElite = !IsElite;
            hash = this.NewHash.Text.ToCharArray();
            switch (IsElite)
            {
                case true:
                    hash[0] = '!';
                    break;
                case false:
                    hash[0] = '0';
                    break;
                default:
                    // can't even get here LOL
                    break;
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat1_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat1.Text.Length == 1)
            {
                hash[1] = char.Parse(Stat1.Text.ToLower());
            } else
            {
                this.Debug.Text = "Stat1.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat2_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat2.Text.Length == 1)
            {
                hash[2] = char.Parse(Stat2.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Stat2.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat3_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat3.Text.Length == 1)
            {
                hash[3] = char.Parse(Stat3.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Stat3.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat4_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat4.Text.Length == 1)
            {
                hash[4] = char.Parse(Stat4.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Stat4.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat5_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat5.Text.Length == 1)
            {
                hash[5] = char.Parse(Stat5.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Stat5.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat6_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat6.Text.Length == 1)
            {
                hash[6] = char.Parse(Stat6.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Stat6.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Stat7_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Stat7.Text.Length == 1)
            {
                hash[7] = char.Parse(Stat7.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Stat7.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission2_Score_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Mission2_Score.Text.Length == 1)
            {
                hash[9] = char.Parse(Mission2_Score.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Mission2_Score.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission1_Phrase_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            char[] temp;
            if (Mission1_Phrase.Text.Length == 4)
            {
                temp = Mission1_Phrase.Text.ToLower().ToCharArray();
                hash[10] = temp[0];
                hash[11] = temp[1];
                hash[12] = temp[2];
                hash[13] = temp[3];
            }
            else
            {
                this.Debug.Text = "Mission1_Phrase.Text.Length is 0 or >4, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission2_PhraseDifficulty_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            char[] temp;
            if (Mission2_PhraseDifficulty.Text.Length == 2)
            {
                temp = Mission2_PhraseDifficulty.Text.ToLower().ToCharArray();
                hash[14] = temp[0];
                hash[15] = temp[1];
            }
            else
            {
                this.Debug.Text = "Mission2_PhraseDifficulty.Text.Length is 0 or >2, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission3_Phrase_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            char[] temp;
            if (Mission3_Phrase.Text.Length == 2)
            {
                temp = Mission3_Phrase.Text.ToLower().ToCharArray();
                hash[16] = temp[0];
                hash[17] = temp[1];
            }
            else
            {
                this.Debug.Text = "Mission3_Phrase.Text.Length is 0 or >2, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission3_Unknown_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Mission3_Unknown.Text.Length == 1)
            {
                hash[18] = char.Parse(Mission3_Unknown.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Mission3_Unknown.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission3_Score_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Mission3_Score.Text.Length == 1)
            {
                hash[19] = char.Parse(Mission3_Score.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Mission3_Score.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void Mission3_Difficulty_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (Mission3_Difficulty.Text.Length == 1)
            {
                hash[21] = char.Parse(Mission3_Difficulty.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "Mission3_Difficulty.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            char[] temp;
            if (FirstName.Text.Length == 2)
            {
                temp = FirstName.Text.ToLower().ToCharArray();
                hash[22] = temp[0];
                hash[23] = temp[1];
            }
            else
            {
                this.Debug.Text = "FirstName.Text.Length is 0 or >2, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            char[] temp;
            if (LastName.Text.Length == 2)
            {
                temp = LastName.Text.ToLower().ToCharArray();
                hash[24] = temp[0];
                hash[25] = temp[1];
            }
            else
            {
                this.Debug.Text = "LastName.Text.Length is 0 or >2, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void MkX_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            if (MkX.Text.Length == 1)
            {
                hash[26] = char.Parse(MkX.Text.ToLower());
            }
            else
            {
                this.Debug.Text = "MkX.Text.Length is 0 or >1, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void UnknownBits_TextChanged(object sender, TextChangedEventArgs e)
        {
            hash = this.NewHash.Text.ToCharArray();
            char[] temp;
            if (UnknownBits.Text.Length == 5)
            {
                temp = UnknownBits.Text.ToLower().ToCharArray();
                hash[27] = temp[0];
                hash[28] = temp[1];
                hash[29] = temp[2];
                hash[30] = temp[3];
                hash[31] = temp[4];
            }
            else
            {
                this.Debug.Text = "UnknownBits.Text.Length is 0 or >2, no changes made.";
            }
            this.NewHash.Text = new string(hash);
        }

        private void RandShipGen_Click(object sender, RoutedEventArgs e)
        {
            this.NewHash.Text = GenerateShip();
            AutoSetFields(NewHash.Text.ToCharArray());
        }

        private void CopyToClipboard_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(NewHash.Text);
        }

        private void PasteFromClipboard_Click(object sender, RoutedEventArgs e)
        {
            OldHash.Text = Clipboard.GetText();
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            App.settings.window_color = new SolidColorBrush(Color.FromRgb(byte.Parse(R.Text), byte.Parse(G.Text), byte.Parse(B.Text)));
            MainWindow1.Background = App.settings.window_color;
        }

        private void MD5HasherButton_Click(object sender, RoutedEventArgs e)
        {
            Window md5hasher = new MD5Hasher();
            md5hasher.Show();
        }
    }
}
