using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Jala.Common.Socket
{
    class Connection
    {
		private StreamReader sr;
		private StreamWriter sw;

		public Connection(Stream stream)
		{
			sr = new StreamReader(stream);
			sw = new StreamWriter(stream);
		}

		public void WriteLine(string msg)
		{
			sw.WriteLine(msg);
		}

		public string ReadLine()
		{
			return sr.ReadLine();
		}
    }
}
