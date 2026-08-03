public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        foreach (int num in set){
            Console.WriteLine(num);
        }

        for (int i = 0; i < nums.Length + 1; i++){
            if(!set.Contains(i)){
                return i;
            }
        }

        return -1;

    }
}
