public class Solution33 {
    public bool IsPalindrome(int x) {
        if (x < 0) return false; // negative numbers are not palindromes
        
        int original = x;
        int reversed = 0;
        
        while (x > 0) {
            int r = x % 10;
            x = x / 10;
            reversed = reversed * 10 + r;
        }
        
        return reversed == original;
    }
    public void Main1()
    {
        IsPalindrome(121);
        IsPalindrome(-121);

    }
}



