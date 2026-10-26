using System;

class Program
{
    static bool Substring(string s1, string s2)
    {
        if(s1 == "" || s2 == "") 
        {
            Console.WriteLine("The strings is empty!");
            return false;
        }
            
        int FindSubstring(string s1, string s2, int k = 0)
        {
            if(k >= s1.Length) return -1;

            if(s2[0] == s1[k]) return k;

            return FindSubstring(s1,s2,k+1);
        }

        int findPos = FindSubstring(s1,s2);

        if (findPos >= 0)
        {
            return CheckSubstring(s1,s2,findPos);
        }

        return findPos == -1 ? false : true;
    }
    static bool CheckSubstring(string s1, string s2, int pos, int j = 0)
    {
        if(j == s2.Length) return true;

        if(s2[j] != s1[pos]) return false;

        return CheckSubstring(s1,s2,pos+1,j+1);
    }
    static void Main()
    {
        Console.WriteLine(Substring("abaxaba","xab"));
    }
}