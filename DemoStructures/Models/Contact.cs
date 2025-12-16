namespace DemoStructures.Models;

public struct Contact
{
    public string LastName;
    public string FirstName;
    public string Email;
    public string PhoneNumber;
    public DateOnly BirthDate;

    public string Informations()
    {
        return $"Contact: {LastName} {FirstName}";
    }
}
