using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace ChatBot.Dialogs
{
    [LuisModel("21875dc6-997f-407e-83f3-fc4fc425b598", "8078c36b3d7b4a03a5bac4d42a631198", domain: "westus.api.cognitive.microsoft.com")]
    [Serializable]
    public class RootDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Je n'ai pas compris");
        }
        [LuisIntent("Greetings")]
        public async Task Greetings(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Bonjour");
        }
        [LuisIntent("SetMessage")]
        public async Task SetMessage(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Que dois-je envoyer");
        }
    }
}