public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int maxCount = 0;
        int count = 0;
        char[] chars = s.ToCharArray();

        HashSet<char> set = new HashSet<char>();

        while (right < chars.Length){

            char curr = chars[right];
            char leftCurr = chars[left];

            if(set.Contains(curr)) {

                //it is in the set. 
                //start moving left pointer to the right until left curr char == right curr char
                
                //check if left curr and r curr are the same
                while(leftCurr != curr){
                    left++;
                    count--;
                    set.Remove(leftCurr);
                    leftCurr = chars[left];
                }

                //found it
                if(leftCurr == curr){
                    count--;
                    set.Remove(leftCurr);
                    left++;
                }

            }

            count++;
            maxCount = Math.Max(count, maxCount);
            set.Add(curr);

            right++;
        }

        return maxCount;

    }
}
