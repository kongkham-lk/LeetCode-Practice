using System;
namespace Crawler_Log_Folder
{
    public class Solution
    {
        public int MinOperations(string[] logs)
        {
            int steps = 0;
            foreach (string log in logs)
            {
                if (log.Equals("../"))
                {
                    if (steps > 0)
                        steps--;
                }
                else if (!log.Equals("./"))
                {
                    steps++;
                }
            }
            return steps;
        }
    }
}

