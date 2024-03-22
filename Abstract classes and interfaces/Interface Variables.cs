using System;

// Interaface
interface MyInterface
{
    // method declaration
    char getChar(int n);
    // indexer declaration
    char this[int k]
    {
        get;
    }
}

// first class that implements the interface
class Alpha : MyInterface
{
    // private character field
    private char symb;
    // constructor with symbolic argument
    public Alpha(char s)
    {
        symb = s;
    }

    // description of the method
    public char getChar(int n)
    {
        // result
        return (char)(symb + n);
    }

    // indexer description
    public char this[int k]
    {
        // accessor for reading the value
        get
        {
            // result
            return getChar(k);
        }
    }
}

// second class that implements the interface
class Bravo: MyInterface
{
    // private text field
    private string text;
    // constructor with text argument
    public Bravo(string t)
    {
        // the field is assigned a value
        text = t;
    }

    // description of the method
    public char getChar(int k)
    {
        return text[k % text.Length];
    }

    // indexer description
    public char this[int k]
    {
        // accessor for reading the value
        get
        {
            // result 
            return getChar(k);
        }
    }
}

// class with main method
class InterfaceDemo
{
    // main method
    static void Main()
    {
        // integer variable
        int m = 5;
        // interface variable
        MyInterface R;
        // an object of the "Alpha" class is created and a link to it is written to the interface variable
        R = new Alpha('F');
        // calling a method via an interface variable
        Console.WriteLine("characters from \'{0}\' to \'{1}\':", R.getChar(-m), R.getChar(m));
        // indexing objects via an interface variable
        for(int i =- m; i <=m; i++)
        {
            Console.WriteLine("|" + R[i]);
        }
        Console.WriteLine("|");
        // an object of the "Bravo" class is created and a link to it is written to the interface variable
        R = new Bravo("bravo");
        // calling a method via an interface variable
        Console.WriteLine("characters from \'{0}\' to \'{1}\':", R.getChar(0), R.getChar(2*m+1));
        // indexing objects via an interface variable
        for(int i = 0; i <=2*m+1; i++)
        {
            Console.WriteLine("|" + R[i]);
        }
        Console.WriteLine("|");
    }
}


// characters from 'A' to 'K':
// |A|B|C|D|E|F|G|H|I|J|K|
// characters from 'b' to 'r':
// |b|r|a|v|o|b|r|a|v|o|b|r|