// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        var client = new TelegramBotClient("6538399106:AAHUb3Ik_Cv0iz7Y4kFqUNk9PnOGpGCt0jE");

        var reciverOptions = new ReceiverOptions
        {
            AllowedUpdates = new UpdateType[]
            {
                UpdateType.ChatJoinRequest,
                UpdateType.Message,
                UpdateType.EditedMessage,
            }
        };

        while (true)
        {
            client.StartReceiving(UpdateHandler, ErrorHandler, reciverOptions);
        }
    }

    private static async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
    {
        if (update == null)
        {
            return;
        }
        if (update.Type != UpdateType.Message)
        {
            return;
        }
        var message = update.Message;
        switch (message!.Type)
        {
            case MessageType.Text:
                // Echo each Message
                await client.SendTextMessageAsync(message.Chat.Id, message.Text);
                break;
        }

    }


    private static Task ErrorHandler(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        throw new Exception(exception.Message);
    }
}