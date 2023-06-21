Console.WriteLine("Enter an integer value between 5 and 10");
bool check = false;
string input;
do
{
  input = Console.ReadLine(); //This breaks if a user doesn't enter anything or enters a non number after the first number like "1t"

  if (Char.IsDigit(input, 0))
  {
    int number = Convert.ToInt32(input);
    if(number < 5 || number > 10)
    {
      Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
    }
    else
    {
      check = true;
    }
  }
  else  
  {
    Console.WriteLine($"You entered {input}. Please enter a valid number.");
  }

} while(check == false);

Console.WriteLine($"Your input value ({input}) has been accepted.");