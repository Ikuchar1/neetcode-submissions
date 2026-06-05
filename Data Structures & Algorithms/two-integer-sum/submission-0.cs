public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> set = new HashSet<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
 
        int diff;
        int num;

        for(int i = 0; i < nums.Length; i++){
            num = nums[i];
            diff = target - num;

            if (dict.ContainsKey(diff)){
                return new int[] {dict[diff], i};
            } else {
                //add it to dict
                dict.Add(num, i);
            }
        }

        return new int[] {0,0};
    }
}
