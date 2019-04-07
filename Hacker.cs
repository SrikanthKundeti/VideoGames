﻿using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game Configuration Data
    // string[] level1Passwords = {"cookie cutter shark","bruch","yes","no","4eva", "so you're saying that you ain't got rhythm", "what happened to me was a TRAGEDY", "see" };
    // string[] level2Passwords = { "tungadu", "goocher","ammulu","pakodee", "aloo bonda", "pikachu", "moonpie", "dumpling", "bugji","kothi" };
  const string menuhint = "You may type menu at any time";
      string[] level1Passwords = { "bruch", "yes", "no", "4eva", "see" }; //"so you're saying that you ain't got rhythm", "what happened to me was a TRAGEDY",// "see" };
    string[] level2Passwords = { "tungadu", "goocher", "ammulu", "pakodee", "pikachu", "moonpie", "dumpling", "bugji", "kothi" };
    string[] level3Passwords = { "bartimaeus", "tony", "nathaniel", "peralta", "holt", "terry", "oliver" };

    //Game State
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password = null;
    int counter = 0;


   //  Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
        print("Hello" + "World");
    }

    void Update()
    {
        int index1 = Random.Range(0, level1Passwords.Length);
        print(index1);
        int index2 = Random.Range(0, level2Passwords.Length);
        print(index2);
        int index3 = Random.Range(0, level3Passwords.Length);
        print(index3);
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
        Terminal.WriteLine(" Press 3 for Inside Jokes");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Enter Selection: ");
    }
    //this should only decide how to handle input, not actually do it
    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go directly to main menu
        {
            ShowMainMenu();
        }
        if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
           // SetPassword();
            //AskForPassword();
            //if(input == "1")
            //{

            //    Terminal.ClearScreen();
            //    Terminal.WriteLine("LEVEL 1");
            //    Terminal.WriteLine(password.Anagram());
            //    Terminal.WriteLine("Enter Password: ");
            //}
            //if(input == "2")
            //{

            //    Terminal.ClearScreen();
            //    Terminal.WriteLine("LEVEL 2");
            //    Terminal.WriteLine(password.Anagram());
            //    Terminal.WriteLine("Enter Password: ");
            //}
           
                       // password = input;
                        //if (level == 1)
                        //{
                            //if (password == level1Passwords[0] || password == "Cookie Cutter Shark") //todo make random later
                            //{
                            //    DisplayWinScreen();

                            //}
                            //else
                            //{
                            //    Terminal.ClearScreen();
                            //    Terminal.WriteLine("LEVEL 1");
                            //    Terminal.WriteLine("kiecoo tcuert karsh");
                            //    Terminal.WriteLine("Enter Password: ");
                            //    counter++;
                            //}
                           // AskForPassword();
                            //if(counter == 1)
                            //{
                            //    Terminal.WriteLine("It's okay Detective....we are not all Sherlock Holmes!");
                            //}

                            //if (counter == 2)
                            //{
                            //    Terminal.WriteLine("Fool me once, strike one. Fool me twice, strike three!");
                            //}
                            //if (counter == 3)
                            //{

                            //    Terminal.WriteLine("Life be like that sometimes!");
                            //}
                            //if (counter == 4)
                            //{
                            //    Terminal.WriteLine("It's okay Detective Ammulu.... Tony Stark still loves you!");
                            //}
                            //if (counter == 5)
                            //{

                            //    Terminal.WriteLine("The nuclear codes are beginning to activate detective!");
                            //}
                            //if (counter == 6)
                            //{

                            //    Terminal.WriteLine("......(One Million Guesses Later)......");
                            //}
                            //if (counter == 7)
                            //{

                            //    Terminal.WriteLine("Life is like a box of chocolates.....");
                            //}
                            //if (counter == 8)
                            //{

                            //    Terminal.WriteLine("My name is Neha, I am ..... :) ");
                            //}
                            //if (counter == 9)
                            //{

                            //    Terminal.WriteLine("So........ You still haven't guessed it huh?");
                            //}
                            //if (counter == 10)
                            //{

                            //    Terminal.WriteLine("You have my respects Detective Neha, when I'm done half of the Universe will still be alive.");
                            //}
                            //if (counter == 11)
                            //{

                            //    Terminal.WriteLine("Why is Gamora?");
                            //}
                            //if (counter == 12)
                            //{

                            //    Terminal.WriteLine("I am a Tungadu... sorry Spoliers for Puzzle 2");
                            //}
                        }
                        //else if (level == 2)
                        //{
                        //    //if (password == level2Passwords[0] || password == "Tungadu") //todo make random
                        //    //{
                        //    //    DisplayWinScreen();
                        //    //}
                        //    //else
                        //    //{
                        //    //    Terminal.ClearScreen();
                        //    //    Terminal.WriteLine("LEVEL 2");
                        //    //    Terminal.WriteLine("Enter Password: ");
                        //    //}
                        //    CheckPassword(input);
                        //}
                      
                    
                }
           // }
       
  

     void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
     //   Terminal.WriteLine("Congratulations! Please type menu to return to the main menu.");
    }
    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("Congratulations Detective Ammulu! Type 'menu' for MENU");
                Terminal.WriteLine(@" 


              _.-""{               _.-
        .-*'``     ``*---..-i__.-`:'
     .'*   ((   ,         _ .---._\
      `-'.._'._(__...--*""` `""     ``
                ");
               

                break;
            case 2:
              //  Terminal.WriteLine("Congratulations Detective Ammulu!");
                Terminal.WriteLine(@"
      {|'--.
     {{\    \
     |/`'--./=.
     `\.---' `\\
          |\  ||
          | |//
           \//_/|
           //\__/
          //
Congratulations Detective Ammulu! 
                ");
                break;
            case 3:
                Terminal.WriteLine(@"
 _________________
/ BADGE OF HONOR  \
|  /-\  Detective  \
| | O |  Neha      |
|  \_/  Pithani    |
 \_________________/
Thank You for Playing!

                                                ");
                break;
            default:
                Debug.LogError("Invalid Level Reached!");
                break;
        }
    }
    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");
        bool alsoValid = (input == "3");
        if(isValidLevelNumber || alsoValid)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else if (input == "kothi") //easter egg
        {
            Terminal.WriteLine("Life is like a box of chocolates, you never know what you're gonna get!");

        }
        else if(input == "I Hate Thanos" || input == "I HATE THANOS" || input == "THANOS SUCKS")
        {
            Terminal.WriteLine("Good Evening Tony");
        }
        else if (input == "Holt" || input == "holt")
        {
            Terminal.WriteLine("Good Morning Jake.... Do you want to get some pizza and stop bad guys?");
        }
        else if(input == "i love you more" || input == "i love you more than anything" || input == "no i love you more")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Haha! Is that a joke? I LOVE YOU MORE");
            Terminal.WriteLine("  1   1  ");
            Terminal.WriteLine(" 1 1  1 1 ");
            Terminal.WriteLine("1  1 1  1");
            Terminal.WriteLine(" 1  1  1 ");
            Terminal.WriteLine("  1   1  ");
            Terminal.WriteLine("   1 1   ");
            Terminal.WriteLine("    1    ");
        }
        else if(input == "i love you most")
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("  1   1  ");
            Terminal.WriteLine(" 1 1  1 1 ");
            Terminal.WriteLine("1  1 1  1");
            Terminal.WriteLine(" 1  1  1 ");
            Terminal.WriteLine("  1   1  ");
            Terminal.WriteLine("   1 1   ");
            Terminal.WriteLine("    1    ");
            Terminal.WriteLine("Hahaha! I'm so lucky.");
            Terminal.WriteLine("I Love You");
        } else if(input == "menu")
        {
            Terminal.WriteLine("Ahhhh! We meet again Detective!");
        }
        else
        {
            Terminal.WriteLine("Please Choose a valid level");
            Terminal.WriteLine(menuhint);
        }
    }

    void AskForPassword()
    {
        //print(level1Passwords.Length);
        //print(level2Passwords.Length);
        //   currentScreen = Screen.Password;
        //Terminal.ClearScreen();
        //SetPassword();
        //Terminal.WriteLine(password.Anagram());
        //   currentScreen = Screen.Password;
        currentScreen = Screen.Password;
        SetPassword();
        Terminal.ClearScreen();
        Terminal.WriteLine("LEVEL " + level);
        Terminal.WriteLine(password.Anagram());
        Terminal.WriteLine("Enter Password: ");
        CounterComments();
    }

    void CounterComments()
    {
        if (counter == 1)
        {
            Terminal.WriteLine("It's okay Detective....we are not all Sherlock Holmes!");
        }

        if (counter == 2)
        {
            Terminal.WriteLine("Fool me once, strike one. Fool me twice, strike three!");
        }
        if (counter == 3)
        {

            Terminal.WriteLine("Life be like that sometimes!");
        }
        if (counter == 4)
        {
            Terminal.WriteLine("It's okay Detective Ammulu.... Tony Stark still loves you!");
        }
        if (counter == 5)
        {

            Terminal.WriteLine("The nuclear codes are beginning to activate detective!");
        }
        if (counter == 6)
        {

            Terminal.WriteLine("......(One Million Guesses Later)......");
        }
        if (counter == 7)
        {

            Terminal.WriteLine("Life is like a box of chocolates.....");
        }
        if (counter == 8)
        {

            Terminal.WriteLine("My name is Neha, I am ..... :) ");
        }
        if (counter == 9)
        {

            Terminal.WriteLine("So........ You still haven't guessed it huh?");
        }
        if (counter == 10)
        {

            Terminal.WriteLine("You have my respects Detective Neha, when I'm done half of the Universe will still be alive.");
        }
        if (counter == 11)
        {

            Terminal.WriteLine("Why is Gamora?");
        }
        if (counter == 12)
        {

            Terminal.WriteLine("I am a Tungadu... sorry Spoliers for Puzzle 2");
        }
    }

    void SetPassword()
    {
        //currentScreen = Screen.Password;
        if (counter == 0) { 
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                    break;
             case 3:
                    password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                    break;
            default:
                Debug.LogError("InvalidCastException Level Number");
                break;
        }
    }
    }

    void CheckPassword(string input)
    {
        if(input == password)
        {
            DisplayWinScreen();
            counter = 0;
        }
        else
        {
            AskForPassword();
            counter++;
        }
    }


    void RunWinScreen(string input)
    {
        Terminal.WriteLine("Congratulations! You have guessed correctly!");
        Terminal.WriteLine("Would You Like to Play Again?");
        if(input == "yes" || input == "Yes Please")
        {
            ShowMainMenu();
        }
        if(input == "no" || input == "No Thank You" || input == "No Thanks!")
        {
            Terminal.WriteLine("Alright! Thank You for trying my game Detective Ammulu!");
            Terminal.WriteLine("We will meet again soon muhwahwahwahwa!");
        }
    }
}
