using System.ComponentModel.DataAnnotations;

namespace EfCoreNullability;
public class Person
{
    public int PersonId { get; set; }
    
    public string FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
