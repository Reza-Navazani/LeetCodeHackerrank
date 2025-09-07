/*27. Remove Element
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. 
Then return the number of elements in nums which are not equal to val.
Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
The remaining elements of nums are not important as well as the size of nums.
Return k.
*/
public class Solution21
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var ltot = m + n - 1;
        var lm = m - 1;
        var ln = n - 1;


        while (ln >= 0)
        {
            if (lm >= 0 && nums1[lm] > nums2[ln])
                nums1[ltot--] = nums1[lm--];
            else
                nums1[ltot--] = nums2[ln--];
        }
    }
}

