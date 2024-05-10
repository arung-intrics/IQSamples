using Express.Recurrence;
namespace OutlookRecurrenceTestProject;

[TestClass]
public class ExpressRecurrenceTests
{
    [TestMethod]
    public void Check_Monthly_Recurrences_With_End_Date()
    {        
        var basePattern = new BasePattern
        {
            StartDate = new(2024, 5, 9), // May 9th, 2024,
            EndDate = new(2024, 8, 15),
            EndMode = ENDMODE.ByDate
        };

        var monthPattern = new MonthlyReccurance
        {
            Constrain = MONTHCONSTRAIN.SpecificDay,
            DayOfMonth = 8,
            Next = 1,
        };
        
        var occurrences = Reccurance.GenerateMonths(basePattern, monthPattern).Values;
        Assert.AreEqual(3, occurrences.Count, "Should create 3 occurrences");
    }
}
