using System;

namespace Assignment1
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("\nSelect an option to test:");
				Console.WriteLine("1. Test Pet class");
				Console.WriteLine("2. Test TicketSeller class");
				Console.WriteLine("3. Test Album class");
				Console.WriteLine("4. Test Book class");
				Console.WriteLine("5. Exit");
				Console.Write("Enter your choice: ");

				if (!int.TryParse(Console.ReadLine(), out int choice))
				{
					Console.WriteLine("Please enter a valid number.");
					continue;
				}

				switch (choice)
				{
					case 1:
						Pet myPet = new Pet();
						myPet.Start();
						break;
					case 2:
						TicketSeller seller = new TicketSeller();
						seller.Start();
						break;
					case 3:
						Album myAlbum = new Album();
						myAlbum.Start();
						break;
					case 4:
						Book myBook = new Book();
						myBook.Start();
						break;
					case 5:
						Console.WriteLine("Exiting program.");
						return;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}
	}
}
