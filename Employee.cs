using System; // Import base system library

// Define Employee class
public class Employee
{
    // Property to store employee ID
    public int Id { get; set; }

    // Property to store employee first name
    public string FirstName { get; set; }

    // Property to store employee last name
    public string LastName { get; set; }

    // Overload the == operator to compare Employee objects by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both references are same or both are null, they are equal
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one is null and other is not, they are not equal
        if (emp1 is null || emp2 is null)
            return false;

        // Compare based on Id property
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return opposite of ==
        return !(emp1 == emp2);
    }

    // Override Equals (recommended when overloading ==)
    public override bool Equals(object obj)
    {
        // Convert object to Employee type safely
        if (obj is Employee employee)
        {
            return this.Id == employee.Id;
        }
        return false;
    }

    // Override GetHashCode (recommended when overriding Equals)
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}