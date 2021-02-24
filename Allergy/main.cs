using System;
using Allergy;

namespace Program
{
class Program
{
  static void Main()
  {
    // program code goes here
    Console.WriteLine("Enter your allergy score:");
    string userScore = Console.ReadLine();
    AllergyCheck testAllergyCheck = new AllergyCheck(int.Parse(userScore));
    Console.WriteLine(testAllergyCheck.GetAllergies());
    
  }
}
}