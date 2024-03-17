using System;


// base abstract class
abstract class Base
{
    // abstract property declaration
    public abstract int number { get; set; }

    // one argument constructor
    public Base(int n)
    {
        // assigning a value to a property
        number = n;
        //a regular (not abstract) method is called
        show();
    }

    // description of a regular (not abstract) method
    public void show()
    {
        Console.WriteLine("Property number" + number);
    }
}

// first interface 
interface First
{
    // declaration of methods
    int this[int k]
    {
        get;
    }
}

interface Second
{
    // indexer declaration
    int this[int k]
    {
        get;
    }
}

// class implements interface
class MyClass : Base, First, Second
{
    // private integer field
    private int num;
    // one argument constructor
    public MyClass(int n) : base(n) { }

    // description of the method from the "First" interface
    public void setNum(int n)
    {
        // assigning a value to a field
        num = n;
    }

    // description of the method from the "First" interface
    public int getNum()
    {
        // field value
        return num;
    }

    // description of a property from the "Base" class
    public override int number
    {
        // accessor for reading the value
        get
        {
            // method is called from the "First" interface
            return getNum();
        }

        // accessor for assigning a value
        set
        {
            // method is called from the "First" interface
            setNum(value);
        }
    }

    // description of the indexer from the "Second" interface
    public int this[int k]
    {
        // accessor for reading the value
        get
        {
            // local variable
            int r = number;

            // "dropping" digits in the decimal representation of a number
            for(int i = 0; i < k; i++)
            {
                r /= 10;
            }
            // result
            return r % 10;
        }
    }
}

// class with main method
class MoreInterfaceDemo
{
    static void Main()
    {
        int m = 9;
        MyClass obj = new MyClass(12345);
        for(int i = 0; i <= m; i++)
        {
            Console.WriteLine("|" + obj[m - i]);
        }
        Console.WriteLine("|");
    }
}

// property number=12345
// |0|0|0|0|0|1|2|3|4|5|
