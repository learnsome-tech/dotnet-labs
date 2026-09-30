using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IMessage, Message>();
using var provider = services.BuildServiceProvider();
var message = provider.GetRequiredService<IMessage>();
Console.WriteLine(message.Text);

public interface IMessage { string Text { get; } }
public sealed class Message : IMessage { public string Text => "resolved"; }
