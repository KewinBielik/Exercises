using System;
class Program
{
    static int CountAE(string arg)
    {
        int score = 0;
        bool hasA = false, hasE = false;
        foreach(char c in arg) { 
            if (c == 'a')
            {
                hasA = true;
            }
            else if (c == 'e')
            {
                hasE = true;
            }
            else if (c == ' ')
            {
                if (hasA && hasE )
                {
                    score += 3;
                }
                else if (hasA)
                {
                    score++;
                }
                else if (hasE)
                {
                    score++;
                }
                hasA = false;
                hasE = false;
            }
        }
        // Here I have to do these ifs again because there is no space at the end of the sentence so it wont count the last word in the loop
        if (hasA && hasE)
        {
            score += 3;
        }
        else if (hasA)
        {
            score++;
        }
        else if (hasE)
        {
            score++;
        }

        // I am wondering if it's better to do a for loop and then have a condition like this: if (c == ' ' || i == arg.count)
        // this solution would take less space but is it cleaner? is faster? I think its for sure easier to change in future,
        // for example in case we want to score things differently - we would have to change it in just one place, not two.

        return score;
    }


    static void Main(string[] args)
    {
        string sentence = "Dave is a good person"; 
        Console.WriteLine(CountAE(sentence));
        
    }
}
