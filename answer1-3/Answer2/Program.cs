namespace Answer2;

class Program
{
    static async Task Main(string[] args)
    {
        StudentService studentService = new StudentService();
        foreach (var student in studentService.GetWhoHasRichFriend())
        {
            Console.WriteLine(student);
        }
    }
}