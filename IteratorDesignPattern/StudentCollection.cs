using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class StudentCollection : IEnumerable<Student>
    {
        private List<Student> students;

        public StudentCollection()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Indeksleyici özellik
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= students.Count)
                    throw new IndexOutOfRangeException("Invalid index");
                return students[index];
            }
        }

        public int Count => students.Count;

        public IEnumerator<Student> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
