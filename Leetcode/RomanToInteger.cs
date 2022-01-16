public class Solution {
    public int RomanToInt(string s) {

        Dictionary<string,int>dict=new Dictionary<string,int>(){
            
            {"I",1},
            {"V",5},
            {"X",10},
            {"L",50},
            {"C",100},
            {"D",500},
            {"M",1000}
            
        };
        
        int result=0;
        int potToSubstractNumber=0;
      
        //read string from right to left.because this is how we
        //calculate in maths, adding the rightmost numbers first.
       for(int i=s.Length-1;i>=0;i--){
           
           int convertedNumber=dict[s[i].ToString()];
           //Console.WriteLine(convertedNumber);
           if(i<s.Length-1&&convertedNumber<dict[s[i+1].ToString()]){
                 
              result-=convertedNumber;
           }
           else{
           result+=convertedNumber;
           }
           Console.WriteLine(result);
       }


        return result;
   
    }
}
