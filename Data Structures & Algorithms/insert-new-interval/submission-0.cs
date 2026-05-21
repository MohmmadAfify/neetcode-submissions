public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        intervals = intervals.Append(newInterval).ToArray();
        Array.Sort(intervals, (a,b)=> a[0].CompareTo(b[0]));

        var output = new List<int[]>();
        output.Add(intervals[0]);

        foreach(var interval in intervals){
            var start = interval[0];
            var end = interval[1];

            var lastEnd = output[output.Count - 1][1];

            if(start <= lastEnd){
                output[output.Count - 1][1] = Math.Max(end, lastEnd);
            }else{
                output.Add(interval);
            }
        }

        return output.ToArray();
    }
}
