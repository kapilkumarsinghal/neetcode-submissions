public class Solution { 
    public bool notInRow(char[][] arr, int row){
        HashSet<char> map= new HashSet<char>();
        for(int i=0;i<9;i++){
            if(map.Contains(arr[row][i])){
                return false;
            }
            if(arr[row][i]!='.'){
                map.Add(arr[row][i]);
            }
        }
        return true;
    }
    public bool notInCol(char[][] arr, int col){
        HashSet<char> map= new HashSet<char>();
        for(int i=0;i<9;i++){
            if(map.Contains(arr[i][col])){
                return false;
            }
            if(arr[i][col] !='.'){
                map.Add(arr[i][col]);
            }
        }
        return true;

    }
    public bool notInSquare(char[][] arr,int startRow,int startCol){
        HashSet<char> map = new HashSet<char>();
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                char curr = arr[i+startRow][j+startCol];
                if(map.Contains(curr)){
                    return false;
                }
                if(curr !='.'){
                    map.Add(curr);
                }
            }
        }
        return true;
    }

    public bool isValid(char[][] arr, int row, int col){
        return notInRow(arr,row) && notInCol(arr,col) && 
        notInSquare(arr,row - row%3,col - col%3);
        
    } 
    public bool IsValidSudoku(char[][] board) {
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if (!isValid(board, i, j))
                return false;
            }
        }
        return true;
    }
}
