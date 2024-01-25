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
			ReadAlbumName();
			ReadArtistName();
			ReadTracks();
			DisplayAlbumInfo();
		}

		// Method to read album name
		private void ReadAlbumName()
		{
			Console.WriteLine("Enter the album name:");
			albumName = Console.ReadLine();
		}

		// Method to read artist's name
		private void ReadArtistName()
		{
			Console.WriteLine("Enter the artist's name:");
			artistName = Console.ReadLine();
		}

		// Method to read number of tracks
		private void ReadTracks()
		{
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
