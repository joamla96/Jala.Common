using System;
using System.Collections.Generic;
using System.Text;

namespace Jala.Common
{
    public interface IBaseRepositorySingleton
    {
        IBaseRepositorySingleton Instance { get; }
    }
}
