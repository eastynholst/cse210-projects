using System;
using System.Collections.Generic;

class Scripture
{
    private List<string> originalWords = new List<string>();
    private List<string> displayWords = new List<string>();
    private Hide hider = new Hide();
    private Random random = new Random();
        public Scripture()
    {
        originalWords.Add("Trust");
        originalWords.Add("in");
        originalWords.Add("the");
        originalWords.Add("Lord");
        originalWords.Add("with");
        originalWords.Add("all");
        originalWords.Add("thine");
        originalWords.Add("heart;");
        originalWords.Add("and");
        originalWords.Add("lean");
        originalWords.Add("not");
        originalWords.Add("unto");
        originalWords.Add("thine");
        originalWords.Add("own");
        originalWords.Add("understanding.");
        originalWords.Add("-");
        originalWords.Add("In");
        originalWords.Add("all");
        originalWords.Add("thy");
        originalWords.Add("ways");
        originalWords.Add("acknowledge");
        originalWords.Add("him,");
        originalWords.Add("and");
        originalWords.Add("he");
        originalWords.Add("shall");
        originalWords.Add("direct");
        originalWords.Add("thy");
        originalWords.Add("paths.");

        for (int i = 0; i < originalWords.Count; i++)
        {
            displayWords.Add(originalWords[i]);
        }
    }
        public string GetDisplayText()
    {
        string result = "";
        for (int i = 0; i < displayWords.Count; i++)
        {
            if (i > 0) result += " " ;
            result += displayWords[i];
        }
        return result;
    }

    public int HideSomeWords()
    {
       int hiddenCount = 0;
       int visibleCount = -4;
       for (int i = 0; i < displayWords.Count; i++)
            {
                if (displayWords[i] == originalWords[i])
                {
                    visibleCount++;
                }
            }
        if (visibleCount == -4)
        {
            return 0;
        }

       while (hiddenCount < 4 && visibleCount > -4)
        {
            int position = random.Next(displayWords.Count);

            if (displayWords[position] == originalWords[position])
            { 
                string originalWord = originalWords[position];
                string dashes = hider.GetDashes(originalWord);
                displayWords[position] = dashes;
                hiddenCount++;
                visibleCount--;

            }
        }
        return visibleCount;
    }
}