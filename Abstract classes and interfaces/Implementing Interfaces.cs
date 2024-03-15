using System;

//Interface
interface MyInterface
{
    // Declaring Methods
    void show();
    void setNum(int n);
    int getNum();
    // property declaration
    int number
    {
        get;
        set;
    }

    // indexer declaration
    int this[int k]
    {
        get;
    }
}

// class implements interface
class MyClass: MyInterface
{
    //  private integer field
    private int num;
    // one argument constructor
    public MyClass(int n)
    {
        // assigning a value to a property
        number = n;
        // calling a method from the interface
        show();
    }

    // description of the method from the interface
    public void show()
    {
        Console.WriteLine("Property number =" + number);
    }

    // description of the method from the interface
    public void setNum(int n)
    {
        num = n;
    }

    // description of the method from the interface
    public int getNum()
    {
        return num; 
    }

    //property description from the interface
    public int number
    {
        // accessor for reading the value
        get
        {
            return getNum();
        }
        // accessor for assigning a value
        set
        {
            // calling a method from the interface
            setNum(value);
        }
    }

    // description of the indexer from the interface
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

            return r%10;
        }
    }
}

// class with main method
class  InterfaceDemo
{
    // main method
    static void Main()
    {
        int m = 9;
        // object creation
        MyClass obj = new MyClass(12345);
        // object indexing
        for(int i = 0; i <= m;  i++)
        {
            Console.WriteLine("|" + obj[m - i]);
        }

        Console.WriteLine("|");
    }
}

// Property number = 12345
// |0|0|0|0|0|1|2|3|4|5|

