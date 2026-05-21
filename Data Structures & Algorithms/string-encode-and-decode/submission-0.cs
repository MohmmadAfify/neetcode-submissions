public class Solution {

    public string Encode(IList<string> strs) {
        var res = new StringBuilder();
        foreach(var s in strs){
            res.Append($"{s.Length}#{s}");
        }

        return res.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        int i=0;

        while(i<s.Length){
            int j=i;
            while(s[j] != '#'){
                j++;
            }
            int length = int.Parse(s.Substring(i, j-i));
            i = j+1;
            j = i + length;
            res.Add(s.Substring(i, length));
            i = j;
        }

        return res;
   }
}
