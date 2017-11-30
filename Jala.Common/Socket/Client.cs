using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Jala.Common.Socket
{
    public class Client
    {
		private ConcurrentQueue<string> MessageOut;
		private ConcurrentQueue<string> MessageIn;
		private Connection Connection;

		public Client(TcpClient client)
		{
			MessageIn = new ConcurrentQueue<string>();
			MessageOut = new ConcurrentQueue<string>();
			Connection = new Connection(client.GetStream());
		}

		public void SendMessage(string msg)
		{
			MessageOut.Enqueue(msg);
		}

		public string ReadMessage(bool block = false)
		{
			if(MessageIn.Count == 0 && block)
			{
				// Wait here
			}

			string message;
			MessageIn.TryDequeue(out message);

			return message;
		} 
    }
}
