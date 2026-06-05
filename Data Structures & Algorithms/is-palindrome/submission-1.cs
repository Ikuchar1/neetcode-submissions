public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        char[] chars = s.ToCharArray();

        
        int i = 0;
        int j = chars.Length-1;

        char ci;
        char cj;

        while(i < j){
            ci = chars[i];
            cj = chars[j];

            //check to make sure they are viable
            while(i < j && !isValidChar(ci)){
                i++;
                ci = chars[i];
            }

            while(i < j && !isValidChar(cj)){
                j--;
                cj = chars[j];
            }

            //check to see if they are equal
            if(ci != cj){
                return false;
            }

            i++;
            j--;
        }

        return true;        
    }

    public bool isValidChar(char c){
        return char.IsLetterOrDigit(c);
    }
}
