﻿using LibraryManagementSystem;
using Spectre.Console;

var menuChoices = new MenuOption[3] { MenuOption.ViewBooks, MenuOption.AddBook, MenuOption.DeleteBook };


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
            BooksController.ViewBooks();
            break;
        case MenuOption.AddBook:
            BooksController.AddBook();
            break;
        case MenuOption.DeleteBook:
            BooksController.DeleteBook();
            break;
    }
}

enum MenuOption
{
    ViewBooks,
    AddBook,
    DeleteBook
}



