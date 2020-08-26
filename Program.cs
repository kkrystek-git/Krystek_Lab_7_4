using System;
using System.Security.Cryptography;

namespace Krystek_Lab_7_4
{
	class Program
	{
		// =========================================================================
		// Name:	Keith Krystek
		// Date:	07.26.2020
		// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
		//
		// Assignment: Lab 7_4
		// =========================================================================


		static void Main(string[] args)
		{
			// Create dating profiles and bios.

				DatingProfile elmer = new DatingProfile("Elmer", "Fudd", 53, "Male");
				elmer.WriteBio ("Likes to hunt wabbits!");

				DatingProfile ww = new DatingProfile("Wonder", "Woman", 33, "Female");
				ww.WriteBio ("Saves the world every day!");


			// Send messages back and forth.

			elmer.SendMessage ("Help Saving the World","Hello Wonder Woman -- Do you need help saving the world today?", ww);

			ww.SendMessage ("Saving the World", "No Elmer, I don't want you to wisk your wife saving the world!", elmer);

			elmer.SendMessage (elmer.FirstName + "'s Bio", elmer.Bio, ww);

			ww.SendMessage (ww.FirstName + "'s Bio", ww.Bio, elmer);


			// Check messages.

			ww.ReadMessages();

			elmer.ReadMessages();

			// Test if isRead variable works.

			ww.ReadMessages();

			elmer.ReadMessages();

		}
	}
}
