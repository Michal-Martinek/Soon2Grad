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

namespace Otazka20_WPF_scitacka {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }

        private void Vstup1_GotFocus(object sender, RoutedEventArgs e) {
            Vstup1.Text = "";
        }
        private void Vstup2_GotFocus(object sender, RoutedEventArgs e) {
            Vstup2.Text = "";
        }

        private float? parseVstup(string s) {
            float res = 0;
            if (!float.TryParse(s, out res)) {
                return null;
            }
            return res;

        }
        private void Secti_Click(object sender, RoutedEventArgs e) {
            float? a, b;
            a = parseVstup(Vstup1.Text);
            b = parseVstup(Vstup2.Text);

            string vysledek = "Neocekavany vstup";
            if (a != null && b != null) {
                float sum = a.Value + b.Value;
                vysledek = sum.ToString();
            }
            Vysledek.Text = vysledek;
        }

        private void Konec_Click(object sender, RoutedEventArgs e) {
            // Zobrazí potvrzovací dialogové okno
            MessageBoxResult result = MessageBox.Show("Opravdu chcete ukončit program?", "Potvrzení", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // Pokud uživatel klikne na "Yes", ukončí aplikaci
            if (result == MessageBoxResult.Yes) {
                Application.Current.Shutdown();  // Ukončí aplikaci
            }

        }
    }
}
