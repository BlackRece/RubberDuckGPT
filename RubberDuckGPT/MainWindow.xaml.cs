using System;
using System.Windows;

namespace RubberDuckGPT {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        private const string SETTINGS_FILE = "appsettings.json";

        private readonly AppSettings _appSettings = AppSettings.LoadSettings(SETTINGS_FILE);
        private readonly ChatGptService _chatGptService;

        public MainWindow() {
            InitializeComponent();

            _chatGptService = new ChatGptService(_appSettings.OpenAIApiKey);
        }

        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            string userMessage = txtUserInput.Text;

            if(!string.IsNullOrEmpty(userMessage))
            {
                string chatResponse = _chatGptService.GetChatGptResponse(userMessage);
                DisplayChatResponse(chatResponse);
            }
        }

        private void DisplayChatResponse(string chatResponse)
        {
            txtChatDisplay.AppendText("AI: " + chatResponse + Environment.NewLine);
        }

        private void MenuItemSettings_Click(object sender, RoutedEventArgs e)
        {
            var settingsDialog = new SettingsDialog(_appSettings);
            if(settingsDialog.ShowDialog() == true)
            {
                _appSettings.SaveSettings(SETTINGS_FILE);
            }
            //SettingsDialog settingsDialog = new SettingsDialog(_appSettings);
            //settingsDialog.ShowDialog();
        }
    }
}