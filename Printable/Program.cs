using System;
public interface Printable
{
    public void Print();
}
public class Book : Printable
{
    public void Print()
    {
        static void printBooks(Printable[] printable)
        {
            Console.WriteLine(printable);
        }
    }
}
public class Magazine : Printable
{
    public void Print() 
    {
        static void printMagazines(Printable[] printable)
        {
            Console.WriteLine(printable);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Book kniga = new Book();
        Magazine zhyrnal = new Magazine();
        Printable[] masiv = { };
        foreach (Printable i in masiv)    
        {
            kniga.Print();
            zhyrnal.Print();
        }
    }
}


