using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeLens_AI
{
    public partial class Form1 : Form
    {
        // Using the latest stable endpoint for Gemini 1.5 Flash
        private const string ApiKey = "AIzaSyDp1ujZW1UnLm356MJppI-MM71ISU3_5sU";
        private const string ApiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            string rawInput = txtInputCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(rawInput))
            {
                lblStatus.Text = "? Error: Input is empty";
                lblStatus.ForeColor = Color.IndianRed;
                return;
            }

            btnAnalyze.Enabled = false;
            btnAnalyze.Text = "Analyzing...";
            lblStatus.Text = "? Processing with Gemini AI...";
            lblStatus.ForeColor = Color.FromArgb(0, 122, 204);

            txtOutputCode.Text = "Thinking...";
            txtExplanation.Text = "Generating summary...";

            try
            {
                string prompt = "Act as CodeLens AI. Take this code and return: " +
                                "1. The same code with professional comments. " +
                                "2. A separator '---SEP---' " +
                                "3. A 3-sentence summary of what the code does.\n\n" + rawInput;

                string fullResponse = await CallGeminiApi(prompt);

                string[] parts = fullResponse.Split(new[] { "---SEP---" }, StringSplitOptions.None);

                if (parts.Length >= 2)
                {
                    txtOutputCode.Text = CleanMarkdown(parts[0]);
                    txtExplanation.Text = parts[1].Trim();
                }
                else
                {
                    txtOutputCode.Text = CleanMarkdown(fullResponse);
                    txtExplanation.Text = "Analysis finished.";
                }

                lblStatus.Text = "? Success!";
                lblStatus.ForeColor = Color.FromArgb(106, 153, 85);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "? API Error";
                MessageBox.Show("Error: " + ex.Message, "Gemini Error");
            }
            finally
            {
                btnAnalyze.Enabled = true;
                btnAnalyze.Text = "Generate Logic ?";
            }
        }

        private async Task<string> CallGeminiApi(string promptText)
        {
            using (HttpClient client = new HttpClient())
            {
                var payload = new
                {
                    contents = new[] { new { parts = new[] { new { text = promptText } } } }
                };

                string jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // Building URI with key appended
                var response = await client.PostAsync(new Uri(ApiUrl + ApiKey), content);
                string responseJson = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var json = JObject.Parse(responseJson);
                    return json["candidates"][0]["content"]["parts"][0]["text"].ToString();
                }
                else
                {
                    // This will now show the exact reason for 'NotFound' or other status codes
                    throw new Exception($"Gemini error {response.StatusCode}\n{responseJson}");
                }
            }
        }

        private string CleanMarkdown(string input)
        {
            return input.Replace("```csharp", "").Replace("```javascript", "")
                        .Replace("```python", "").Replace("```cpp", "")
                        .Replace("```", "").Trim();
        }
    }
}