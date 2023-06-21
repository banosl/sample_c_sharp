Console.WriteLine("Enter an integer value between 5 and 10");
bool check = false;
var input = Console.ReadLine(); 

do
{
  if (Char.IsDigit(input, 0))
  {
    int number = Convert.ToInt32(input);
    if(number < 5 || number > 10)
    {
      Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
      input = Console.ReadLine(); 
    }
    else
    {
      check = true;
    }
  }
  else  
  {
    Console.WriteLine($"You entered {input}. Please enter a valid number.");
    input = Console.ReadLine(); 
  }

} while(check == false);

Console.WriteLine($"Your input value ({input}) has been accepted.");