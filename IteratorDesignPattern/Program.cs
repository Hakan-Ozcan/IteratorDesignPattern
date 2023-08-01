using IteratorDesignPattern;

public class Program
{
    public static void Main()
    {
        StudentCollection studentCollection = new StudentCollection();
        studentCollection.AddStudent(new Student(1, "Alice", 3.7));
        studentCollection.AddStudent(new Student(2, "Bob", 3.5));
        studentCollection.AddStudent(new Student(3, "Charlie", 3.2));

        IIterator iterator = new StudentIterator(studentCollection);
        while (iterator.HasNext())
        {
            Student student = iterator.Next();
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, GPA: {student.GPA}");
        }
    }
}