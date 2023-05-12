namespace Answer3;

class Program
{
    static async Task Main(string[] args)
    {
        OccupationService service = new OccupationService();
        var models = service.CategorizePeopleByOccupation();
        models.ForEach(x =>
        {
            Console.WriteLine($"{x.OccupationMap[OccupationConstant.Doctor],-15}\t" +
                              $"{x.OccupationMap[OccupationConstant.Professor],-15}\t"+
                              $"{x.OccupationMap[OccupationConstant.Singer],-15}\t"+
                              $"{x.OccupationMap[OccupationConstant.Actor],-15}\t");
        });
    }
}