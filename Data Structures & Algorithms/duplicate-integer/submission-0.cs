public class Solution {
    public bool hasDuplicate(int[] nums) {
        // bool hasDuplicate = false;
        var set = new HashSet<int>();

        foreach (int num in nums){
            //check to see if in set
            if (set.Contains(num)){
                return true;
            } else {
                set.Add(num);
            }
        }

        return false;
    }
}