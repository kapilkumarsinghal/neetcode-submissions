public class Solution {
    public bool IsValidSudoku(char[][] board) {

        for(int i=0; i<9; i++){
            HashSet<char> rows = new HashSet<char>();
            for(int j=0; j< 9; j++){
                if(board[i][j]=='.') continue;
                if(rows.Contains(board[i][j])) return false;
                rows.Add(board[i][j]);
            }

            HashSet<char> cols = new HashSet<char>();
            for(int k=0; k < 9; k++){
                if(board[k][i]=='.') continue;
                if(cols.Contains(board[k][i])) return false;
                cols.Add(board[k][i]);
            }
        }

        for(int row = 0; row< 9; row+=3){
            for(int col = 0; col< 9; col+=3){
                HashSet<char> box = new HashSet<char>();
                for(int r = row; r< row+3; r++){
                    for(int c = col; c< col+3; c++){
                        if(board[r][c] == '.') continue;
                        if(box.Contains(board[r][c])) return false;
                        box.Add(board[r][c]);
                    }
                }
            }
        }
        return true;
    }
}
