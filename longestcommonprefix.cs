public class Solution {
    public string LongestCommonPrefix(string[] strs) {
               
        int minimum=strs[0].Length;
        string current=strs[0];
        string sameChars="";
        foreach(string s in strs){
            
            minimum=Math.Min(minimum, s.Length);
        }
        Console.WriteLine(minimum);
        
           
            for(int i=0;i<minimum;i++){
                
                foreach(string s in strs){
                if(current[i]!=s[i]){
                    
                    return sameChars;
                }
             
                }       
                sameChars+=current[i];
            }
              return sameChars; 
        }
        
     
    }
