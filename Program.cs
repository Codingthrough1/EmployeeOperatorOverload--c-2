using System; // Import system namespace

class Program
{
    static void Main(string[] args) // Main method starts execution
    {
        // Create first Employee object
        Employee emp1 = new Employee();

        // Assign values to first employee
        emp1.Id = 101;
        emp1.FirstName = "John";
        emp1.LastName = "Doe";

        // Create second Employee object
        Employee emp2 = new Employee();

        // Assign values to second employee
        emp2.Id = 101;
        emp2.FirstName = "Jane";
        emp2.LastName = "Smith";

        // Compare both employees using overloaded == operator
        bool result = emp1 == emp2;

        // Display result of comparison
        Console.WriteLine("Are emp1 and emp2 equal? " + result);

        // Keep console open
        Console.ReadLine();
    }
}