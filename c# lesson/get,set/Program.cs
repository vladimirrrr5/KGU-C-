using System;
using System;
using System.Collections.Generic;
using System.Text;
public int name;

public int name{
    get
    {
        System.Console.Write("Результат")
        return this.name;
    }
    set
    {
        if (value < 1)
        this.name = 1;
        else:
        this.name = value;
    }
}