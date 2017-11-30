using System;
using System.Collections.Generic;
using System.Text;

namespace Jala.Common.Observer
{
    public abstract class Observable
    {
		private List<IObserver> Observers = new List<IObserver>();

		public void Subscribe(IObserver i)
		{
			Observers.Add(i);
		}

		public void Unsubscribe(IObserver i)
		{
			Observers.Remove(i);
		}

		public void Notify(string[] args = null)
		{
			foreach(IObserver o in Observers)	{
				o.Update(args);
			}
		}
    }
}
