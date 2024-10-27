public class MaxSubArrayOrderN3 
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSum=int.MinValue; int currsum=int.MinValue;
    	for(int i=0;i<nums.Length;i++)
    	{
    		for(int j=i;j<nums.Length;j++)
    		{
    			currsum=0;
                for(int k=i;k<=j;k++)
    			{
    				currsum+=nums[k];
                    maxSum=Math.Max(currsum,maxSum);

    			}
    		}

    	}     
        return maxSum;        
    }
}


public class MaxSubArrayOrderN2
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSum=int.MinValue; int currsum=int.MinValue;
    	for(int i=0;i<nums.Length;i++)
    	{
    		for(int j=i;j<nums.Length;j++)
    		{
    			currsum=0;
                for(int k=i;k<=j;k++)
    			{
    				currsum+=nums[k];
                    maxSum=Math.Max(currsum,maxSum);

    			}
    		}

    	}     
        return maxSum;        
    }
}


public class MaxSubArrayOrderN
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSum=int.MinValue; int currsum=int.MinValue;
    	for(int i=0;i<nums.Length;i++)
    	{
    		for(int j=i;j<nums.Length;j++)
    		{
    			currsum=0;
                for(int k=i;k<=j;k++)
    			{
    				currsum+=nums[k];
                    maxSum=Math.Max(currsum,maxSum);

    			}
    		}

    	}     
        return maxSum;        
    }
}