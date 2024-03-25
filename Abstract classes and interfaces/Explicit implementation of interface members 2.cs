using System;

// Base class
abstract class Base
{
    // abstract property 
    public abstract char symbol { get; }

    // abstract indexer
    public abstract int this[int k] { get; }

    // abstract method
    public abstract void show();
}

interface First
{
    // property
    char symbol { get; }
    // indexer
    int this[int k] { get; }

    void show();
}

interface Second
{
    char symbol { get; }
    int this[int k] { get; }
    void show();
}

// a derived class inherits an abstract base class and implements interfaces
class MyClass : Base, First, Second
{
    // private character field
    private char smb;
    // constructor with symbolic argument
    public MyClass(char s) : base()
    {
        smb = s;
    }

    // description of a property from an abstract class
    public override char symbol { get { return smb; } }

    // explicit implementation of a property from the "First" interface
    char First.symbol { get { return (char)(smb + 1); } }

    // description of the indexer from the base class
    public override int this[int k] { get { return smb + k; } }

    // explicit implementation of a property from the "Second" interface
    int Second.this[int k] { get { return smb - k; } }

    public override void show()
    {
        Console.WriteLine("Base class 'Base': \t\'{0}\'", symbol);
    }

    // explicit implementation of a method from the "First" interface
    void First.show()
    {
        Console.WriteLine("Intarface 'First': \t\'{0}\'", symbol);
    }

    // explicit implementation of a property from the "Second" interface
    void Second.show()
    {
        Console.WriteLine("Intarface 'Second': \t\'{0}\'", symbol);
    }
}

class ExplInterfaceDemo
{
    static void Main()
    {
        MyClass obj = new MyClass('A');
        First A = obj;
        Second B = obj;
        obj.show();
        A.show();
        B.show();
        // reading property value
        Console.WriteLine("obj.symbol=\'{0}\'", obj.symbol);
        Console.WriteLine("  A.symbol=\'{0}\'", A.symbol);
        Console.WriteLine("  B.symbol=\'{0}\'", B.symbol);
        // object indexing
        Console.WriteLine("obj[10] = {0}", obj[10]);
        Console.WriteLine("  A[10] = {0}", A[10]);
        Console.WriteLine("  B[10] = {0}", B[10]);
    }
}


//Base class 'Base':      'A'
//Intarface 'First':      'A'
//Intarface 'Second':     'A'
//obj.symbol = 'A'
//  A.symbol = 'B'
//  B.symbol = 'A'
//obj[10] = 75
//  A[10] = 75
//  B[10] = 55