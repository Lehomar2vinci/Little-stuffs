using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

class Program
{
    private DiscordSocketClient _client;

    public async Task MainAsync()
    {
        _client = new DiscordSocketClient();

        _client.Log += LogAsync;
        _client.Ready += ReadyAsync;
        _client.MessageReceived += MessageReceivedAsync;

        await _client.LoginAsync(TokenType.Bot, "THE TOKEN IS HERE");
        await _client.StartAsync();

        await Task.Delay(-1);
    }

    private Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log);
        return Task.CompletedTask;
    }

    private Task ReadyAsync()
    {
        Console.WriteLine($"{_client.CurrentUser} est connecté !");
        return Task.CompletedTask;
    }

    private async Task MessageReceivedAsync(SocketMessage message)
    {
        if (message is not SocketUserMessage userMessage)
            return;

        if (userMessage.Author.IsBot || message.Author.Id == _client.CurrentUser.Id) return;

            string content = userMessage.Content.ToLower();

        if (content.Contains("coucou"))
        {
            // Remplace "mot-clé" par le mot-clé que tu veux détecter.

            var channel = userMessage.Channel as ISocketMessageChannel;
            if (channel != null)
            {
                await channel.SendMessageAsync("Coucou Aria !");
            }
        }
    }

    public static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();
}
