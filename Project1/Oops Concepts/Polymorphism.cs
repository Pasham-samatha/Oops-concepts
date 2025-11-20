

// 4. POLYMORPHISM (Basic override)
// ******************************
class Worker
{
    public virtual void DoWork()
    {
        Console.WriteLine("Person is working...");
    }
}

class Teacher : Worker
{
    public override void DoWork()
    {
        Console.WriteLine("Teacher is teaching...");
    }
}