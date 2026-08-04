/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        //go and sort by starting time
        //then go one by one, if the next start time is less than the current end time return false

        var sorted = intervals.OrderBy(p => p.start).ToList();

        for(int i = 0; i < sorted.Count - 1; i++){
            Interval interv1 = sorted[i];
            Interval interv2 = sorted[i + 1];

            if(interv2.start < interv1.end){
                return false;
            }
        }

        return true;
        
    }
}
