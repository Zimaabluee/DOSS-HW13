using System;
namespace StringLibrary;
public class A 
{
    public int F1(int x)
    {
        x = x + 1;
        return x;
    }
    
    public int F2(int x)
    {
        x = x + 2;
        return x;
    }
    
    public int F3(int x)
    {
        x = x + 3;
        return x;
    }
    
    public int F4(int x)
    {
        x = x + 4;
        return x;
    }
    
    public double F5(int x,int y)
    {
        return x / (double)y;
    }
    
    public int F6(int x)
    {
        if(x < 0)
        {
            throw new Exception("x can't be negative");
        }
        
        return x + 5;
    }
    
    public string F7(string s)
    {
        var ss = s + " more stuff";
        return ss;
    }
    
    public virtual int F8(int x)
    {
        // Assume this calls a SQL database such as "select * from where something = x"
        return x + 8;
    }
}

public class B
{
    private A _a;

    public B(A a)
    {
        _a = a;
    }

    public int G1(int x)
    {
        return _a.F8(x);
    }
}
