namespace BasicsOfCollectingParamsInNET9
{
	internal class Program
	{
        	static void Main(string[] args)
       		{
	        	Console.WriteLine("Hello, .NET9!");
			Employee employees = new Employee("Potter", "Vovan");
			employees._employees.AddRange("Poc", "NaN");

			foreach (var item in employees._employees)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

		public class Employee
		{
			public List<string> _employees;

			public Employee(params List<string> employees)
			{
				_employees = employees;
			}
		}
	}
}
