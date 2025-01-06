using DependencyInversionPrinciple;

var server = new ChatServer();

var client1 = new ChatClient("Per", server);

client1.Say("Hello");