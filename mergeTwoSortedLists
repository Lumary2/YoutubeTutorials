
  //Definition for singly-linked list.
/*  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
         this.next = next;
      }
  }*/
 
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
     
            if(l1==null){
            return l2;
        }
        if(l2==null){
            return l1;
        }
        
        //we need two ListNodes, one for the return value and one
        //for creating the list, because at the end of the list creation
        //the runner Node will be at the end of the list.
        ListNode mergedList= new ListNode();
        ListNode runnerMergedList=mergedList;

        while(l1!=null&&l2!=null){
  
            if(l1.val<=l2.val){
                
                runnerMergedList.next=new ListNode(l1.val,null);
                runnerMergedList=runnerMergedList.next;
                
                l1=l1.next;
               
            }
            if(l1!=null&&l1.val>l2.val){
            
                runnerMergedList.next=new ListNode(l2.val,null);
                runnerMergedList=runnerMergedList.next;
               
                l2=l2.next;
              
            }
           
        }
        
        //at the end there might be nodes of one list left,
        //so we need to attach these as well.
        while(l2!=null){
             runnerMergedList.next=new ListNode(l2.val,null);
                runnerMergedList=runnerMergedList.next;
               
                l2=l2.next;
            
        }
           while(l1!=null){
                              
                runnerMergedList.next=new ListNode(l1.val,null);
                runnerMergedList=runnerMergedList.next;
                
                l1=l1.next;
               
            }
   
         return mergedList.next;
    }
        
}

