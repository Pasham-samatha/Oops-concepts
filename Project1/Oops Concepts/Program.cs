// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        // CLASS
        Console.WriteLine("=== CLASS ===");
        Person p = new Person();
        p.FirstName = "John";
        p.LastName = "Doe";
        p.ShowPerson();

        // ENCAPSULATION
        Console.WriteLine("\n=== ENCAPSULATION ===");
        SecurePerson sp = new SecurePerson();
        sp.SetSocialId("123456789");
        Console.WriteLine("Social ID: " + sp.GetSocialId());

         // INHERITANCE
        Console.WriteLine("\n=== INHERITANCE ===");
        Child c = new Child();
        c.ShowParent();
        c.ShowChild();

        // POLYMORPHISM
        Console.WriteLine("\n=== POLYMORPHISM ===");
        Worker w = new Teacher();
        w.DoWork();
         // ABSTRACTION
         
        Console.WriteLine("\n=== ABSTRACTION ===");
        Human h = new Student();
        h.Activity();

        
        Console.WriteLine("\n=== PROGRAM FINISHED ===");
    }
}