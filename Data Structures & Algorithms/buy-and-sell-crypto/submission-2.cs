public class Solution {
    public int MaxProfit(int[] prices) {
        int l= prices.Length;
        if(l<2) return 0;
        int[] arr= new int[l];
        int max1=prices[l-1];
        arr[l-1]=max1; 
        for(int i=l-2;i>0;i--){
            if(prices[i+1]>max1){
                max1= prices[i+1];
            }
            arr[i]= max1;
            //Console.WriteLine(prices[i]+" "+max1+" "+arr[i]);
        }
        if(prices[1]>max1){
            arr[0]= prices[1];
        }
        else{
            arr[0]= max1;
        }
        
        int res=0;
        for(int i=0;i<l;i++){
            Console.WriteLine(arr[i]+" "+prices[i]);
            if((arr[i]-prices[i])>res){
                res= arr[i]-prices[i];
            }
        }
        return res;
    }
}
