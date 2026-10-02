public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            //Console.WriteLine("Mid is {0}{1}{2}",mid,left,right);
            if (nums[mid] == target) { 
                return mid;
            }
            if (nums[mid] > target) {
                right = mid - 1;
            }
            else{
                left = mid + 1;
            }
        }


        return -1;
    }
}
