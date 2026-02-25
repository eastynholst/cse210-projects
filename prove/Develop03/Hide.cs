using System;
using System.Collections.Generic;

class Hide
{
  public string GetDashes(string word)
    {
        string dashes = "";
            for (int i = 0; i < word.Length; i++)
            {
                dashes += "_";
            }
            return dashes;
    }
}