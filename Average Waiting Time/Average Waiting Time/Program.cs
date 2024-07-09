using Average_Waiting_Time;

int[][] customers = new int[][] { new int[]{ 1, 2 }, new int[] { 2, 5 }, new int[] { 4, 3 } };

Console.WriteLine($"\nAverage waiting time is: {new Solution().AverageWaitingTime(customers)}\n");
