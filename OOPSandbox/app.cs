Console.WriteLine("********* Fun with OOP **********");

User user1 = User.Create("Olumuyiwa", "Agboola");
Console.WriteLine("User created from static method User.Create(): " + user1.FirstName + " " + user1.LastName);

User user2 = User.Create("Olabisi", "Adebisi");
Console.WriteLine("User created from static method User.Create(): " + user2.FirstName + " " + user2.LastName);

public class User
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public static User Create(string firstName, string lastName) => new User { FirstName = firstName, LastName = lastName };
}

