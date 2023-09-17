// See https://aka.ms/new-console-template for more information
using EmployeeOOP.Class;
try
{
    //Declaracion de variables
    int day, month, year;
    string firstName, lastName; 
    decimal salary;

    Console.WriteLine("Hello, World! this is mi app C#");
    Console.WriteLine("-------------------");

    Console.Write("Ingresar El dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar El Mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar El año: ");
    year = Convert.ToInt32(Console.ReadLine());


    Date DateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(DateObject.ToString());

    //Har
    Console.WriteLine("Ingrese el nombre completo: ");
    firstName = Console.ReadLine();
    
    Console.WriteLine("Ingresar Apellidos: ");
    lastName = Console.ReadLine();

    Console.WriteLine("Ingresar salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = DateObject,
        IsActive = true,
        Salary = salary,
    };

    Console.WriteLine(salaryEmployee.ToString());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

