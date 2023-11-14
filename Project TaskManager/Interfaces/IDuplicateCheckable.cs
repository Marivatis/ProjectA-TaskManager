using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_TaskManager.Interfaces
{
    public interface IDuplicateCheckable<T>
    {
        bool IsDuplicate(T item);
    }
}