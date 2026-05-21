public class Solution {
    public bool IsPalindrome(string s) {
        var ms = Regex.Replace(s, "[^a-zA-Z0-9]", "");
        ms = ms.ToLower();
        for (int i = 0; i < ms.Length / 2; i++)
        {
            if (ms[i] != ms[ms.Length - 1- i])
            {
                return false;
            }
        }
        return true;
    }
}
