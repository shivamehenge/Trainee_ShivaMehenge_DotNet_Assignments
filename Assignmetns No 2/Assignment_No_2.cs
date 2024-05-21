using System;
using System.Collections.Generic; // We need this to use List

// Define the Item class
public class Item
{
    // Properties of the Item class
    public int ID { get; set; } // ID of the item
    public string Name { get; set; } // Name of the item
    public float Price { get; set; } // Price of the item
    public int Quantity { get; set; } // Quantity of the item

    // Constructor to initialize properties
    public Item(int id, string name, float price, int quantity)
    {
        ID = id; // Set the ID
        Name = name; // Set the Name
        Price = price; // Set the Price
        Quantity = quantity; // Set the Quantity
    }

    // Override the ToString method to display item information
    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Price: {Price}, Quantity: {Quantity}";
    }
}

// Define the Inventory class
public class Inventory
{
    // List to store items
    private List<Item> items;

    // Constructor to initialize the list
    public Inventory()
    {
        items = new List<Item>(); // Create a new list of items
    }

    // Method to add a new item
    public void AddItem(Item item)
    {
        items.Add(item); // Add the item to the list
        Console.WriteLine("Item added successfully."); // Confirm the item was added
    }

    // Method to display all items
    public void DisplayItems()
    {
        foreach (var item in items) // Loop through each item in the list
        {
            Console.WriteLine(item); // Print the item
        }
    }

    // Method to find an item by ID
    public Item FindItemByID(int id)
    {
        foreach (var item in items) // Loop through each item in the list
        {
            if (item.ID == id) // Check if the ID matches
            {
                return item; // Return the item if found
            }
        }
        return null; // Return null if not found
    }

    // Method to update an item's information
    public bool UpdateItem(int id, string name, float price, int quantity)
    {
        Item item = FindItemByID(id); // Find the item by ID
        if (item != null) // If the item is found
        {
            item.Name = name; // Update the name
            item.Price = price; // Update the price
            item.Quantity = quantity; // Update the quantity
            Console.WriteLine("Item updated successfully."); // Confirm the update
            return true; // Return true if successful
        }
        return false; // Return false if the item was not found
    }

    // Method to delete an item
    public bool DeleteItem(int id)
    {
        Item item = FindItemByID(id); // Find the item by ID
        if (item != null) // If the item is found
        {
            items.Remove(item); // Remove the item from the list
            Console.WriteLine("Item deleted successfully."); // Confirm the deletion
            return true; // Return true if successful
        }
        return false; // Return false if the item was not found
    }
}

// Main class to run the program
public class Program
{
    public static void Main()
    {
        // Create an instance of Inventory
        Inventory inventory = new Inventory();

        // Add items to the inventory
        inventory.AddItem(new Item(1, "Laptop", 999.99f, 10)); // Add a laptop
        inventory.AddItem(new Item(2, "Mouse", 19.99f, 100)); // Add a mouse

        // Display all items
        Console.WriteLine("All Items:");
        inventory.DisplayItems(); // Show all items

        // Find an item by ID
        Item item = inventory.FindItemByID(1); // Find the laptop
        if (item != null)
        {
            Console.WriteLine("Found Item: " + item); // Print the found item
        }

        // Update an item's information
        inventory.UpdateItem(1, "Laptop", 899.99f, 8); // Update the laptop

        // Delete an item
        inventory.DeleteItem(2); // Delete the mouse

        // Display all items after updates
        Console.WriteLine("Items after updates:");
        inventory.DisplayItems(); // Show remaining items
    }
}
