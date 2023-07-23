using RestSharp;

namespace RubberDuckGPT
{
    public class ChatGptService
    {
        private const string ChatGptEndpoint = "https://api.openai.com/v1/engines/davinci/completions";

        private string OpenAIApiKey = "YOUR_OPENAI_API_KEY";

        public ChatGptService(string openAIApiKey) 
        {
            OpenAIApiKey = openAIApiKey;
        }

        public string GetChatGptResponse(string userMessage)
        {
            RestRequest request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Authorization", "Bearer " + OpenAIApiKey);
            request.AddParameter("model", "davinci");
            request.AddParameter("prompt", "User: " + userMessage + "\nAI:");
            request.AddParameter("temperature", "0.7");
            request.AddParameter("max_tokens", "150");

            RestClient client = new RestClient(ChatGptEndpoint);
            RestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
