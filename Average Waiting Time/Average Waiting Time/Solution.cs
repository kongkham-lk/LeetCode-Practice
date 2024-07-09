using System;
namespace Average_Waiting_Time
{
	public class Solution
	{
		public Solution()
		{
		}

        public double AverageWaitingTime(int[][] customers)
        {
            double averageWaitingTime = 0;
            int prevCookTime = 0;

			for (int i = 0; i < customers.Length; i++)
			{
                prevCookTime = (prevCookTime > customers[i][0] ? prevCookTime : customers[i][0]) + customers[i][1];
                averageWaitingTime += prevCookTime - customers[i][0];

                Console.WriteLine($"customer {i + 1} wait time: {averageWaitingTime}");
            }

            return averageWaitingTime / customers.Length;
        }
    }
}

