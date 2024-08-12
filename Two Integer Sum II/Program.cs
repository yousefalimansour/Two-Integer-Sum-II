namespace Two_Integer_Sum_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15, 14 };
            int target = 9;
            foreach (int x in TwoSum(nums, target)) 
            {
                Console.WriteLine(x);
            }
        }
            public static int[] TwoSum(int[] numbers, int target)
        {
            int pointer1 = 0;
            int pointer2 = numbers.Length - 1;
            Array.Sort(numbers);

            while (pointer1 < pointer2)
            {
                if (numbers[pointer1] + numbers[pointer2] == target) break;
                else if (numbers[pointer2] + numbers[pointer1] < target) pointer1++;
                else if (numbers[pointer2] + numbers[pointer1] > target) pointer2--;
            }
            return new int[] { pointer1 + 1, pointer2 + 1 };
        }
    }
}
