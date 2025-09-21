// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using MissingNumberApp;
using MissingNumberApp.Infrastructure;

Console.WriteLine("Missing Number Finder App");

var serviceProvider = new ServiceCollection()
    .AddTransient<IInputProvider, ConsoleInputProvider>()
    .AddTransient<IOutputProvider, ConsoleOutputProvider>()
    .AddTransient<IMissingNumberFinder, MissingNumberFinder>()
    .BuildServiceProvider();
IMissingNumberFinder numberFinder = serviceProvider.GetRequiredService<IMissingNumberFinder>();
numberFinder.FindMissingNumbers();

