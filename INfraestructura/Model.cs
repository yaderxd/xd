using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class Model <T>
    {
        List<T> checherereque;

        public void add(T t)
        {
            checherereque.Add(t);
        }

        public List<T> Mostrar()
        {
            return checherereque;
        }
    }
}






