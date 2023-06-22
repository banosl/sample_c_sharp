// string? input;
// string inputTrimmed = "";
// bool validAnswer = false;

// do
// {
//   Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
//   input = Console.ReadLine();
//   if (input != null)
//   {
//     inputTrimmed = input.Trim();

//     if (inputTrimmed.ToLower() == "administrator" || inputTrimmed.ToLower() == "manager" || inputTrimmed.ToLower() == "user")
//     {
//       validAnswer = true;
//     }
//     else
//     {
//       Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User).");
//     }
//   }

// } while (validAnswer == false);

// Console.WriteLine($"Your input value ({input}) has been accepted.");