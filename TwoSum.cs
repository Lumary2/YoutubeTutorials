public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        
        int []result=new int[2];
        int[]numbers=nums;
        
        for(int i=0;i<nums.Length;i++){
            
            for(int j=i+1;j<nums.Length;j++){
                
                if(numbers[i]+numbers[j]==target){
                    result[0]=i;
                    result[1]=j;
                    return result;
                    
                }
                
            }
        }
        return result;
        
    }
}
