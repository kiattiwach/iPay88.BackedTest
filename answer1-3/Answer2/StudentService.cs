namespace Answer2;

public class StudentService
{
    private readonly List<Student> _studentsDummy = new List<Student>()
    {
        new Student() { Id = 1, Name = "Ashley" },
        new Student() { Id = 2, Name = "Samantha" },
        new Student() { Id = 3, Name = "Julia'" },
        new Student() { Id = 4, Name = "Scarlet" },
    };

    private readonly List<Friend> _friendsDummy = new List<Friend>()
    {
        new Friend() { Id = 1, FriendId = 2 },
        new Friend() { Id = 2, FriendId = 3 },
        new Friend() { Id = 3, FriendId = 4 },
        new Friend() { Id = 4, FriendId = 1 }
    };

    private readonly List<Package> _packagesDummy = new List<Package>()
    {
        new Package() { Id = 1,Salary = (decimal)15.2},
        new Package() { Id = 2,Salary = (decimal)10.06},
        new Package() { Id = 3,Salary = (decimal)11.55},
        new Package() { Id = 4,Salary = (decimal)12.12}
    };

    public string[] GetWhoHasRichFriend()
    {
        return (from student in _studentsDummy
            join f in _friendsDummy on student.Id equals f.Id into friends
            from friend in friends.DefaultIfEmpty()
            join studentPackage in _packagesDummy on friend.Id equals studentPackage.Id
            join friendPackage in _packagesDummy on friend.FriendId equals friendPackage.Id
            where friendPackage.Salary > studentPackage.Salary
            orderby friendPackage.Salary
            select student.Name).ToArray();
    }
}