public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if(h==piles.Length){
            return piles.Max();
        }
        // int resSum = 0;
        // for(int i=0;i<piles.Length;i++){
        //     resSum += piles[i];
        // }
        // int k = resSum/h +1;
        // return k;
        int l=1;
        int r = piles.Max();
        int res =r;

        while(l<=r){
            int k = (l+r)/2;
            int totalTime =0;
            foreach(int p in piles){
                totalTime += (int)Math.Ceiling((double)p/k);
            }
            if(totalTime <=h ){
                res=k;
                r= k-1;
            }
            else{
                l = k+1;
            }
        }
        return res;
             
        

    }
}
