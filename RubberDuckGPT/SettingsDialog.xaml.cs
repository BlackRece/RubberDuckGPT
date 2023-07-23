using System.Windows;

namespace RubberDuckGPT
{
    /// <summary>
    /// Interaction logic for SettingsDialog.xaml
    /// </summary>
    public partial class SettingsDialog : Window
    {
        public AppSettings Settings { get; }

        public SettingsDialog(AppSettings settings)
        {
            InitializeComponent();
            Settings = settings;
            DataContext = settings;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Settings.OpenAIApiKey = txtApiKey.Text;
            Settings.SaveSettings("appsettings.json");
            Close();
            //DialogResult = true;
        }
    }
}
