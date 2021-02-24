using System;
using System.Collections.Generic;

namespace Allergy
{
  public class AllergyCheck
  {
    private int _score;
    private List<string> _allergies = new List<string>();

    public AllergyCheck(int score)
    {
      _allergies.Add("eggs");
      _allergies.Add("peanuts");
      _allergies.Add("shellfish");
      _allergies.Add("strawberries");
      _allergies.Add("tomatoes");
      _allergies.Add("chocolate");
      _allergies.Add("pollen");
      _allergies.Add("cats");
      _score = score;
    }

    public int GetScore()
    {
      return _score;
    }
    public List<string> GetList()
    {
      return _allergies;
    }
    public string GetAllergies()
    {
      int remainder = _score;
      string binaryCheck = "";
      string returnedString = "";
      List<String> newList = GetList();

      for (int i = 0; i < 8; i++)
      {
        int remainderMod = remainder % 2;
        binaryCheck = binaryCheck + remainderMod.ToString();
        remainder = remainder / 2;
        if (binaryCheck[i] == '1')
        {
          returnedString = returnedString + String.Join("", newList[i]) + " ";
        }
      }
      return returnedString;
    }
  }
}





      //Convert Number to Binary
      // int divider = 128;
      // for (int i = 0; i != 0)
      // {
      //   Console.WriteLine("remainder: {0}", remainder);
      //   // Console.WriteLine(divider);
      //   Console.WriteLine("remainder/divider: {0}", (remainder / 2));
      //   // Console.WriteLine(remainder / divider >= 1);
      //   binaryOutput = binaryOutput + ToString(remainder % 2);
      //   remainder = remainder / 2;
      //   // divider = divider / 2;
      // }
      // Console.WriteLine(binaryOutput);