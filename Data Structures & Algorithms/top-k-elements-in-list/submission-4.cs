public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numsList = nums.ToList();
        numsList = numsList.GroupBy(x => x)
                            .Select(g => new { Number = g.Key, Count = g.Count() })
                            .OrderByDescending(x => x.Count)
                            .Select(x => x.Number)
                            .ToList();

        return numsList.Take(k).ToArray();
    }
}
