public class Solution {
    public int[] CountBits(int n) {
        
        int[] arr = new int[n + 1];


        for (int i = 0; i < arr.Length; i++){

            arr[i] = getNumBits(i);

        }

        return arr;

    }

    public int getNumBits(int n){

        int count = 0;

        while (n != 0){
            count += n%2;

            n /= 2;
        }

        return count;
    }
}
