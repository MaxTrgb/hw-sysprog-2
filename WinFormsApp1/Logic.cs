using System.Text.Json;

namespace WinFormsApp1
{
    public static class Logic
    {
        public static void generateNums(int[] nums, Random rnd, ListBox listBox1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next();
            }
            for (int i = 0; i < nums.Length; i++)
            {
                listBox1.Items.Add(nums[i]);
            }

        }
        public static int maxNum(int[] nums)
        {
            int max = 0;
            Thread thread = new Thread(() =>
            {
                max = nums.Max();
            });
            thread.Start();
            thread.Join();
            return max;
        }

        public static int minNum(int[] nums)
        {
            int min = 0;
            Thread thread = new Thread(() =>
            {
                min = nums.Min();
            });
            thread.Start();
            thread.Join();
            return min;
        }

        public static double meanNum(int[] nums)
        {
            double mean = 0;
            Thread thread = new Thread(() =>
            {
                mean = nums.Average();
            });
            thread.Start();
            thread.Join();
            return mean;
        }

        public static void writeFile(CountingResults countingResults)
        {
            string fileName = "CountingResults";
            string filePath = $"..\\..\\{fileName}";

            using (FileStream file = new FileStream($"..\\..\\{filePath}.json", FileMode.Create))
            {
                JsonSerializer.Serialize(file, countingResults);
            }
        }
    }
}