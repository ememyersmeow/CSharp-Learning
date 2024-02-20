using System;

abstract class Base
{
    //Protected integer field
    protected int num;

    //Constructor
    public Base(int n)
    {
        //Calling a Method
        set(n);
    }

    //Abstract methods
    public abstract void show();
    public abstract void set(int n);
    public abstract int get();
}

//Derived class based on abstract
class Alpha : Base
{
    //Protected integer field
    protected int val;
    //Constructor
    public Alpha(int n):base(n)
    {
        show();
    }

    //Overriding an abstract method
    public override void show()
    {
        Console.WriteLine("Alpha: {0}, {1} and {2}", num, val, get());  
    }

    //Overriding an abstract method
    public override void set(int n)
    {
        num = n;
        val = n % 10;
    }

    //Overriding an abstract method
    public override int get()
    {
        return num / 10;
    }

    //Derived class based on abstract
    class Bravo: Base
    {
        //Protected integer field
        protected int val;
        //Constructor
        public Bravo(int n): base(n)
        {
            show();
        }

        //Overriding an abstract method
        public override void show()
        {
            Console.WriteLine("Bravo: {0}, {1}, and {2}", num, val, get());
        }

        //Overriding an abstract method
        public override void set(int n)
        {
            num = n;
            val = n % 100;
        }

        //Overriding an abstract method
        public override int get()
        {
            return num / 100;
        }
    }

    //Class with main method
    class AbstractDemo
    {
        static void Main()
        {
            //Abstract class object variable
            Base obj;
            //Creating Objects from Derived Classes
            Alpha A = new Alpha(123);
            Bravo B = new Bravo(321);
            //The base class object variable is assigned
            //reference to a derived class object
            obj = A;
            Console.WriteLine("After executing the program obj = A");
            //Calling methods through a base class object variable
            obj.set(456);
            obj.show();
            //The base class object variable is assigned
            //reference to a derived class object
            obj = B;
            Console.WriteLine("After executing the program obj = B");
            //Calling methods through a base class object variable
            obj.set(654);
            obj.show();
        }
    }
}

// Output:

//Alpha: 123, 3 and 12
//Bravo: 321, 21, and 3
//After executing the program obj = A
//Alpha: 456, 6 and 45
//After executing the program obj = B
//Bravo: 654, 54, and 6

