using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Console.WriteLine();
        int itemCount = int.Parse(Console.ReadLine());
        
        Dictionary<string, string> items = new Dictionary<string, string>();
        
        for (int i = 0; i < itemCount; i++) {
            Console.WriteLine();
            string itemName = Console.ReadLine();
            
            Console.WriteLine();
            string itemType = Console.ReadLine();
            
            items[itemName] = itemType;
        }
        
        while (true) {
            Console.WriteLine();
            string searchMode = Console.ReadLine();
            
            if (searchMode == "End") {
                Console.WriteLine("End");
                break;
            }
            else if (searchMode == "ShowAll") {
                foreach (KeyValuePair<string, string> item in items) {
                    Console.WriteLine(item.Key);
					Console.WriteLine(item.Value);
			       Console.WriteLine("           ");


                }
            }
            else {
                List<string> foundItems = new List<string>();
                
                foreach (KeyValuePair<string, string> item in items) {
                    if (item.Value == searchMode) {
                        foundItems.Add(item.Key);
                    }
                }
                
                if (foundItems.Count > 0) {
                    Console.WriteLine();
                    foreach (string item in foundItems) {
                        Console.WriteLine(item);
                    }
                }
                else {
                    Console.WriteLine("End");
					break;
                }
            }
        }
    }
}
