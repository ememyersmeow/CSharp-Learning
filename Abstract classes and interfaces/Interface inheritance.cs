using System;

// First interface
interface First
{
    // property
    int number { get; set; }

    // indexer
    int this[int k]
    {
        get;
    }
}

// Second interface 
interface Second
{
    void setNum(int n);
    int getNum();
}

// An interface inherits other interfaces
interface MyInterface : First, Second
{
    void show();
}

// class implements interface
class MyClass : MyInterface
{
    private int num;
    public MyClass(int n)
    {
        number = n;
        show();
    }

    public void show()
    {
        Console.WriteLine("Property number=" + number);
    }

    public void setNum(int n)
    {
        num = n;
    }

    public int getNum()
    {
        return num;
    }

    public int number
    {
        get
        {
            return getNum();
        }
        set
        {
            setNum(value);
        }
    }

    public int this[int k]
    {
        get
        {
            int r = number;
            for (int i = 0; i < k; i++)
            {
                r /= 10;
            }
            return r % 10;
        }
    }
}

// Class with main method
class InterfaceDemo
{
    static void Main()
    {
        int m = 9;
        MyClass obj = new MyClass(12345);
        for (int i = 0; i <= m; i++)
        {
            Console.WriteLine("|" + obj[m - i]);
        }
        Console.WriteLine("|");
    }
}


// Property number=12345
// |0|0|0|0|0|1|2|3|4|5|
