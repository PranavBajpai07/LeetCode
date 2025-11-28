public class Solution {
    /// <summary>
    /// Calculates the sum of two integers without using the + or - operators.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The sum of a and b.</returns>
    public int GetSum(int a, int b) {
        // The loop continues as long as there is a carry to process (b != 0)
        while (b != 0) {
            // 1. Calculate the carry: Bits that are 1 in both a and b, shifted left.
            // In C#, int is 32-bit. The '&' and '<<' operators handle the 
            // two's complement representation correctly for addition.
            int carry = (a & b) << 1;
            
            // 2. Calculate the sum without carry: Bits that are 1 in a OR b, but not both.
            a = a ^ b;
            
            // 3. Update b to be the carry for the next iteration.
            b = carry;
        }
        
        // When the loop finishes, 'a' holds the final sum, as 'b' (the last carry) is 0.
        return a;
    }
}