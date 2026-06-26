public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCount = 0;
        int count = 0;

        foreach (int num in nums) {
            if(num == 1) {
                count++;
            }
            else {
                count = 0;
            }

            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}