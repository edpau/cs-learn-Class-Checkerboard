namespace Boards
{
    class Board
    {
        private int[,] checkers;
        private int rows;
        private int columns;
        public int Rows { get { return rows; } set { rows = value; } }
        public int Columns { get { return columns; } set { SetColumns(value); } }

        public Board()
        {
            rows = 0;
            columns = 0;
        }

        public Board(int r, int c)
        {
            rows = r;
            SetColumns(c);
            Setup();
        }

        private void SetColumns(int value)
        {
            if (value % 2 == 1)
            {
                Console.WriteLine($"{value} is not a valid number of columns. Columns must be even");
            }
            else
            {
                columns = value;
            }

        }
        public void Setup()
        {
            if (columns > 0)
            {
                checkers = new int[rows, columns];
                bool squareValue = true;
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        checkers[r, c] = Convert.ToInt32(squareValue);
                        squareValue = !squareValue;
                    }
                    squareValue = !squareValue;
                }
            }
        }

        public void Print()
        {
            if (checkers != null)
            {
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        Console.Write($"{checkers[r, c]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}