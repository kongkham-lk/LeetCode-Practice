using System;
namespace Abbreviating_the_Product_of_a_Range
{
    public class Solution
    {
        public Solution()
        {
        }

        public string AbbreviateProduct_InitialImplement(int left, int right)
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


        public string AbbreviateProduct_Optimized(int left, int right)
        {
            // need to have 2 variable to solve this problem
            // since the greater the number, the longer it will take to do the multiplication
            double pref = 1.0; // limit to 1 digit, Fast but not precise due to Double's floating point rounding error
            long suff = 1; // for removing zero and limit digits amount 10^14 (the acceptable size of int64)

            int totalDigit = 0;
            int zeroTrailing = 0;

            for (int i = left; i <= right; i++)
            {
                pref *= i;
                suff *= i;
                while (pref >= 1.0) // checking the new value's total digit
                {
                    pref /= 10.0;
                    totalDigit++; // keep the number of total digit up-to-date and reduce the actual value to 1 digit
                }
                while (suff % 10 == 0) // checking trailing zero
                {
                    suff /= 10;
                    zeroTrailing++; // remove trailing zero while memorize it
                }
                if (suff > Math.Pow(10, 14))
                    suff = suff % (long)Math.Pow(10, 14); // need to convert Math.Pow() to Long first before do the mod opearation, else return wrong value
            }

            string result = "";

            if (totalDigit - zeroTrailing > 10)
                result = (int)(pref * Math.Pow(10, 5)) + "..." + suff.ToString().Substring(suff.ToString().Length - 5); // the suff need to use SubString() only, since it somehow fail to display the last five digit when using mod operator.
            else
                result = (long)(pref * Math.Pow(10, totalDigit - zeroTrailing) + 0.5) + ""; // need to increment 0.5 due to the imprecision of Doubles that cause by floating point rounding errors.

            return result + "e" + zeroTrailing;
        }
    }
}

