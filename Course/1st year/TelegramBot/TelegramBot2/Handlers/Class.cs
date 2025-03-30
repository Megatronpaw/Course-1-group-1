using System.Text.Json.Nodes;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;



namespace TelegramBot2.Handlers
{
    public class BotMethods
    {
        private static readonly List<Tuple<string, string, string>> Dictionary = new()
        {
            new("привет", "hello", "hallo"),
            new("пока", "goodbye", "tschüß"),
            new("день", "day", "tag"),
            new("ночь", "night", "nach"),
            new("мама", "mother", "mama"),
            new("папа", "father", "papa"),
            new("брат", "brother", "иruder"),
            new("сестра", "sister ", "schwester"),
        };
        public static async Task UpdateHandler(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                var message = update.Message;
                switch (update.Type)
                {
                    case UpdateType.Message:
                        {
                            var chat = message.Chat;

                            if (message.Text.ToLower() == "/start")
                            {
                                var username = message.From?.Username;
                                await botClient.SendTextMessageAsync(
                                    chat.Id,
                                    $"Привет, {username}! Этот бот позволяет переводить сообщения на английский и на немецкий."
                                );
                            }
                            var clearMessage = update.Message?.Text?.Trim().ToLower();
                            string translateMessage = "Извините, я вас не понимаю";

                            foreach (var word in Dictionary)
                            {
                                if (word.Item1 == clearMessage)
                                {
                                    translateMessage = $"English: {word.Item2}\nDeutsch: {word.Item3}";
                                }
                            }

                            await botClient.SendTextMessageAsync(
                                chat.Id,
                                translateMessage
                                );
                        }
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static async Task ErrorHandler(ErrorEventArgs args)
        {
            await Task.CompletedTask;
        }
    }
}
