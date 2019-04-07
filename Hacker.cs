using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{


    //Game State
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;

    // Start is called before the first frame update
    void Start() {
      //  ShowMainMenu();
        ShowMainMenu();
        print("Hello" + "World");
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        print("Hello Console");
        Terminal.WriteLine("The Dangerous Game of Dangers!");
        Terminal.WriteLine(" ");
        var greeting = "Detective Neha,";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine(" Where would you like to go?");
        Terminal.WriteLine(" Press 1 for Cute Words and Phrases");
        Terminal.WriteLine(" Press 2 for Nick Names");
        Terminal.WriteLine(" Press 3 for Things only YOU KNOW");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter Selection: ");
    }
    //this should only decide how to handle input, not actually do it
    void OnUserInput(string input)
    {
        //if(input == "1") 
        //{
        //    print("You chose Level 1")
        //}
        if (input == "menu") // we can always go directly to main menu
        {
            ShowMainMenu();
        }
        if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "kothi")
        {
            Terminal.WriteLine("Life is like a box of chocolates, you never know what you're gonna get!");

        }
        else if (input == "2")
        {
            level = 2;
            StartGame();

        }
        else
        {
            Terminal.WriteLine("Please Choose a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chose level " + level);
    }
} 
