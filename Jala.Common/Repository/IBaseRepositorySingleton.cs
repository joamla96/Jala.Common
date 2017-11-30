using System;
using System.Collections.Generic;
using System.Text;

namespace Jala.Common.Repository
{
    public interface IBaseRepositorySingleton
    {
        IBaseRepositorySingleton Instance { get; }
    }
}
