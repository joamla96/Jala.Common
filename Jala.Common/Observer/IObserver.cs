using System;
using System.Collections.Generic;
using System.Text;

namespace Jala.Common.Observer
{
    public interface IObserver
    {
		void Update(string[] args);
    }
}
