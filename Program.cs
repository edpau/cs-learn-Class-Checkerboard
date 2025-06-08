using Boards;

namespace Checkerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(6,5);
            // board.Rows = 6;
            // board.Columns = 5;
            // board.Setup();
            board.Print();
        }
    }
}