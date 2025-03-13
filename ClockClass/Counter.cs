using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Counter
{
    private int _count;
    private string _name;
    public Counter(string name)
    {
        _count = 0;
        _name = name;
    }
    public int Increment()
    {
        _count++;
        return _count;
    }
    public int Reset()
    {
        _count = 0;
        return _count;
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public int Ticks
    {
        get
        {
            return _count;
        }
    }
}