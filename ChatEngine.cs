using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    internal class ChatEngine
    {
        private string userName = "";
        private string favouriteTopic = "";
        private string lastTopic = "";
        private Random rng = new Random();

        private Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>();
        // TODO: populate with your keywords and responses, e.g.:
        // keywordResponses["password"] = new List<string> { "...", "..." };

        private List<string> worriedWords = new List<string>();
        // TODO: add words like "worried", "scared", "nervous"
        public string GetResponse(string input)
        {
            string question = input.ToLower();

            if (string.IsNullOrWhiteSpace(question)) { /* TODO */ }
            // TODO: sentiment check (Step 4)
            // TODO: keyword check (Step 3)
            // TODO: follow-up check using lastTopic (Step 2)
            // TODO: fallback response

            return ""; // replaced in Step 6
        

        }

        private void CaptureUserInfo(string input)
        {
            // TODO: detect and store things like favouriteTopic
        }

        private ChatEngine engine = new ChatEngine();

        private void btnSend_Click(object sender, EventArgs e)
        {
            string reply = engine.GetResponse(ChatInput2.Text);

            // TODO: display reply in ChatInput, clear ChatInput2
        }

    }
}
