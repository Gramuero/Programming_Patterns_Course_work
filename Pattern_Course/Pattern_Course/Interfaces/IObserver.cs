using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Course.Interfaces
{
    // Интерфейс для Observer
    public interface IObserver
    {
        void Update(string message);
    }
}
