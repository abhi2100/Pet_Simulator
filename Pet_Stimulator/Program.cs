using System;

class Program
{
    static void Main(string[] args)
    {
        // This Code will ask the user for the type of pet
        Console.Write("Enter the type of pet ? ");
        string petType = Console.ReadLine();

        // This code will ask the name of the pet
        Console.Write("Enter the name of your pet? ");
        string petName = Console.ReadLine();

        // This code will print the name and type of pet
        Console.WriteLine($"Welcome to the world, {petName}! You have chosen a {petType}!");

        // Initialize stats for the pets
        int hunger = 5;
        int happiness = 5;
        int health = 5;

        // Main loop
        while (true)
        {
            // Display the menu
            Console.WriteLine("\n1. Feed your pet\n2. Play with your pet\n3. Let your pet rest\n4. Check your pet's status\n5. Exit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            // Simulate the passage of time
            hunger++; // Hunger increases over time
            happiness--; // Happiness decreases over time

            if (hunger > 7 || happiness < 3) // Health deteriorates if the pet is too hungry or unhappy
            {
                health--;
            }

            if (choice == "1")
            {
                if (hunger > 8)
                {
                    Console.WriteLine($"{petName} is too hungry to eat.");
                }
                else
                {
                    // Feed the pet
                    hunger--;
                    health++;
                    Console.WriteLine($"Feeding {petName} will help to reduce hunger and health will slightly increase.");
                }
            }
            else if (choice == "2")
            {
                if (hunger > 8)
                {
                    Console.WriteLine($"{petName} is too hungry to play.");
                }
                else
                {
                    // Playing with the pet
                    happiness++;
                    hunger++;
                    Console.WriteLine($"Playing with {petName} will help to increase happiness and hunger will increase slightly.");
                }
            }
            else if (choice == "3")
            {
                // Allowing the pet to rest
                health++;
                happiness--;
                Console.WriteLine($"{petName} is resting which will improve health and happiness decreases slightly.");
            }
            else if (choice == "4")
            {
                // Check the pet's status
                Console.WriteLine($"Stats of {petName}: Hunger: {hunger}, Happiness: {happiness}, Health: {health}");
            }
            else if (choice == "5")
            {
                // Program ends here
                return;
            }
            else
            {
                // Invalid choice
                Console.WriteLine("Incorrect input. Please choose a number between 1 and 5.");
            }

            // Check if the pet's health has reached a critical level
            if (health <= 0)
            {
                Console.WriteLine($"{petName} has passed away due to neglect. Please take better care of your pets in the future.");
                return;
            }
        }
    }
}
