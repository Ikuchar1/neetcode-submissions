public class Solution {
    public int HammingWeight(uint n) {
        
        //loop thru x times. make var y = 1 if n & y = true,
        //count++, then shift it to the right y << 1, idk notation for it.
        uint y = 00000000000000000000000000000001;
        int count = 0;

        for(int i = 0; i < 32; i++){
            //check if equal
            if((n & y) != 0){
                count++;
            }

            //shift y bit to left
            y = y << 1;
        } 

        return count;

    }
}
