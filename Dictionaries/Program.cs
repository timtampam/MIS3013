using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int i;
            string userInput;
            string newCategory;
            string newFood;

            // initialize dictionary
            Dictionary<string, List<string>> foodDictionary = new Dictionary<string, List<string>>();

            // add keys
            foodDictionary.Add("Fruits", new List<string>());
            foodDictionary.Add("Vegetables", new List<string>());
            foodDictionary.Add("Desserts", new List<string>());

            // add values
            foodDictionary["Fruits"].Add("Apples");
            foodDictionary["Fruits"].Add("Strawberries");
            foodDictionary["Fruits"].Add("Oranges");

            foodDictionary["Vegetables"].Add("Carrots");
            foodDictionary["Vegetables"].Add("Peas");
            foodDictionary["Vegetables"].Add("Onions");

            foodDictionary["Desserts"].Add("Cake");
            foodDictionary["Desserts"].Add("Pies");
            foodDictionary["Desserts"].Add("Cookies");

            // output keys
            foreach (string key in foodDictionary.Keys)
            {
                Console.Write($"{key}: ");
                i = 0;

                // output values
                foreach (string food in foodDictionary[key])
                {
                    Console.Write(food);
                    i++;
                    
                    if (i != foodDictionary[key].Count)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }

            // user input
            do
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to add a new category or a new food?");
                Console.WriteLine("Type 'C' for new category or 'F' for new food: ");
                userInput = Console.ReadLine();

                // new category
                if (userInput == "C")
                {
                    Console.WriteLine("What is the name of the new category?");
                    newCategory = Console.ReadLine();

                    if (foodDictionary.ContainsKey(newCategory) == false)
                    {
                        foodDictionary.Add(newCategory, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine("That is already an existing category.");
                    }
                }

                // new food
                if (userInput == "F")
                {
                    Console.WriteLine("What is the name of the new food?");
                    newFood = Console.ReadLine();

                    Console.WriteLine("Which category do you want to add it to?");
                    newCategory = Console.ReadLine();

                    if (foodDictionary.ContainsKey(newCategory) == true)
                    {
                        foodDictionary[newCategory].Add(newFood);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid category.");
                    }
                }

                Console.WriteLine("Would you like to enter something else? (yes/no)");
                userInput = Console.ReadLine();
            } while (userInput.ToLower() == "yes");

            // final output
            Console.WriteLine();
            Console.WriteLine("All food categories: ");
            foreach (string key in foodDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Which category would you like to see?");
            userInput = Console.ReadLine();
            
            i = 0;
            foreach (string food in foodDictionary[userInput])
            {
                Console.Write(food);
                i++;

                if (i != foodDictionary[userInput].Count)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey(); // end
        }
    }
}
