using System;

abstract class Base
{
    // abstract text property
    public abstract string text
    {
        get;
        set;
    }

    // abstract indexer with integer indexes
    public abstract char this[int k]
    {
        get;
    }

    // abstract int property
    public abstract int length
    {
        get;
    }
}

//derived class based on abstract

class Alpha: Base
{
    // array reference
    private char[] symbs;
    //Constructor

    //derived class based on abstract
    public Alpha(string t): base()
    {
        text = t;
    }

    // overriding a text property
    public override string text
    {
        get
        {
            // the result is a text string
            return new string(symbs);
        }
        set
        {
            // creating a character array and assigning a value to a field
            symbs = value.ToCharArray();
        }
    }

    //overriding a int property
    public override int length
    {
        get
        {
            //array length
            return symbs.Length;
        }
    }

    // indexer override
    public override char this[int k]
    {
        get
        {
            //character array element value
            return symbs[k];
        }
    }
}

// derived class based on abstract
class Bravo : Base
{
    //private text field
    private string txt;
    //Constructor
    public Bravo(string t) : base()
    {
        //the text property is assigned a value
        text = t;
    }

    //overriding a text property
    public override string text
    {
        get
        {
            return txt;
        }
        set
        {
            // assigning a value to a field
            txt = value;
        }
    }

    // overriding a int property
    public override int length
    {
        get
        {
            // number of characters per line
            return txt.Length;
        }
    }

    // indexer override
    public override char this[int k]
    {
        get
        {
            // symbol in text
            return txt[k];
        }
    }
}

// class with main method
class AbstrProbAndIndexDemo
{
    // main method
    static void Main()
    {
        //a reference to a derived class object is written to an object variable of the base class
        Base obj = new Alpha("Alpha");
        Console.WriteLine(obj.text);
        // new text property value
        obj.text = "Base";
        // object indexing
        for(int k = 0; k < obj.length; k++)
        {
            Console.WriteLine("|" + obj[k]);
        }
        Console.WriteLine("|");
        //a reference to a derived class object is written to an object variable of the base class
        obj = new Bravo("Bravo");
        // object indexing
        for (int k = 0; k < obj.length; k++)
        {
            Console.WriteLine("|" + obj[k]);
        }
        Console.WriteLine("|");
        // new text property value
        obj.text = "Base";
        // displaying the value of a text property
        Console.WriteLine(obj.text);
    }
}

// Alpha
// |B|a|s|e|
// |B|r|a|v|o|
// Base
