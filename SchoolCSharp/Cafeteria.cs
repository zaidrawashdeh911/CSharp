namespace SchoolCSharp;

public class Cafeteria: IBreakfast,ILunch
{
    private int StudentId { get; set; }
    private Breakfast BreakfastOrder{set;get;}
    private Lunch LunchOrder{set;get;}
    
    public void BreakfastMenu()
    {
        Console.WriteLine("\nCafeteria Breakfast Menu: ");
        Console.WriteLine("Scrambled or Omelet Eggs");
        Console.WriteLine("Hashbrowns");
        Console.WriteLine("Pancakes");
        Console.WriteLine("Croissants");
        Console.WriteLine("Cereals or Oatmeal");
    }
    public void LunchMenu()
    {
        Console.WriteLine("\nCafeteria Lunch Menu: ");
        Console.WriteLine("Chicken Curry");
        Console.WriteLine("Chicken Fricassee");
        Console.WriteLine("Baked Fish Nibbles");
        Console.WriteLine("Beef Burger");
        Console.WriteLine("Tuna and Avocado Salad");
        Console.WriteLine("Beef Tacos");
    }
    private enum Breakfast
    {
        ScrambledOrOmelet =1, 
        Hashbrowns,
        Pancakes,
        Croissants,
        CerealsOrOatmeal
    }

    private enum Lunch
    {
        ChickenCurry=1,
        ChickenFricassee,
        BakedFishNibbles,
        BeefBurger,
        TunaAndAvocadoSalad,
        BeefTacos
    }
}