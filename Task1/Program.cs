namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums2 = { { 1, 2, 2, 4 }, { 3, 3, 7, 7 } };

            for (int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    Console.Write(nums2[i, j] + " ");
                }
            }
        }
    }
}