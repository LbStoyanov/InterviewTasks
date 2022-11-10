namespace RotationMatrixTask
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int rotationCount = int.Parse(Console.ReadLine());

            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(col == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[row, col]);
                        continue;
                    }
                    Console.Write(matrix[row, col] + "_");

                }
                Console.WriteLine();
            }
        }
    }
}