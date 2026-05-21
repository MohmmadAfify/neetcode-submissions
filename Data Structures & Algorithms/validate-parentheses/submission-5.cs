public class Solution {
    public bool IsValid(string s) {
        if(s.Length ==0 || s.Length ==1 || s.Length %2 != 0){
            return false;
        }

        Stack<char> stack = new Stack<char>();
        
        // Define matches for different types
        var pairs = new Dictionary<char, char> {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s) {
            // If it's an opening bracket, push to stack
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } 
            // If it's a closing bracket, check for a match
            else if (pairs.ContainsKey(c)) {
                if (stack.Count == 0 || stack.Pop() != pairs[c]) {
                    return false; // Unmatched or wrong order
                }
            }
        }
        
        // If stack is empty, all brackets were matched
        return stack.Count == 0;
    }
}
