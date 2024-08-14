using PatikaAbstraction;

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee("Ezgi", "Keçeci", "Üretim", "Makine Mühendisi");
        employee.PersonInfo();
        employee.Position();
    }
}