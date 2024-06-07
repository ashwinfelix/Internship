using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public int vowelFind(string sentence)
    {
        int vowNum = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


        foreach (char c in sentence)
        {
            char lower = char.ToLower(c);
            if (Array.IndexOf(vowels, lower) != -1)
            {
                vowNum++;
            }

        }

        return vowNum;

    }

    public int integerFind(string sentence)
    {
        int intCount = 0;
        foreach (char c in sentence)
        {
            if (char.IsDigit(c))
            {
                intCount++;
            }
        }
        return intCount;
    }

    public int wordFind(string sentence)
    {
        char[] seperators = { ' ', '.' };
        string[] lol = sentence.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        return lol.Length;
    }

    public int AlphaFind(string sentence)
    {
        int alphaNum = 0;
        char[] seperators = { ' ', '.' };
        string[] lol = sentence.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string a in lol)
        {
            alphaNum += a.Length;
        }
        return alphaNum;
    }
    public int specialFind(string sentence)
    {
        int specCount = 0;
        foreach (char c in sentence)
        {
            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
            {
                specCount++;
            }

        }
        return specCount;
    }

    public int dupliWords(string sentence)
    {
        int dupliCount = 0;
        string check = string.Empty;
        char[] seperators = [' ', '.'];
        string[] lol = sentence.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string a in lol)
        {
            check = a;
            foreach (string b in lol)
            {
                if (a.Equals(b, StringComparison.OrdinalIgnoreCase))
                {
                    dupliCount++;

                }
            }
        }
        return (dupliCount - lol.Length) / 2;

    }

    public int alphawords(string sentence)
    {
        int alpahnumCount = 0;
        char[] seperators = [' ', '.'];
        string[] lol = sentence.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
        foreach (string a in lol)
        {
            bool check1 = false;
            bool check2 = false;
            foreach (char b in a)
            {
                if (char.IsDigit(b)){
                    check1 = true;
                }
                else if (char.IsLetter(b)){
                    check2 = true;
                }

                else{
                    check1 = check2 = false;
                    break;
                }
                

        }
        if (check1 && check2){
                    alpahnumCount++;
                }
        
    }
    return alpahnumCount;
    }


    private static void Main(string[] args)
    {
        Console.Write("Enter your sentence:");
        string sentence = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Woud you like to switch any words?");
        string option = Console.ReadLine()?.ToLower() ?? string.Empty;
        switch (option)
        {
            case "no":

                Program program = new();
                int vowelNumber = program.vowelFind(sentence);
                Console.WriteLine($"The number of vowels are:{vowelNumber}");
                int IntNumber = program.integerFind(sentence);
                Console.WriteLine($"The number of intergers are:{IntNumber}");
                int WordNumber = program.wordFind(sentence);
                int specNumber = program.specialFind(sentence);
                Console.WriteLine($"The number of special characters are:{specNumber}");
                Console.WriteLine($"The number of words are:{WordNumber - IntNumber - specNumber}");
                int alphaNumber = program.AlphaFind(sentence);
                Console.WriteLine($"The number of alphanumeric characters are:{alphaNumber}");
                int dupliNumber = program.dupliWords(sentence);
                int alphaWord = program.alphawords(sentence);
                Console.WriteLine($"The number of alphanumeric words are:{alphaWord}");
                Console.WriteLine($"The number of duplicate words are:{dupliNumber}");
                break;

            case "yes":
                Console.WriteLine("Enter the word you want to replace.");
                string word1 = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Enter the word.");
                string word2 = Console.ReadLine() ?? string.Empty;
                string newSentence = sentence.Replace(word1, word2);


                Console.WriteLine($"The new sentence is: \n{newSentence}");

                Console.WriteLine("Would you like to check the stats of this sentence?:");
                string option2 = Console.ReadLine()?.ToLower() ?? string.Empty;

                switch (option2)
                {
                    case "yes":
                        Program program1 = new();
                        int vowelNumber1 = program1.vowelFind(newSentence);
                        Console.WriteLine($"The number of vowels are:{vowelNumber1}");
                        int IntNumber1 = program1.integerFind(newSentence);
                        Console.WriteLine($"The number of intergers are:{IntNumber1}");
                        int WordNumber1 = program1.wordFind(newSentence);
                        int specNumber1 = program1.specialFind(newSentence);
                        Console.WriteLine($"The number of special characters are:{specNumber1}");
                        Console.WriteLine($"The number of words are:{WordNumber1 - IntNumber1 - specNumber1}");
                        int alphaNumber1 = program1.AlphaFind(newSentence);
                        Console.WriteLine($"The number of alphanumeric characters are:{alphaNumber1}");
                        int dupliNumber1 = program1.dupliWords(newSentence);
                        int alphaWord1 = program1.alphawords(newSentence);
                        Console.WriteLine($"The number of alphanumeric words are:{alphaWord1}");
                        Console.WriteLine($"The number of duplicate words are:{dupliNumber1}");
                        break;
                    case "no":
                        Console.WriteLine("Exiting Program.");
                        break;
                }



                break;




        }




    }
}
