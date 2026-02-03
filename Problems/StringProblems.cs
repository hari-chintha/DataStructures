public static class StringProblems
{

    public char? NonRepeatingCharacter(string s)
    {
        if(string.IsNullOrWhiteSpace(s))
        {
            throw new ArgumentNullException(nameof(s));
        }
        //s = "apple mac"
        
        var dict = new Dictionary<char, int>();
        var res = ' ';
        var temp = ' ';

        foreach(var c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c] = dict[c]+1;
            }   
            else
            {
                dict.Add(c,1);
            }
        }
        foreach(var c in s)
        {
            if(dict[c]==1)
                return c;
        }
        return null;

        
    }
}