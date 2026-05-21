public class Solution {
    public bool hasDuplicate(int[] nums) {
        // nums.Sort();
        foreach(int num in nums){
            var numCount = nums.Count(n=>n == num);
            if(numCount >1){
                return true;
            }
        }
        return false;
    }
}