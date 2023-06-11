using System;

public interface IOpenable
{
    string OpenSesame();
}
public class TreasureBox: IOpenable
{
    public string OpenSesame()
    {
        return "Congratulations, Here is your lucky win";
    }
}
public class Parachute: IOpenable
{
    public string OpenSesame ()
    {
        return "Have a thrilling experience flying in air";
    }
}
public class Program
{
    public static void Main(String[] args)
    {
        TreasureBox t = new TreasureBox(); 
        Parachute p = new Parachute();
        
        Console.WriteLine("Enter the letter found in the paper"); 
        char ch = Console.ReadLine()[0];

        if (ch == 'T')
            Console.WriteLine(t.OpenSesame());
        else if (ch == 'P') 
            Console.WriteLine(p.OpenSesame());
    }
}