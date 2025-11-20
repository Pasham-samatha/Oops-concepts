using System;

// 5. ABSTRACTION (Basic version)
// ******************************
abstract class Human
{
    public abstract void Activity();
}

class Student : Human
{
    public override void Activity()
    {
        Console.WriteLine("Student is studying...");
    }
}