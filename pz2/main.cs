using System;
using System.Text.RegularExpressions;

record IP4(byte[] Address);

class Parser {
    private Regex regex = new Regex(@"(\s?[\.,!-?]\s?)");

    public IP4 Parse(string s) {
        string[] match = regex.Split(s);

        Console.WriteLine(string.Join(",", match));
      
        return new IP4(new byte[]{
        });
    }
}

class Program {
    static void Main(string[] args) {
        string s;
        Parser parser = new Parser();
        while ((s=Console.ReadLine()) != null)
        {
            IP4 ip = parser.Parse(s);
            if (ip == null){
                Console.WriteLine($"Invalid IP address: {s}");
            } else
            {
                Console.WriteLine($"Parsed IP address: {ip.Address[0]}.{ip.Address[1]}.{ip.Address[2]}.{ip.Address[3]}");
            }
        }
    }
}



// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Item {
//     public string Name { get; set; }
//     public string Type { get; set; }
//     public double Weight { get; set; }

//     public Item(string name, string type, double weight) {
//         Name = name;
//         Type = type;
//         Weight = weight;
//     }
// }

// class Inventory {
//     private List<Item> items = new List<Item>();

    
//     public void AddItem(Item item) {
//         items.Add(item);
//     }

    
//     public void RemoveItem(Item item) {
//         items.Remove(item);
//     }

    
//     public string MostCommonType() {
//         if (items.Count == 0) {
//             return "Інвентар порожній";
//         }

//         var typeCounts = items.GroupBy(item => item.Type)
//                               .Select(group => new { Type = group.Key, Count = group.Count() })
//                               .OrderByDescending(x => x.Count);

//         return typeCounts.First().Type;
//     }

  
//     public string LeastCommonType() {
//         if (items.Count == 0) {
//             return "Інвентар порожній";
//         }

//         var typeCounts = items.GroupBy(item => item.Type)
//                               .Select(group => new { Type = group.Key, Count = group.Count() })
//                               .OrderBy(x => x.Count);

//         return typeCounts.First().Type;
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         Inventory inventory = new Inventory();

        
//         inventory.AddItem(new Item("Меч", "Зброя", 5.0));
//         inventory.AddItem(new Item("Щит", "Захист", 10.0));
//         inventory.AddItem(new Item("Зелье здоровья", "Предмет для відновлення", 1.0));
//         inventory.AddItem(new Item("Ключі", "Предмет", 0.5));
//         inventory.AddItem(new Item("Меч", "Зброя", 5.0));

//         Console.WriteLine("Найбільш поширений тип речей: " + inventory.MostCommonType());
//         Console.WriteLine("Найменш поширений тип речей: " + inventory.LeastCommonType());
//     }
// }
