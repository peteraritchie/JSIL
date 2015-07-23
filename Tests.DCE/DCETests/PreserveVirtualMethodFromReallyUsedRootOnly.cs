﻿using System;

public static class Program
{
    public static void Main(string[] args)
    {
        var obj = new UsedDerivedType();
        Test(obj);
        new DerivedTypeWithoudMethodUsage();
    }

    public static void Test(UsedMiddleDerivedType obj)
    {
        obj.Method();
    }
}

public class BaseType
{
    public virtual void Method()
    {
        Console.WriteLine("BaseType.Method - used");
    }
}

public class UsedMiddleDerivedType : BaseType
{
    public override void Method()
    {
        Console.WriteLine("UsedMiddleDerivedType.Method - used");
    }
}

public class UsedDerivedType : UsedMiddleDerivedType
{
    public override void Method()
    {
        Console.WriteLine("UsedDerivedType.Method - used");
    }
}

public class DerivedTypeWithoudMethodUsage : BaseType
{
    public override void Method()
    {
        Console.WriteLine("DerivedTypeWithoudMethodUsage.Method - used");
    }
}