using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interface
{
    public interface IService<T>
    {
        T[] FindAll();
        void Create(T t);
    }
}
