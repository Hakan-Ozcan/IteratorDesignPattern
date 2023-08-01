using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public interface IIterator
    {
        Student Next();
        bool HasNext();
    }
}
