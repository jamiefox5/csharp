using System;

public static class PigLatin
{
    public static string Translate(string word)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        int index = word.IndexOfAny(vowels, 0, 1);
        if (index == 0)
        {
            return word + "ay";
        }


        /*if (word.Substring(0, 1) == "a")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "e")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "i")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "o")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "u")
        {
            return word + "ay";
        }*/

        else if (word.Substring(0, 1) == "m")
        {
            string diagraph = word.Substring(0, 1);
            string restOfWord = word.Substring(1);
            return restOfWord + diagraph + "ay";

        }
        else if (word.Substring(0, 3) == "equ")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 2) == "yt")
        {
            return word + "ay";
        }

        else if (word.Substring(0, 2) == "xr")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 2) == "ch")
        {
            string diagraph = word.Substring(0, 2);
            string restOfWord = word.Substring(2);
            return restOfWord + diagraph + "ay";

        }

        else if (word.Substring(0, 3) == "squ")
        {
            string consonantDiagraph = word.Substring(0, 3);
            string restOfWord = word.Substring(3);
            return restOfWord + consonantDiagraph + "ay";
        }
        else if (word.Substring(0, 2) == "th")
        {

            if (word.Substring(0, 3) == "thr")
            {
                string consonantDiagraph = word.Substring(0, 3);
                string restOfWord = word.Substring(3);
                return restOfWord + consonantDiagraph + "ay";
            }
            else
            {
                string diagraph = word.Substring(0, 2);
                string restOfWord = word.Substring(2);
                return restOfWord + diagraph + "ay";
            }
        }

        else if (word.Substring(0, 2) == "qu")
        {
            string diagraph = word.Substring(0, 2);
            string restOfWord = word.Substring(2);
            return restOfWord + diagraph + "ay";
        }


        else if (word.Substring(0, 3) == "sch")
        {
            string consonantDiagraph = word.Substring(0, 3);
            string restOfWord = word.Substring(3);
            return restOfWord + consonantDiagraph + "ay";
        }

        else if (word.Substring(0, 2) == "rh")
        {
            string diagraph = word.Substring(0, 2);
            string restOfWord = word.Substring(2);
            return restOfWord + diagraph + "ay";

        }

        else
        {
            string firstLetter = word.Substring(0, 1);
            string restOfWord = word.Substring(1);
            return restOfWord + firstLetter + "ay";
        }


    }

}
