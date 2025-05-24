namespace ResultPatternDemo
{
    public class Person(string firstName, string lastName)
    {
        public string FirstName { get; init; } = firstName;
        public string LastName { get; init; } = lastName;
    }
}