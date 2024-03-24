using System;

// first intraface
interface First
{
    void show();
}

// second interface
interface Second
{ 
    void show();
}

// class implements interfaces
class MyClass: First, Second
{
    public void show()
    {
        Console.WriteLine("Class object MyClass");
    }
}

// class with main method
class ImplInterfaceDemo
{
    static void Main()
    {
        // create object
        MyClass obj = new MyClass();
        // the object reference is written to interface variables
        First A = obj;
        Second B = obj;
        // method calls through different variables
        obj.show();
        A.show();
        B.show();
    }
}


// Class object MyClass
// Class object MyClass
// Class object MyClass
