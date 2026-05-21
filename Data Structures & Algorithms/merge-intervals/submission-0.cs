public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        var output = new List<int[]>();
        output.Add(intervals[0]);

        foreach(int[] interval in intervals){
            var start = interval[0]; //1
            var end = interval[1]; //5

            var lastEnd = output[output.Count - 1][1]; //3

            if(start <= lastEnd){
                output[output.Count - 1][1] = Math.Max(end, lastEnd);
            }else{
                output.Add(interval);
            }
        }

        return output.ToArray();
    }
}
