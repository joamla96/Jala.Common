using System;
using System.Collections.Generic;
using System.Text;

namespace Jala.Common
{
    class BaseRepositorySingleton<T> : BaseRepository<T>
    {
        private BaseRepositorySingleton<T> instance;
        public BaseRepositorySingleton<T> Instace { get {
                if(this.instance == null) { this.instance = new BaseRepositorySingleton<T>(); }
                return this.instance;
            }
        }
    }
}
