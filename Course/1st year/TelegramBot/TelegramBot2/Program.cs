using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using TelegramBot2.Handlers;
using System;
using System.Net.Http;
using System.Collections;
using GTranslatorAPI;


class Program
{
    private static ITelegramBotClient _botclient;
    private static ReceiverOptions _receiverOptions;
    static System.Func<Telegram.Bot.ITelegramBotClient, System.Exception, Telegram.Bot.Polling.HandleErrorSource, System.Threading.CancellationToken, System.Threading.Tasks.Task> func;

    static async Task Main()
    {
        _botclient = new TelegramBotClient("8008835585:AAHj7j1RvTlfy2KIh2SYVX-dCeOzT-mlsYs");
        _receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = new[]
            {
                UpdateType.Message,
            },
        };
        using var cts = new CancellationTokenSource();

        _botclient.StartReceiving(BotMethods.UpdateHandler, func, _receiverOptions, cts.Token);

        var me = await _botclient.GetMeAsync();
        Console.WriteLine($"{me.FirstName} запущен");

        await Task.Delay(-1);

        string s = "Hello world!";
        Console.WriteLine(s);

    }

}
