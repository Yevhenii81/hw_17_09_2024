using Class_Student_hw_25_06_2024;
using Class_Group_hw_27_06;

namespace Class_Group_hw_27_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Student", "Studenkov", "Studenkovich", DateTime.Now, new List<int> { 8, 7, 9 }, new List<int> { 9, 9, 9 }, new List<int> { 8, 7, 9 });
            Student student2 = new Student("Petya", "Petrovkin", "Vasilievich", DateTime.Now, new List<int> { 6, 5, 6 }, new List<int> { 5, 6, 6 }, new List<int> { 6, 5, 6 });
            Student student3 = new Student("Mikhail ", "Zubenko", "Petrovich", DateTime.Now, new List<int> { 9, 10, 9 }, new List<int> { 10, 9, 9 }, new List<int> { 9, 10, 9 });

            Student.NameComparatorAZ nameComparatorAZ = new Student.NameComparatorAZ();
            Student.NameComparatorZA nameComparatorZA = new Student.NameComparatorZA();

            //сравнение по имени по возрастанию
            List<Student> studentsByNameAZ = new List<Student> { student1, student2, student3 };
            studentsByNameAZ.Sort(nameComparatorAZ);
            Console.WriteLine("Students sorted by name (A-Z):");
            foreach (var student in studentsByNameAZ)
            {
                Console.WriteLine(student.GetName());
            }

            //сравнение по имени по убыванию
            List<Student> studentsByNameZA = new List<Student> { student1, student2, student3 };
            studentsByNameZA.Sort(nameComparatorZA);
            Console.WriteLine("\nStudents sorted by name (Z-A):");
            foreach (var student in studentsByNameZA)
            {
                Console.WriteLine(student.GetName());
            }

            //тестирование реализации IEnumerable в классе Group
            Group group = new Group("P26", 1, Speciallization.SoftwareDeveloper, new List<Student> { student1, student2, student3 });

            Console.WriteLine("\nStudents in the group:");
            foreach (Student student in group)
            {
                Console.WriteLine(student.GetName());
            }
        }
    }
}
