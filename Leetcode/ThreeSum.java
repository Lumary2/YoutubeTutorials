class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
      
        //sort the array
        Arrays.sort(nums);
        int leftP=1;
        int rightP=nums.length-1;
        List<List<Integer>>result=new ArrayList();

        
        
        for(int i=0;i<nums.length-2;i++){
            //avoid duplicates
            if(i>0&&nums[i]==nums[i-1]){
                continue;
            }
            
            leftP=i+1;
            rightP=nums.length-1;

            
            while(leftP<rightP
                
                 //&&i!=rightP
                 ){
                
             
           if(nums[i]+nums[leftP]+nums[rightP]==0){
                
               result.add(List.of(nums[i],nums[leftP],nums[rightP]));
             
               //avoid duṕlicates
              while(leftP<rightP&&nums[leftP]==nums[leftP+1]){
                   leftP++;
               }
               while(leftP<rightP&&nums[rightP]==nums[rightP-1]){
                   rightP--;
               }
                 rightP--;
               leftP++;
              
             }   
            else if(nums[i]+nums[leftP]+nums[rightP]>0){
                 rightP--;
                 
             }  
            
                
            else{
                 leftP++;
                 
             } 
            }           
        }
     
      return result;  
    }
}