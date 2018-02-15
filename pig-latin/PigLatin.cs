using System.Text;
using System;

public static class PigLatin
{

    public static string Translate(string word)
    {
        string[] words = word.Split(" ");
        // space at end of each string.. will separate for the phrase
        StringBuilder builder = new StringBuilder();
        string output = "";
        string translation = "";
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };


        foreach (var item in words)
        {
            //first letter is a vowel or begins with xr or yt
            int vowelIndex = item.IndexOfAny(vowels, 0, 1);

            if (vowelIndex == 0 || item.IndexOf("xr") == 0 || item.IndexOf("yt") == 0)
            {
                translation = word + "ay";
            }

            // first Letter of word is NOT a vowel Rules

            else
            {
                vowelIndex = item.IndexOfAny(vowels, 1, 1);

                // excluding "qu" as a word starting with 1 consonant
                //making sure "qu" is read as a pair and the u isn't read as a vowel

                if (item.IndexOf("qu") == 0)
                {
                    vowelIndex = -1;
                }

                // starts with 1 consonant > move first letter and add "ay"

                if (vowelIndex == 1)

                {
                    string firstLetter = item.Substring(0, 1);
                    string restOfWord = item.Substring(1);
                    translation = restOfWord + firstLetter + "ay";
                }

                else
                {
                    // 2 letter word and "y" is second letter > move first letter to end + "ay"

                    if (item.Length == 2)
                    {
                        if (item.Substring(1, 1) == "y")
                        {
                            string firstLetter = item.Substring(0, 1);
                            string restOfWord = item.Substring(1);
                            translation = restOfWord + firstLetter + "ay";
                        }
                    }

                    else
                    {
                        // starts with a consonant followed by "qu" > move first letter and "qu" to end and add "ay"

                        if (item.Contains("qu"))
                        {
                            int i = item.IndexOf("qu") + 1;
                            string firstLetters = item.Substring(0, i + 1);
                            string restOfWord = item.Substring(i + 1);
                            translation = restOfWord + firstLetters + "ay";

                        }

                        // "y' after consonant cluster > move consonant cluster NOT including "y" to end and add "ay"

                        else if (item.IndexOfAny(vowels) == -1 && item.Contains("y"))
                        {
                            int i = item.IndexOf("y");
                            string firstLetters = item.Substring(0, i);
                            string restOfWord = item.Substring(i);
                            translation = restOfWord + firstLetters + "ay";
                        }

                        // move consonant cluster (2 letters or 3 letters) to end and add "ay"

                        else
                        {
                            int i = item.IndexOfAny(vowels);
                            string firstLetters = item.Substring(0, i);
                            string restOfWord = item.Substring(i);
                            translation = restOfWord + firstLetters + "ay";
                        }
                    }
                }

            }
            builder.Append(translation + " ");


        }
        output = builder.ToString().TrimEnd();
        return output;

    }
}
