class Solution {
    public List<List<int>> diagonal(List<List<int>> A) {
        int N = A.Count();
        List<List<int>> AntiDiagonals = new List<List<int>>();
        //1st row
        for(int i = N-1; i >= 0; i--){
            int j = 0;
            int k = N-1-i;
            List<int> inner = new List<int>();
            while(j < N && k >= 0){
                inner.Add(A[j][k]);
                j++;
                k--;
            }
            for(; j < N; j++){
                inner.Add(0);
            }
            AntiDiagonals.Add(inner);
        }
        //last column
        for(int i = 1; i < N; i++){
            int x = i;
            int y = N-1;
            List<int> inner = new List<int>();
            while(x < N && y >= 0){
                inner.Add(A[x][y]);
                x++;
                y--;
            }
            for(; y >= 0; y--){
                inner.Add(0);
            }
            AntiDiagonals.Add(inner);
        }
        
        return AntiDiagonals;
    }
}
