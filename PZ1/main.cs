

// 13 варіант

using System;
using System.Collections.Generic;
using System.Linq;

class Item {
    public string Name { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }

    public Item(string name, string type, double weight) {
        Name = name;
        Type = type;
        Weight = weight;
    }
}

class Inventory {
    private List<Item> items = new List<Item>();

    
    public void AddItem(Item item) {
        items.Add(item);
    }

    
    public void RemoveItem(Item item) {
        items.Remove(item);
    }

    
    public string MostCommonType() {
        if (items.Count == 0) {
            return "Інвентар порожній";
        }

        var typeCounts = items.GroupBy(item => item.Type)
                              .Select(group => new { Type = group.Key, Count = group.Count() })
                              .OrderByDescending(x => x.Count);

        return typeCounts.First().Type;
    }


    public string LeastCommonType() {
        if (items.Count == 0) {
            return "Інвентар порожній";
        }

        var typeCounts = items.GroupBy(item => item.Type)
                              .Select(group => new { Type = group.Key, Count = group.Count() })
                              .OrderBy(x => x.Count);

        return typeCounts.First().Type;
    }
}

class Program {
    static void Main(string[] args) {
        Inventory inventory = new Inventory();

        
        inventory.AddItem(new Item("Меч", "Зброя", 5.0));
        inventory.AddItem(new Item("Щит", "Захист", 10.0));
        inventory.AddItem(new Item("Зелье здоровья", "Предмет для відновлення", 1.0));
        inventory.AddItem(new Item("Ключі", "Предмет", 0.5));
        inventory.AddItem(new Item("Меч", "Зброя", 5.0));

        Console.WriteLine("Найбільш поширений тип речей: " + inventory.MostCommonType());
        Console.WriteLine("Найменш поширений тип речей: " + inventory.LeastCommonType());
    }
}
