using System;
namespace Abbreviating_the_Product_of_a_Range
{
    public class Solution
    {
        public Solution()
        {
        }

        public string AbbreviateProduct(int left, int right)
        {
            long lProduct = 1;
            long rProduct = 1;
            int c = 0;

            do
            {
                lProduct *= left;
                rProduct *= right;
                //Console.WriteLine($"The product of lProduct @{left}: {lProduct},  rProduct @{right}: {rProduct}\n");
                left++;
                right--;
                while (lProduct % 10 == 0)
                {
                    c++;
                    lProduct /= 10;
                }
                while (rProduct % 10 == 0)
                {
                    c++;
                    rProduct /= 10;
                }
            } while (left < right);

            right++;

            //Console.WriteLine($"Check additional multiplication: {(left < right ? left : "N/A")}\n");

            long totalProduct = lProduct * rProduct * (left < right ? left : 1);
            while (totalProduct % 10 == 0)
            {
                c++;
                totalProduct /= 10;
            }

            //Console.WriteLine($"The product of {left} to {right} is: {totalProduct}\n");

            string result = totalProduct.ToString();

            // Only abbre. when the final result is greater than 10 digit, else return as it is
            if (result.Length > 10)
                result = result.Substring(0, 5) + "..." + result.Substring(result.Length - 5);

            return result + "e" + c;
        }
    }
}

