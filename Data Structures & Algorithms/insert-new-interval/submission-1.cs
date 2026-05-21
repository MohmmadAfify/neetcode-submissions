public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        intervals = intervals.Append(newInterval).ToArray();
        Array.Sort(intervals, (a,b)=> a[0].CompareTo(b[0]));

        var output = new List<int[]>();
        output.Add(intervals[0]);

        foreach(var interval in intervals){
            var lastEnd = output[output.Count - 1][1];

            if(interval[0] <= lastEnd){
                output[output.Count - 1][1] = Math.Max(interval[1], lastEnd);
            }else{
                output.Add(interval);
            }
        }

        return output.ToArray();
    }
}
