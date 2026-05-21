public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<int>>();
    for (int i = 0; i < strs.Length; i++)
    {           
        var chars = strs[i].ToCharArray();
        Array.Sort(chars);
        var orderStr = new string(chars);
        if (dict.TryGetValue(orderStr, out List<int> value))
        {
            dict[orderStr] = [..value, i];
        }
        else
        {
                dict.Add(orderStr, [i]);
        }
    }

    var lists = new List<List<string>>();
    foreach (var v in dict)
    {
        lists.Add(v.Value.Select(j => strs[j]).ToList());
    }

    return lists;
    }
}
