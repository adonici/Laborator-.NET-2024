using Lab2;
using Lab2_Library;

internal class Program
{
    delegate int CalculatorDelegate(int x, int y);

    private static void Main(string[] args)
    {
        //AccessModifiersExample();
        //OverridingExample();
        //OverloadingExamples();
        //DelegateExample();
        //ExtensionMethodExample();
        //LinqExamples();
        //DllUsingExample();
        ExceptionHandlingExamples();
    }

    static void AccessModifiersExample()
    {
        Employee employee = new Employee();

        // Accessing public members
        Console.WriteLine($"Employee name: {employee.EmployeeName}");
        employee.PerformTask();

        //// Attempting to access private members will result in a compilation error
        //Console.WriteLine($"Employee SSN: {employee.EmployeeSocialSecurityNumber}");
        //employee.HRConfidentialMeeting();

        //// Accessing protected and internal members within the same assembly
        //Console.WriteLine($"Employee salary: ${employee.EmployeeSalary}");
        //employee.NegotiateSalary();

        Console.WriteLine($"Internal policy document: {employee.InternalPolicyDocument}");
        employee.AccessCompanyPolicy();

        // Creating an instance of the manager class
        Manager manager = new Manager();

        // Accessing protected members from the manager class
        manager.AccessEmployeeBenefits();
        manager.InitiateSalaryNegotiation();
    }

    private static void OverloadingExamples()
    {
        Printer printer = new Printer();

        printer.Print(5);
        printer.Print(3, 7);
        printer.Print(2.5);  // Calls the Print(double) method
        printer.Print("Hello, Overloading!");  // Calls the Print(string) method
        printer.Print(1, 2, 3);
        printer.Print(10, 20, 30, 40, 50);  // Calls the Print(params int[]) method
        printer.Print("Count", 100);  // Calls the Print(string, int) method
    }

    private static void OverridingExample()
    {
        Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();

        shape1.Draw();  // Polymorphism: Calls the overridden method in Circle
        shape2.Draw();  // Polymorphism: Calls the overridden method in Rectangle
    }

    private static void DelegateExample()
    {
        // Create instances of the delegate, pointing to different methods
        CalculatorDelegate addDelegate = new CalculatorDelegate(Calculator.Add);
        CalculatorDelegate subtractDelegate = new CalculatorDelegate(Calculator.Subtract);

        // Use the delegates to perform calculations
        int resultAdd = addDelegate(5, 3);
        int resultSubtract = subtractDelegate(8, 4);

        // Display the results
        Console.WriteLine($"Addition Result: {resultAdd}");
        Console.WriteLine($"Subtraction Result: {resultSubtract}");
        Console.WriteLine();
    }

    private static void ExtensionMethodExample()
    {
        string text = "Extension methods are useful.";

        // Using the WordCount extension method
        int wordCount = text.WordCount();
        Console.WriteLine($"Word Count: {wordCount}");

        // Using the Reverse extension method
        string reversedText = text.Reverse();
        Console.WriteLine($"Reversed Text: {reversedText}");
        Console.WriteLine();
    }

    private static void LinqExamples()
    {
        // Define a list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, Grade = 8.5 },
            new Student { Name = "Charlie", Age = 21, Grade = 9.2 },
            new Student { Name = "Bob", Age = 22, Grade = 7.8 },
            new Student { Name = "David", Age = 23, Grade = 6.5 }
        };

        // Filtering - Select students with grade greater than 7
        students = students.Where(s => s.Grade > 7).ToList();

        // Sorting - Order students in descending order by name
        students = students.OrderByDescending(s => s.Name).ToList();

        // Projection - Select student names
        var studentNames = students.Select(s => s.Name).ToList();

        // Aggregation - Calculate the average grade of students
        var averageGrade = students.Average(s => s.Grade);

        // Display the results
        Console.WriteLine("Student names:");
        foreach (var name in studentNames)
        {
            Console.Write(name + " ");
        }

        Console.WriteLine($"\n\nAverage grade of students: {averageGrade}");
    }

    private static void DllUsingExample()
    {
        var myLibrary = new MyLibrary();

        Console.WriteLine(myLibrary.GetMessage());
    }

    private static void ExceptionHandlingExamples()
    {
        // Define a list of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, Grade = 8.5 },
            new Student { Name = "Charlie", Age = 21, Grade = 9.2 },
            new Student { Name = "Bob", Age = 22, Grade = 7.8 },
            new Student { Name = "David", Age = 23, Grade = 6.5 }
        };

        try
        {
            ////Check if the list is empty or null
            //if (students == null || students.Count == 0)
            //{
            //    throw new InvalidOperationException("The list of students is empty or null.");
            //}

            //Calculate the average grade and the average age
            double totalGrade = 0;
            int totalAge = 0;
            foreach (var student in students)
            {
                totalGrade += student.Grade;
                totalAge += student.Age;
            }

            double averageGrade = totalGrade / students.Count;
            double averageAge = totalAge / students.Count;

            // Print the average grade
            Console.WriteLine($"\nAverage grade of students: {averageGrade}");

            // Print the average age
            Console.WriteLine($"\nAverage age of students: {averageAge}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"InvalidOperationException");
        }
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine($"DivideByZeroException");
        //}
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Students count: {students.Count}");
        }
    }
}