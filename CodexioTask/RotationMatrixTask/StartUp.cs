namespace RotationMatrixTask
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int rotationCount = int.Parse(Console.ReadLine());

            int matrixRow = int.Parse(Console.ReadLine());
            int matrixCol = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixRow, matrixCol];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < rowInput.Length; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            for (int i = 0; i < rotationCount; i++)
            {
                matrix = RotateMatrix(matrix);
            }

            PrintMatrix(matrix);
        }

        public static int[,] RotateMatrix(int[,] currentMatrix)
        {
            var x = currentMatrix.GetLength(1);
            var y = currentMatrix.GetLength(0);
            var newMatrix = new int[x, y];
            var newRow = 0;

            for (var oldColumn = x - 1; oldColumn >= 0; oldColumn--)
            {
                for (var oldRow = 0; oldRow < y; oldRow++)
                {
                    newMatrix[newRow, oldRow] = currentMatrix[oldRow, oldColumn];
                }

                newRow++;
            }
            return newMatrix;
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