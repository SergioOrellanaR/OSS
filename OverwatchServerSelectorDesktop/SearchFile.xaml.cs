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
using System.Windows.Navigation;
using System.Configuration;
using System.Xml;

namespace OverwatchServerSelectorDesktop
{
    /// <summary>
    /// Lógica de interacción para SearchFile.xaml
    /// </summary>
    public partial class SearchFile : Window
    {
        public SearchFile()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["OverwatchRoute"].ToString()))
            {
                txtSavedPath.Text = (string)App.Current.Properties["FirstValue"];
            }
            else
            {
                if (string.IsNullOrEmpty((string)App.Current.Properties["FirstValue"]))
                {
                    txtSavedPath.Text = ConfigurationManager.AppSettings["OverwatchRoute"].ToString();
                }
                else
                {
                    txtSavedPath.Text = (string)App.Current.Properties["FirstValue"];
                }
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".exe";
            //dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                if (dlg.SafeFileName.Equals("Overwatch.exe"))
                {
                    // Open document 
                    string filename = dlg.FileName;
                    UpdateConfigKey("OverwatchRoute", filename);
                }
                else
                {
                    MessageBox.Show("Please, select your Overwatch file", "Invalid file", MessageBoxButton.OK, MessageBoxImage.Warning);
                    btnSearch_Click(sender, e);
                }
            }
        }

        //public void UpdateConfigKey(string strKey, string newValue)
        //{
        //    string AppConfigFileRoute = "..\\..\\App.config";
        //    XmlDocument xmlDoc = new XmlDocument();
        //    string ConfigRoute = AppDomain.CurrentDomain.BaseDirectory + AppConfigFileRoute;
        //    xmlDoc.Load(ConfigRoute);
        //    //if (!ConfigKeyExists(strKey))
        //    //{
        //    //    throw new ArgumentNullException("Key", "<" + strKey + "> not find in the configuration.");
        //    //}
        //    XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
        //    foreach (XmlNode childNode in appSettingsNode)
        //    {
        //        if (childNode.Attributes["key"].Value == strKey)
        //            childNode.Attributes["value"].Value = newValue;
        //    }
        //    xmlDoc.Save(ConfigRoute);
        //    xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

        //    MessageBox.Show("Overwatch path selected Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        //    Application.Current.Properties["FirstValue"] = newValue;
        //    this.Close();
        //}

        public void UpdateConfigKey(string strKey, string newValue)
        {
            string AppConfigFileRoute = "OverwatchServerSelectorDesktop.exe.config"; // <- Release profile.
            //string AppConfigFileRoute = "..\\..\\App.config"; <-- DEV Profile
            XmlDocument xmlDoc = new XmlDocument();
            string ConfigRoute = AppDomain.CurrentDomain.BaseDirectory + AppConfigFileRoute;
            xmlDoc.Load(ConfigRoute);
            //if (!ConfigKeyExists(strKey))
            //{
            //    throw new ArgumentNullException("Key", "<" + strKey + "> not find in the configuration.");
            //}
            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == strKey)
                    childNode.Attributes["value"].Value = newValue;
            }
            xmlDoc.Save(ConfigRoute);
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            
            MessageBox.Show("Overwatch path selected Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Properties["FirstValue"] = newValue;
            this.Close();
        }

        public bool ConfigKeyExists(string strKey)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\App.config");
            XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == strKey)
                    return true;
            }
            return false;
        }
    }
}