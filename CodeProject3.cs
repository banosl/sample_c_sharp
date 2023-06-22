string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
// bool hasPeriods = true;

foreach(string myString in myStrings)
{
  string copyString = myString;

  while(copyString.Contains("."))
  {
    periodLocation = copyString.IndexOf(".");
    // Console.WriteLine(periodLocation);
    if (periodLocation == -1)
    {
      Console.WriteLine(copyString);
      // hasPeriods = false;
    }
    else
    {
      Console.WriteLine(myString.Substring(0, periodLocation + 1));
      copyString = myString.Remove(0, periodLocation + 2);
      Console.WriteLine(copyString);
    }
    
  } 

}