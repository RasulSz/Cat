using CAT;
PetShop pshop = new();
pshop.CatHouses.Add(new CatHouse { Name = "_Sz Cat House" });
pshop.CatHouses.Add(new CatHouse { Name = "OneSec Cat House" });
pshop.CatHouses[0].AddCat(new Cat { NickName = "Kedy", Age = 3, Energy = 100, Gender = false, MealQuantity = 60, Price = 150 });
void mainMenu()
{
    Console.Clear();
    Console.WriteLine("1.Pet Shops");
    Console.WriteLine("2.Add Cat House");
    Console.WriteLine("3.Exit");
    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            ShowCatHouses();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            AddCatHouse();
            break;
        default:
            break;
    }

}

void AddCatHouse()
{
    Console.Clear();
    Console.WriteLine("Name of House : ");
    var name = Console.ReadLine();
    CatHouse house = new() { Name = name };
    pshop.CatHouses.Add(house);
}

void ShowCatHouse(CatHouse house)
{
    Console.Clear();
    Console.WriteLine(house.Name);
    Console.WriteLine("1. All Cats");
    Console.WriteLine("2. Add Cat");
    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            int i = 1;
            foreach (var cat in house.Cats)
            {
                Console.WriteLine($"{i++}: {cat.NickName}");
            }
            break;
        default: break;
    }

}

void ShowCatHouses()
{
    Console.Clear();
    if (pshop.CatHouseCount >= 0)
    {
        int i = 1;
        foreach (var house in pshop.CatHouses)
        {
            Console.WriteLine($"{i}: {house.Name}");
        }
        Console.WriteLine("Esc: Back");
        var key = Console.ReadLine();
        if (int.TryParse(key, out int result) && 0 <= result && result < pshop.CatHouseCount)
        {
            ShowCatHouse(pshop.CatHouses[result]);
        }

    }
    else Console.WriteLine("Is not any Cat Houses");
}
while (true)
{
    mainMenu();
}