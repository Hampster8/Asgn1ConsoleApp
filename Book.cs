using System;

namespace Assignment1
{
	public class Book
	{
		private string title;
		private double price;
		private int yearPublished;
		private const double BaseDiscountRate = 0.05; // 5% base discount rate

		// Start method
		public void Start()
		{
			ReadBookInfo();
			DisplayBookInfo();
			DisplayDiscountedPrice();
		}

		// Method to read book information
		private void ReadBookInfo()
		{
			Console.WriteLine("Enter the book title:");
			title = Console.ReadLine();

			Console.WriteLine("Enter the book price:");
			price = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter the year of publication:");
			yearPublished = int.Parse(Console.ReadLine());
		}

		// Method to display book information
		private void DisplayBookInfo()
		{
			Console.WriteLine("Book Information:");
			Console.WriteLine($"Title: {title}");
			Console.WriteLine($"Price: ${price}");
			Console.WriteLine($"Year of Publication: {yearPublished}");
		}

		// Method to display discounted price
		private void DisplayDiscountedPrice()
		{
			int currentYear = DateTime.Now.Year;
			int bookAge = currentYear - yearPublished;
			double discountRate = BaseDiscountRate + (bookAge * 0.01); // Additional 1% discount for each year of age
			double discountedPrice = price * (1 - Math.Min(discountRate, 0.5)); // Maximum discount of 50%

			Console.WriteLine($"Discounted Price: ${discountedPrice:F2} (Discount Rate: {discountRate:P2})");
		}
	}

}
