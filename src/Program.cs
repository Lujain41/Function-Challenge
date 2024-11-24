using System;
using System.Collections.Generic;

public class Challenges
{
    // Function to process a mix of strings and numbers
    public static void StringNumberProcessor(List<object> inputs)
    {
        // Initialize variables for concatenated string and sum of numbers
        string concatenatedString = "";
        int sumOfNumbers = 0;

        // Iterate through each input 
        foreach (var input in inputs)
        {
            if (input is string strInput)
            {
                // Concatenate string inputs with a space
                concatenatedString += strInput + " ";
            }
            else if (input is int number)
            {
                // Sum numeric inputs
                sumOfNumbers += number;
            }
        }

        // Trim any trailing space from the concatenated string
        concatenatedString = concatenatedString.Trim();

        // Print the final concatenated string and sum of numbers
        Console.WriteLine($"{concatenatedString}; {sumOfNumbers}");
    }

    
    // Function for the number guessing game 
    public static void GuessingGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int guess = 0;

        Console.WriteLine("Please guess the number between 1 and 100:");

        // Continue prompting the user until they guess the correct number
        while (guess != randomNumber)
        {
            string input = Console.ReadLine();

            // Try to parse the input as an integer
            if (int.TryParse(input, out guess))

            {    // Provide feedback based on the guess
                if (guess < randomNumber)
                {
                    Console.WriteLine("That's a bit low, Try guessing a larger number:");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("That's a bit high. Try guessing a smaller number:");
                }
                else
                {
                    Console.WriteLine("Congratulations!\nYou guessed the number.");
                }
            }
            else
            {    // Inform the user if the input is not a valid number
                Console.WriteLine("That is not a number. Please enter a numeric value:");
            }
        }
    }
    // Function to reverse each word in a sentence
      public static string ReverseWords(string sentence)
    {
         // Split the input sentence into individual words based on spaces
         string[] words = sentence.Split(' ');
    
         // Iterate over each word in the array
         for (int i = 0; i < words.Length; i++)
        {
              // Convert the current word into a character array
             char[] wordArray = words[i].ToCharArray();

              // Reverse the character array to reverse the word
              Array.Reverse(wordArray);

              // Create a new string from the reversed character array and update the words array
              words[i] = new string(wordArray);
        }

              // Join the reversed words back into a single string with spaces separating them
               return string.Join(" ", words);
    }
    // Function to update user profile using ref parameters
    public static void UpdateUserProfile(ref string name, ref int age, ref string email)
   {
        // Prompt the user to enter a new name and read the input
        Console.Write("Enter your new name: ");
        name = Console.ReadLine(); // Update the name variable with the user's input
        Console.WriteLine($"Name updated to: {name}");

        // Prompt the user to enter a new age and read the input
        Console.Write("Enter your new age: ");
       // Try to parse the input as an integer
        if (int.TryParse(Console.ReadLine(), out int newAge))
       {
            age = newAge; // Update the age variable with the parsed value if valid
       }
       else
       {
           // Inform the user if the input is not a valid integer
           Console.WriteLine("Invalid age. Keeping the previous value.");
       }
        Console.WriteLine($"Age updated to: {age}");
        // Prompt the user to enter a new email and read the input
        Console.Write("Enter your new email: ");
        email = Console.ReadLine(); // Update the email variable with the user's input
        Console.WriteLine($"Email updated to: {email}");
}
    // Main method to handle user input and execute the appropriate challenge
    public static void Main()
    {
        // Loop to keep the program running until the user chooses to exit
        while (true)
        {
            Console.WriteLine("Please choose one of the challenges or enter 0 to exit:");
            Console.WriteLine("Challenge 1: String and Number Processor.");
            Console.WriteLine("Challenge 2: Guessing Game.");
            Console.WriteLine("Challenge 3: Simple Word Reversal.");
            Console.WriteLine("Challenge 4: User Profile Updater.");

              // Read the user's choice
            string choice = Console.ReadLine();

             // Handle the user's choice using a switch statement
            switch (choice)
            {
                
                case "0":
                    Console.WriteLine("Thank you..");
                    return;
                // Handle String and Number Processor challenge
                case "1":
                     Console.WriteLine("Please enter a mix of strings and numbers: ");

                    // Read the entire line of input from the user
                     string inputLine = Console.ReadLine();

                    // Split the input line into parts based on spaces
                     string[] parts = inputLine.Split(' ');

                     List<object> userInputs = new List<object>();

                    // Process each part
                    foreach (var part in parts)
                    {
                        // Try to parse the part as an integer
                        if (int.TryParse(part, out int number))
                        {
                              userInputs.Add(number);
                        }
                        else
                        {
                              // Treat it as a string
                              userInputs.Add(part);
                        }
                    }
 
                    // Process and display results
                    StringNumberProcessor(userInputs);
                    break;

                // Handle Guessing Game challenge
                case "2":
                    GuessingGame();
                    break;

                case "3":
                     // Prompt the user to enter a sentence to reverse each word
                     Console.WriteLine("Please enter a your sentence to reverse the words:");

                     // Read the user's input sentence from the console
                    string sentence = Console.ReadLine();

                     // Call the ReverseWords function to reverse each word in the input sentence
                     string reversedSentence = ReverseWords(sentence);

                     // Print the reversed sentence to the console
                     Console.WriteLine(reversedSentence);        
                    break;

                case "4":
                    // Initialize user profile with default values
                    string name = "John Doe";
                    int age = 28;
                    string email = "john@gmail.com";

                    // Display the initial profile details
                    Console.WriteLine("\nInitial Profile:");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Email: {email}");

                    // Call the UpdateUserProfile function to allow the user to update their profile
                    UpdateUserProfile(ref name, ref age, ref email);

                    // Display the updated profile details
                    Console.WriteLine("\nUpdated Profile:");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Email: {email}");
                    break;

                default:
                   // Inform the user that their choice is invalid
                   Console.WriteLine("Invalid choice. Please enter a number between 0 and 4 ...\n");
                   break;

            }
        }
    }}
