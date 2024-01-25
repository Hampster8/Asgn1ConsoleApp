using System;

namespace Assignment1
{
	public class TicketSeller
	{
		private const double AdultTicketPrice = 100.0; // Example price, tinker with for customization
		private const double ChildDiscount = 0.25; // 25% discount for children

		private int numOfAdults;
		private int numOfChildren;
		private double amountToPay;

		// Start method
		public void Start()
		{
			ReadInput();
			CalculateAmountToPay();
			ShowResults();
		}

		// Method to read ticket information
		private void ReadInput()
		{
			Console.WriteLine("Enter the number of adult tickets sold:");
			numOfAdults = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the number of child tickets sold:");
			numOfChildren = int.Parse(Console.ReadLine());
		}

		// Method to calculate the total amount to pay
		private void CalculateAmountToPay()
		{
			amountToPay = (numOfAdults * AdultTicketPrice) +
							(numOfChildren * AdultTicketPrice * (1 - ChildDiscount));
		}

		// Method to display sales information
		private void ShowResults()
		{
			Console.WriteLine("Sales Information:");
			Console.WriteLine($"Adult tickets sold: {numOfAdults}");
			Console.WriteLine($"Child tickets sold: {numOfChildren}");
			Console.WriteLine($"Amount to pay: ${amountToPay:F2}");
		}
	}
}
