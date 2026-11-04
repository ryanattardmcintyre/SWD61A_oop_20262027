// See https://aka.ms/new-console-template for more information
using Week3_InterfacesAndAbstract.Example2;
using Week3_InterfacesAndAbstract.Example3_Worksheet_Interfaces;

/*
 * Create at least two objects of each employee type.
 * • Store all employees in one collection using an appropriate common type or interface. 
 * • Iterate over the collection and 
 *   display each employee's name, 
 *   calculated monthly salary, and bonus. 
 * • Calculate the total monthly salary expenditure. 
 * • Calculate the total bonuses payable to all employees. • Invoke interface methods rather than branching on concrete types using if or switch.
 */

//instantiation of an object = create an instance of = creating an object
//e.g. of object = fullTimeEmployee1, salesEmployee1
//e.g. of a class = FullTimeEmployee, SalesEmployee


List<IEmployee> myEmployees = new List<IEmployee>();
Random r = new Random();
for (int i = 0; i < 10; i++)
{
    myEmployees.Add(
         new FullTimeEmployee() { Name = "Robert" + i , 
             MonthlySalary = r.Next(1000, 5000), YearsOfService = r.Next(1, 40) });


    myEmployees.Add(new SalesEmployee()
    {
        Name = "Jane" + i,
        BaseSalary = r.Next(1000, 1500),
        MonthlySales = r.Next(2000, 100000)
    });
}


decimal totalExpenditure = 0;
decimal totalBonuses=0;
foreach(var employee in myEmployees)
{
    totalExpenditure += employee.CalculateSalary();
    totalBonuses += employee.CalculateBonus();
    Console.WriteLine($"Name: " + employee.Name);
    Console.WriteLine($"Monthly Salary: " + employee.CalculateSalary());
    Console.WriteLine($"Monthly Bonus: " + employee.CalculateBonus());
}
Console.WriteLine("Total Expenditure: " + totalExpenditure);
Console.WriteLine("Total Bonus: " + totalBonuses);
Console.ReadLine();