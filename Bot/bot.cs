using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

class Program
{
    private DiscordSocketClient? _client;
    private readonly string _token = "the token here"; 
    static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        new Program().RunBotAsync().GetAwaiter().GetResult();
    }

    public async Task RunBotAsync()
    {
        _client = new DiscordSocketClient();
        _client.Log += Log;

        RegisterCommands();

        await _client.LoginAsync(TokenType.Bot, _token);

        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private Task Log(LogMessage arg)
    {
        Console.WriteLine(arg);
        return Task.CompletedTask;
    }

    private void RegisterCommands()
    {
        _client.MessageReceived += HandleCommandAsync;
    }

    private async Task HandleCommandAsync(SocketMessage arg)
    {
        var message = arg as SocketUserMessage;
        var context = new SocketCommandContext(_client, message);

        Console.WriteLine($"Message reçu de {message.Author.Username}: {message.Content}"); // Log pour le débogage

        if (message.Author.IsBot) return;

        if (message.Content.ToLower() == "!random")
        {
            Random rand = new();
            int randomNumber = rand.Next(1, 1000001); // Génère un nombre entre 1 et un million
            await context.Channel.SendMessageAsync($"Le nombre aléatoire généré est : {randomNumber}");
        }
    }
}






