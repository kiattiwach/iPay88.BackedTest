namespace Answer3;

public class OccupationService
{
    private readonly List<Occupations> _occupationsDummy = new List<Occupations>()
    {
        new Occupations() { Name = "Samantha", Occupation = OccupationConstant.Doctor },
        new Occupations() { Name = "Julia", Occupation = OccupationConstant.Actor},
        new Occupations() { Name = "Maria", Occupation = OccupationConstant.Actor },
        new Occupations() { Name = "Meera", Occupation = OccupationConstant.Singer},
        new Occupations() { Name = "Ashley", Occupation = OccupationConstant.Professor },
        new Occupations() { Name = "Ketty", Occupation = OccupationConstant.Professor },
        new Occupations() { Name = "Christeen", Occupation = OccupationConstant.Professor },
        new Occupations() { Name = "Jane", Occupation = OccupationConstant.Actor },
        new Occupations() { Name = "Jenny", Occupation = OccupationConstant.Doctor },
        new Occupations() { Name = "Priya", Occupation = OccupationConstant.Singer },
    };

    public List<PeopleOccupationViewModel> CategorizePeopleByOccupation()
    {
        var data = new
        {
            Doctor = _occupationsDummy.Where(x => x.Occupation.Equals(OccupationConstant.Doctor))?.Select(p => p.Name)
                .ToList(),
            Professor = _occupationsDummy.Where(x => x.Occupation.Equals(OccupationConstant.Professor))
                ?.Select(p => p.Name).ToList(),
            Singer = _occupationsDummy.Where(x => x.Occupation.Equals(OccupationConstant.Singer))?.Select(p => p.Name)
                .ToList(),
            Actor = _occupationsDummy.Where(x => x.Occupation.Equals(OccupationConstant.Actor))?.Select(p => p.Name)
                .ToList()
        };

        var maxRow = _occupationsDummy.GroupBy(g => g.Occupation).Select(s => s.Count()).Max();


        return Enumerable.Range(0, maxRow).ToArray().Select(s => new PeopleOccupationViewModel()
        {
            OccupationMap = new Dictionary<string, string>()
            {
                { OccupationConstant.Doctor, GetPeopleName(data?.Doctor, s) },
                { OccupationConstant.Professor, GetPeopleName(data?.Professor, s) },
                { OccupationConstant.Singer, GetPeopleName(data?.Singer, s) },
                { OccupationConstant.Actor, GetPeopleName(data?.Actor, s) }
            }
        }).ToList();

        string GetPeopleName(IReadOnlyList<string>? people, int index)
        {
            return people?.Count < index + 1 ? "NULL" : people?[index]?? "NULL";
        }
    }
}

public class OccupationConstant
{
    public const string Doctor = "Doctor";
    public const string Professor = "Professor";
    public const string Singer = "Singer";
    public const string Actor = "Actor";
}