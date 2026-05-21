public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0 || s.Length == 1){
            return s.Length;
        }
        var dict = new Dictionary<char, int>();
        int l = 0;
        int res = 0;

        for(int r=0; r< s.Length; r++){
            if(dict.ContainsKey(s[r])){
                //move the left side
                l = Math.Max(dict[s[r]] + 1 , l);
            }
            dict[s[r]] = r;
            res = Math.Max(res, r-l +1);
        }

        return res;
    }
}
