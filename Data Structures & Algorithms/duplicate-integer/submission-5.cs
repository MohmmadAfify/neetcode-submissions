public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0)
        {
            return false;
        }

        var set = new HashSet<int>();
        foreach(int num in nums){
            // var numCount = nums.Count(n=>n == num);
            if(set.Contains(num)){
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}