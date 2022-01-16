public class Solution {
    public bool IsValid(string s) {        
        
       Stack stack=new Stack();
               
        foreach(char c in s){
            
            if(c=='('){
                stack.Push(c);
              
            }
            else if(c=='['){
                stack.Push(c);
               
            }
            else if(c=='{'){
                stack.Push(c);
               
            }
            
            if(stack.Count==0){
                   return false;
               }
            
           else if(c==')'){
                            
                if(stack.Peek().ToString()=="("){
                                       stack.Pop();

                }
                 else
                     return false;
                              
            }
             else if(c=='}'){
                                
                if(stack.Peek().ToString()=="{"){
                                       stack.Pop();
                }
                 else
                     return false;
                            
            }
           else if(c==']'){
             
               
                if(stack.Peek().ToString()=="["){
                                       stack.Pop();

                }
                 else
                     return false;
                             
            }
            
        }
        if(stack.Count!=0){
            return false;
        }
        
        return true;
        
    }
}
