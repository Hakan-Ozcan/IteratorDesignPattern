using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class StudentIterator : IIterator
    {
        private StudentCollection collection;
        private int currentIndex;

        public StudentIterator(StudentCollection collection)
        {
            this.collection = collection;
            currentIndex = 0;
        }

        public Student Next()
        {
            Student student = collection[currentIndex];
            currentIndex++;
            return student;
        }

        public bool HasNext()
        {
            return currentIndex < collection.Count;
        }
    }
}
