public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int area = 0;

        int left = 0;
        int right = heights.Length - 1;

        while (left < right){
            area = calcArea(heights, left, right);

            //check if new max
            maxArea = Math.Max(maxArea, area);

            if(heights[left] >= heights[right]){
                //move right pointer
                right--;
            } else {
                left++;
            }
        }
        
        return maxArea;
    }

    int calcArea(int[] h, int l, int r){

        int height = Math.Min(h[l], h[r]);
        int area = height * (r - l);
        return area;

    }
}
