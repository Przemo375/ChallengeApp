// pierwszy sposób wypełniania tablicy 
int[] grades2 = new int[365];


List<string> dayofweeks = new List<string>();
dayofweeks.Add ("poniedziałek");
dayofweeks.Add("wtorek");
dayofweeks.Add("środa");
dayofweeks.Add("czwartek");
dayofweeks.Add("piątek");
dayofweeks.Add("sobota");
dayofweeks.Add("niedziela");

foreach (var day in dayofweeks) 
{
    Console.WriteLine (day);
}
 



