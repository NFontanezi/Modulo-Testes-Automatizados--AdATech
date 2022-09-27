namespace LeapYear.Domain2
{
    public class LeapYearClass
    {
         public async Task<bool> IsLeap(int year)
        {
            Thread.Sleep(TimeSpan.FromSeconds(20));
            return  year % 4== 0 && year % 100!=0;
        }
    }
}