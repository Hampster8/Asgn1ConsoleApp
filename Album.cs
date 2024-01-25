using System;

namespace Assignment1
{
	public class Album
	{
		private string albumName;
		private string artistName;
		private int numOfTracks;

		// Start method
		public void Start()
		{
			ReadAlbumInfo();
			DisplayAlbumInfo();
		}

		// Method to read album information
		private void ReadAlbumInfo()
		{
			Console.WriteLine("Enter the album name:");
			albumName = Console.ReadLine();

			Console.WriteLine("Enter the artist's name:");
			artistName = Console.ReadLine();

			Console.WriteLine("Enter the number of tracks in the album:");
			numOfTracks = int.Parse(Console.ReadLine());
		}

		// Method to display album information
		private void DisplayAlbumInfo()
		{
			Console.WriteLine("Album Information:");
			Console.WriteLine($"Album Name: {albumName}");
			Console.WriteLine($"Artist Name: {artistName}");
			Console.WriteLine($"Number of Tracks: {numOfTracks}");
		}
	}

}
