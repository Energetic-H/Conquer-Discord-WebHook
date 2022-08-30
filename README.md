# Conquer-Discord-WebHook
Simple C# written code to send messages embeds and files using discord webhooks.

> Setting Up
```CSharp
1-Go to visual studio
2-Press on Tools
3-Chose NuGet Packages
4-Search for: System.Net.Http;
```
Don`t forget take copy from folder 64 from data/playerface and set it in your site files
> Code Example

```CSharp
Discord.DiscordSendMessage(msg._From, msg.__Message, $"GameLink/64/{client.Player.Face}.jpg");
```
