
namespace Assignment1
{
	public class Pet
	{
		private string name;
		private int age;
		private bool isFemale;

		public void ReadUserInfo()
		{
			Console.WriteLine("Enter Pet's Name:");
			name = Console.ReadLine();

			Console.WriteLine("Enter Pet's Age:");
			age = int.Parse(Console.ReadLine());

			Console.WriteLine("Is the Pet Female? (true/false):");
			isFemale = bool.Parse(Console.ReadLine());
		}

		// Method for displaying pet information
		public void DisplayPetInfo()
		{
			Console.WriteLine("Pet Information:");
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Is Female: {isFemale}");
		}

		public void Start()
		{

			
			ReadUserInfo();
			DisplayPetInfo();
		}
	}

}
