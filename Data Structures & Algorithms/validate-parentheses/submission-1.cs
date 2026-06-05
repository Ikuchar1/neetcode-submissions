public class Solution {
    public bool IsValid(string s) {
        char[] chars = s.ToCharArray();

        Stack<char> stack = new Stack<char>();

        foreach(char c in chars){
            Console.WriteLine(c);
            if (c == '(' || c == '[' || c == '{'){
                stack.Push(c);
            } else {
                //check to see if top is that opposite
                if(stack.Count == 0){
                    return false;
                }

                char top = stack.Peek();
                if (top == '('){
                    
                    if (c != ')'){
                        return false;
                    }
                    stack.Pop();
                } else if (top == '['){
                    if (c != ']'){
                        return false;
                    }
                    stack.Pop();
                } else if (top == '{'){
                    if (c != '}'){
                        return false;
                    }
                    stack.Pop();
                } else {
                    return false;
                }
                
                
            }
        }

        if(stack.Count == 0){
            return true;
        } else {
            return false;
        }
    }
}
