using System.ComponentModel.DataAnnotations;

namespace EfCoreNullability;
public class Person
{
    public int PersonId { get; set; }
    
    [Required]
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    [Required]
    public string LastName { get; set; }
}
