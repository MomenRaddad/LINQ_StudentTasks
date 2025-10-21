namespace Student_part3.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Alice", Score = 85 },
                new Student { Name = "Bob", Score = 55 },
                new Student { Name = "Charlie", Score = 70 },
                new Student { Name = "David", Score = 40 },
                new Student { Name = "sara", Score = 95 },
                new Student { Name = "Frank", Score = 60 },
                new Student { Name = "Grace", Score = 30 },
                new Student { Name = "Hannah", Score = 75 },
                new Student { Name = "Ian", Score = 50 },
                new Student { Name = "Sally", Score = 90 }




            };

            var studentAbove70 = students.FindAll(s => s.Score > 70).OrderByDescending(s => s.Score);

            Console.WriteLine("the student above 70 score \n");
            foreach (var item in studentAbove70)
            {
                Console.WriteLine($"Student Name:{item.Name}, Score:{item.Score}");

            }
            var studentGategory = students.GroupBy(s => s.Score >= 60 ? "Passed" : "Failed");
            Console.WriteLine("\nStudent Categories:");

            foreach (var group in studentGategory)
            {
                Console.WriteLine($"\n{group.Key} Students: {group.Count()}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Student Name: {student.Name}, Score: {student.Score}");
                }
            }
            // student whose name starts with 'S' (Non-sensitive)  and Have score above 85

            var studentStarts = students.FindAll(s => s.Name.StartsWith("S", StringComparison.OrdinalIgnoreCase) && s.Score > 85);

            Console.WriteLine("\nStudents whose names start with 'S' and have scores above 85:");
            foreach (var student in studentStarts)
            {
                Console.WriteLine($"Student Name: {student.Name}, Score: {student.Score}");


            }

        }
    }
}
