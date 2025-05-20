﻿using Spectre.Console;
using System.Runtime.CompilerServices;
using static LibraryManagementSystem.Enums;

namespace LibraryManagementSystem;

class UserInterface
{
    private BooksController booksController = new BooksController();

    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuOption>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<MenuOption>()));

            switch (choice)
            {
                case MenuOption.ViewBooks:
                    booksController.ViewBooks();
                    break;
                case MenuOption.AddBook:
                    booksController.AddBook();
                    break;
                case MenuOption.DeleteBook:
                    booksController.DeleteBook();
                    break;
            }
        }
    }
}
