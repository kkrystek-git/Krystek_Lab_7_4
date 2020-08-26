using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Krystek_Lab_7_4
{
	class DatingProfile
	{
		// Create dating profile class.

		public string FirstName;
		private string LastName;
		public int Age;
		public string Gender;
		public string Bio;
		private List<Messages> myMessages;

		// Create dating profile constructor.
		public DatingProfile (string FirstName, string LastName, int Age, string Gender)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
			this.Gender = Gender;
			myMessages = new List<Messages>();
		}

		// Methods to write a bio, send messages, read messages.
		public void WriteBio(string bioText)
		{
			Bio = bioText;
		}

		public void ReadMessages()
		{

			foreach (Messages message in myMessages)
			{
				message.MessageNumber = 1;
				if (message.isRead == false)
				{
					Console.WriteLine("Message #" + message.MessageNumber);
					Console.WriteLine(message.MessageTitle);
					Console.WriteLine(message.MessageData);
					Console.WriteLine(" ");
					message.MessageNumber++;
					message.isRead = true;
				}
			}	
		}

		public void SendMessage(string MessageTitle, string MessageData, DatingProfile SendTo)
		{
			Messages message = new Messages (this, MessageTitle, MessageData);
			SendTo.AddToMailBox(message);
		}

		public void AddToMailBox (Messages message)
		{
			myMessages.Add(message);
		}

	}
}
