string s = "rat";
string t = "tar";

Console.WriteLine(IsAnagramArray(s,t));

bool IsAnagramArray(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    var count = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        count[s[i] - 'a']++;
        count[t[i] - 'a']--;
    }

    return count.All(n => n == 0);
}


bool IsAnagramDictionary(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    var count = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        count[s[i]] = count.GetValueOrDefault(s[i], 0) + 1;
        count[t[i]] = count.GetValueOrDefault(t[i], 0) - 1;
    }

    return count.All(n => n.Value == 0);
}
