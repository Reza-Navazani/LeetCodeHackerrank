/*
135. Candy
There are n children standing in a line. Each child is assigned a rating value given in the integer array ratings.
You are giving candies to these children subjected to the following requirements:
Each child must have at least one candy.
Children with a higher rating get more candies than their neighbors.

*/
public class Solution
{
    public int Candy(int[] ratings)
    {

        int[] candies = new int[ratings.Length];
        for (int i = 0; i < candies.Length; i++)
        {
            candies[i] = 1;
        }
        int total = 0;
        // int current = 1;
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }

        }

        for (int i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }
        for (int i = 0; i < candies.Length; i++)
        {
            total += candies[i];
        }

        return total;
    }
    
    public void Main1()
    {
        Candy([1,0,2]);
    }

}
