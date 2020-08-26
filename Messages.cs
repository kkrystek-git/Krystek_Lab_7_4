using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Krystek_Lab_7_4
{
	class Messages
	{
		// Create messages class.
		public DatingProfile Sender;
		public string MessageTitle;
		public string MessageData;
		public bool isRead = false;
		public int MessageNumber;

		// Create messages constructor.
		public Messages(DatingProfile Sender, string MessageTitle, string MessageData)
	{
			this.Sender = Sender;
			this.MessageTitle = "Subject: " + MessageTitle;
			this.MessageData = "Content: " + MessageData;
			//isRead = false;
		}
	}
}
