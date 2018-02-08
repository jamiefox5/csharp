using System;
using System.Text;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string[] wrds = wrd.Split(' ');
        string translation = "";
        StringBuilder output = new StringBuilder();
        string result = "";




        if (word.Substring(0, 1) == "a")
        {
            translation = word + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 1) == "e")
        {
            translation = word + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 1) == "i")
        {
            translation = word + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 1) == "o")
        {
            translation = word + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 1) == "u")
        {
            translation = word + "ay";
            output.Append(translation);
        }

        else if (word.Substring(0, 1) == "m")
        {
            string diagraph = word.Substring(0, 1);
            string restOfWord = word.Substring(1);
            translation = restOfWord + diagraph + "ay";
            output.Append(translation);

        }
        else if (word.Substring(0, 3) == "equ")
        {
            translation = word + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 2) == "yt")
        {
            translation = word + "ay";
            output.Append(translation);
        }

        else if (word.Substring(0, 2) == "xr")
        {
            translation = word + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 2) == "ch")
        {
            string diagraph = word.Substring(0, 2);
            string restOfWord = word.Substring(2);
            translation = restOfWord + diagraph + "ay";
            output.Append(translation);

        }

        else if (word.Substring(0, 3) == "squ")
        {
            string consonantDiagraph = word.Substring(0, 3);
            string restOfWord = word.Substring(3);
            translation = restOfWord + consonantDiagraph + "ay";
            output.Append(translation);
        }
        else if (word.Substring(0, 2) == "th")
        {

            if (word.Substring(0, 3) == "thr")
            {
                string consonantDiagraph = word.Substring(0, 3);
                string restOfWord = word.Substring(3);
                translation = restOfWord + consonantDiagraph + "ay";
                output.Append(translation);
            }
            else
            {
                string diagraph = word.Substring(0, 2);
                string restOfWord = word.Substring(2);
                translation = restOfWord + diagraph + "ay";
                output.Append(translation);
            }
        }

        else if (word.Substring(0, 2) == "qu")
        {
            string diagraph = word.Substring(0, 2);
            string restOfWord = word.Substring(2);
            translation = restOfWord + diagraph + "ay";
            output.Append(translation);
        }


        else if (word.Substring(0, 3) == "sch")
        {
            string consonantDiagraph = word.Substring(0, 3);
            string restOfWord = word.Substring(3);
            translation = restOfWord + consonantDiagraph + "ay";
            output.Append(translation);
        }

        else if (word.Substring(0, 2) == "rh")
        {
            string diagraph = word.Substring(0, 2);
            string restOfWord = word.Substring(2);
            translation = restOfWord + diagraph + "ay";
            output.Append(translation);

        }

        else
        {
            string firstLetter = word.Substring(0, 1);
            string restOfWord = word.Substring(1);
            translation = restOfWord + firstLetter + "ay";
            output.Append(translation);
        }

        {
            output.Append(" ");
        }

        {
            result = output.ToString().TrimEnd();
            return result;
        }



        {
