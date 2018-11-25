namespace CSharp.Problems {
    class NQueens {

        public int[,] solve(int board_size) {
            int[,] board = new int[board_size, board_size];
            for(int i=0; i<board_size; i++)
                for (int j=0; j<board_size; j++)
                    board[i, j] = 0;
            return board;
        }

        public bool canPlaceAtPosition(int[,] board, int row, int col) {
            for(int i = 0; i < board.GetLength(0); i++) {
                if(board[i, col] == 1)
                    return false;
            }
            for(int j = 0; j < board.GetLength(1); j++) {
                if (board[row, j] == 1)
                    return false;
            }

            return true;
        }

        public void solveFromRow(int row, int[,] board) {
            if(row == (board.GetLength(0) - 1))
                return;
            

        }

    }
}