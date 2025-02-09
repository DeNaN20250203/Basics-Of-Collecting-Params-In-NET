namespace BasicsOfCollectingParamsInNET8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, .NET8!");
			Employee employees = new Employee(new List<string> { "Potter", "Vovan" });
			employees._employees.AddRange(new List<string> { "Poc", "NaN" });

			foreach (var item in employees._employees)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}



		public class Employee
		{
			public List<string> _employees;

			public Employee(List<string> employees)
			{
				_employees = employees;
			}
		}
	}
}
