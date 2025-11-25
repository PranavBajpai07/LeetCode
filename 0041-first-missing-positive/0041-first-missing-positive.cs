public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int len = nums.Length;
        
        // We plan to use 0 as a marker to denote which numbers in range 1 to len we have already encountered.
        // So, replace it with -1 as anyway 0 is of no interest to us 
        for(int i=0; i<len; i++)
        {
            if(nums[i] == 0)
                nums[i] = -1;
        }

        // If we get any number between 1 to len we are using the array index to mark that.
        // Using 0 as the marker to denote we have encountered the number.
        // example: if we get x which is in range 1 to len, we will mark nums[x-1] as 0.
        for(int i = 0; i < len; i++)
        {
            int n = nums[i];
            while(n > 0 && n <= len)
            {
                int next = nums[n-1];
                nums[n-1] = 0;
                n = next;
            }
        }

        // Get the non 0 index. It means we haven't encountered index+1 in the array. So, that is or answer.
        for(int i = 0; i < len; i++)
        {
            if(nums[i] != 0)
                return i+1;
        }

        // If we got all the numbers between 1 to n, then the first missing no is len+1
        return len+1;
    }
}