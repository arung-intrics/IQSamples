using RecurrenceCalculator;

namespace OutlookRecurrenceTestProject;

[TestClass]
public class RecurrenceCalculatorTests
{
    [TestMethod]
    public void Check_Monthly_Recurrences_With_End_Date()
    {
        var recurrence = new AppointmentRecurrence
        {
            RecurrenceType = RecurrenceType.Monthly,
            Interval = 1,
            DayOfMonth = 8,
            StartDate = new (2024, 5, 9), // May 9th, 2024,
            Occurrences = 0,
            EndDate = new (2024, 8, 15)
        };

        var occurrences = (new Calculator()).CalculateOccurrences(recurrence).ToList();
        Assert.AreEqual(3, occurrences.Count, "Should create 3 occurrences");
    }
}

public class AppointmentRecurrence : IRecurrence
{
    public int DayOfMonth { get; set; }
    public bool Sunday { get; set; }
    public bool Monday { get; set; }
    public bool Tuesday { get; set; }
    public bool Wednesday { get; set; }
    public bool Thursday { get; set; }
    public bool Friday { get; set; }
    public bool Saturday { get; set; }
    public int Instance { get; set; }
    public int Interval { get; set; }
    public int MonthOfYear { get; set; }
    public int Occurrences { get; set; }
    public DateTime StartDate { get; set; }
    public RecurrenceType RecurrenceType { get; set; }
    public DateTime? EndDate { get; set; }
}