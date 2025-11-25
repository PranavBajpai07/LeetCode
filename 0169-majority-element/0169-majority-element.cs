public class Solution {
    public int MajorityElement(int[] nums) 
    {
        int majElement= nums[0];
        int count=0;
        for(int i=0;i<nums.Length;i++){
            if(count==0){
                majElement =nums[i];
            }
            if(nums[i]==majElement){
                count++;
            }
            else{
                count--;
            }
        }
        return majElement;
    }
}