using System;

namespace Assignment1
{
	public class TicketSeller
	{
		private const double AdultTicketPrice = 20.0; // Example price, tinker with for customization
		private const double ChildDiscount = 0.25; // 25% discount for children

		private int adultTicketsSold;
		private int childTicketsSold;

		// Start method
		public void Start()
		{
			ReadTicketInfo();
			DisplaySalesInfo();
		}

		// Method to read ticket information
		private void ReadTicketInfo()
		{
			Console.WriteLine("Enter the number of adult tickets sold:");
			adultTicketsSold = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the number of child tickets sold:");
			childTicketsSold = int.Parse(Console.ReadLine());
		}

		// Method to display sales information
		private void DisplaySalesInfo()
		{
			double totalRevenue = (adultTicketsSold * AdultTicketPrice) +
								(childTicketsSold * AdultTicketPrice * (1 - ChildDiscount));

			Console.WriteLine("Sales Information:");
			Console.WriteLine($"Adult tickets sold: {adultTicketsSold}");
			Console.WriteLine($"Child tickets sold: {childTicketsSold}");
			Console.WriteLine($"Total revenue: ${totalRevenue:F2}");
		}
	}

}