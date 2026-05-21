public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freq = new();

        // Count frequencies
        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;

            freq[num]++;
        }

        // Buckets: index = frequency
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in freq)
        {
            int number = pair.Key;
            int count = pair.Value;

            if (buckets[count] == null)
                buckets[count] = new List<int>();

            buckets[count].Add(number);
        }

        // Collect top k
        List<int> result = new();

        for (int i = buckets.Length - 1; i >= 0 ; i--)
        {
            if (buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return result.Take(k).ToArray();
    }
}
