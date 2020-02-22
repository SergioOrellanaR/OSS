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
using OverwatchServerSelector;

namespace OverwatchServerSelectorDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RegionBlockerHandler Handler;
        private const string USWest1Rule = "OverwatchSSBlocksUSW1";
        private const string USWest2Rule = "OverwatchSSBlocksUSW2";
        private const string USEast1Rule = "OverwatchSSBlocksUSE1";
        private const string USEast2Rule = "OverwatchSSBlocksUSE2";
        private const string BrazilRule = "OverwatchSSBlocksBR";
        private const string KoreaRule = "OverwatchSSBlocksKR";
        private const string CanadaRule = "OverwatchSSBlocksCAN";
        private const string IrelandRule = "OverwatchSSBlocksEUW1";
        private const string EnglandRule = "OverwatchSSBlocksEUW2";
        private const string FranceRule = "OverwatchSSBlocksEUW3";
        private const string GermanyRule = "OverwatchSSBlocksEUC";
        private const string StockholmRule = "OverwatchSSBlocksEUN";
        private const string JapanRule = "OverwatchSSBlocksJP";
        private const string SingaporeRule = "OverwatchSSBlocksSP";
        private const string AustraliaRule = "OverwatchSSBlocksOCE";
        private const string IndiaRule = "OverwatchSSBlocksIND";
        private const string ChinaRule = "OverwatchSSBlocksCHN";
        private const string ChileRule = "OverwatchSSBlocksCL";
        private const string ArgentinaRule = "OverwatchSSBlocksARG";

        public MainWindow()
        {
            string overwatchPath = System.Configuration.ConfigurationManager.AppSettings["OverwatchRoute"].ToString();
            Handler = new RegionBlockerHandler();

            if (string.IsNullOrEmpty(overwatchPath))
            {
                SearchFile win2 = new SearchFile();
                win2.ShowDialog();
                if (!string.IsNullOrEmpty((string)App.Current.Properties["FirstValue"]))
                {
                    overwatchPath = (string)App.Current.Properties["FirstValue"];
                }
                else
                {
                    this.Close();
                }
            }
            initializeOSS(overwatchPath);
        }

        private void initializeOSS(string overwatchPath)
        {
            RegionRuleCreator ruleCreator = new RegionRuleCreator(overwatchPath);
            DeleteAllOutboundRules();
            ruleCreator.CreateAllOutboundRules();
            InitializeComponent();
            EnableAllServers();
        }

        private void CkbUSWest_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(USWest1Rule);
            Handler.enableRegion(USWest2Rule);
        }

        private void CkbUSWest_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(USWest1Rule);
            Handler.disableRegion(USWest2Rule);
        }

        private void CkbUSEast_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(USEast1Rule);
            Handler.enableRegion(USEast2Rule);
        }

        private void CkbUSEast_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(USEast1Rule);
            Handler.disableRegion(USEast2Rule);
        }

        private void CkbBrazil_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(BrazilRule);
        }

        private void CkbBrazil_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(BrazilRule);
        }

        private void CkbEuropeWest_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(EnglandRule);
            Handler.enableRegion(FranceRule);
            Handler.enableRegion(IrelandRule);
        }

        private void CkbEuropeWest_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(EnglandRule);
            Handler.disableRegion(FranceRule);
            Handler.disableRegion(IrelandRule);
        }

        private void CkbSouthKorea_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(KoreaRule);
        }

        private void CkbSouthKorea_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(KoreaRule);
        }

        private void CkbCanada_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(CanadaRule);
        }

        private void CkbCanada_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(CanadaRule);
        }

        private void CkbEuropeCentral_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(GermanyRule);
        }

        private void CkbEuropeCentral_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(GermanyRule);
        }

        private void CkbEuropeNorth_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(StockholmRule);
        }

        private void CkbEuropeNorth_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(StockholmRule);
        }

        private void CkbJapan_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(JapanRule);
        }

        private void CkbJapan_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(JapanRule);
        }

        private void CkbSingapore_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(SingaporeRule);
        }

        private void CkbSingapore_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(SingaporeRule);
        }

        private void CkbAustralia_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(AustraliaRule);
        }

        private void CkbAustralia_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(AustraliaRule);
        }

        private void CkbIndia_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(IndiaRule);
        }

        private void CkbIndia_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(IndiaRule);
        }

        private void CkbChina_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(ChinaRule);
        }

        private void CkbChina_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(ChinaRule);
        }

        private void CkbChile_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(ChileRule);
        }

        private void CkbChile_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(ChileRule);
        }

        private void CkbArgentina_Checked(object sender, RoutedEventArgs e)
        {
            Handler.enableRegion(ArgentinaRule);
        }

        private void CkbArgentina_Unchecked(object sender, RoutedEventArgs e)
        {
            Handler.disableRegion(ArgentinaRule);
        }

        private void btnDonate_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/serorellanar");
        }

        private void MniSearch_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;
            foreach (Window w in Application.Current.Windows)
            {
                if (w is SearchFile)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                SearchFile newwindow = new SearchFile();
                newwindow.ShowDialog();
            }

            string settedPath = (string)App.Current.Properties["FirstValue"];

            if (string.IsNullOrEmpty(settedPath))
            {
                settedPath = System.Configuration.ConfigurationManager.AppSettings["OverwatchRoute"].ToString();
            }
            initializeOSS(settedPath);
        }

        private void MniHowTo_Click(object sender, RoutedEventArgs e)
        {
            bool isWindowOpen = false;
            foreach (Window w in Application.Current.Windows)
            {
                if (w is How_to_use)
                {
                    isWindowOpen = true;
                    w.Activate();
                }
            }

            if (!isWindowOpen)
            {
                How_to_use newwindow = new How_to_use();
                newwindow.Show();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DeleteAllOutboundRules();
        }


        private void DeleteAllOutboundRules()
        {
            Handler.DeleteRestrictions();
        }

        private void EnableAllServers()
        {
            //Borrar al ampliar
            CkbUSWest.IsEnabled = false;
            CkbUSEast.IsEnabled = false;
            CkbSouthKorea.IsEnabled = false;
            CkbEuropeWest.IsEnabled = false;
            CkbEuropeCentral.IsEnabled = false;
            CkbEuropeNorth.IsEnabled = false;
            CkbCanada.IsEnabled = false;
            CkbJapan.IsEnabled = false;
            CkbSingapore.IsEnabled = false;
            CkbAustralia.IsEnabled = false;
            CkbIndia.IsEnabled = false;
            CkbChina.IsEnabled = false;

            CkbUSWest.Foreground = Brushes.Red;
            CkbUSEast.Foreground = Brushes.Red;
            CkbSouthKorea.Foreground = Brushes.Red;
            CkbEuropeWest.Foreground = Brushes.Red;
            CkbEuropeCentral.Foreground = Brushes.Red;
            CkbEuropeNorth.Foreground = Brushes.Red;
            CkbCanada.Foreground = Brushes.Red;
            CkbJapan.Foreground = Brushes.Red;
            CkbSingapore.Foreground = Brushes.Red;
            CkbAustralia.Foreground = Brushes.Red;
            CkbIndia.Foreground = Brushes.Red;
            CkbChina.Foreground = Brushes.Red;
            //
            CkbBrazil.IsChecked = true;
            CkbChile.IsChecked = true;
            CkbArgentina.IsChecked = true;
        }

        private void MniExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
