// 3. INHERITANCE
// ******************************
class Parent
{
    public void ShowParent()
    {
        Console.WriteLine("I am a Parent (Base Class)");
    }
}

class Child : Parent
{
    public void ShowChild()
    {
        Console.WriteLine("I am a Child (Derived Class)");
    }
}