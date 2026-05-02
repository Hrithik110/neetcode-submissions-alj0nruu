public class Solution {
    public int NumIslands(char[][] grid) {
        var visit = new HashSet<(int row, int col)>();
        var islands = 0;
        for(int i = 0; i<grid.Length; i++){
            for(int j = 0; j<grid[0].Length; j++){
                if(grid[i][j] == '1' && !visit.Contains((i,j))){
                    BFS(grid, visit, i, j);
                    islands++;
                }
            }
        }

        return islands;
    }

    public void BFS(char[][] grid,HashSet<(int row, int col)> visit, int row, int col){
        var queue = new Queue<(int row, int col)>();

        visit.Add((row, col));

        queue.Enqueue((row, col));


        while(queue.Count > 0){
            var pos = queue.Dequeue();

           (int dx, int dy)[] directions = {
                (1, 0),   // down
                (-1, 0),  // up
                (0, 1),   // right
                (0, -1)   // left
            };

            foreach(var (dx, dy) in directions){
                int r = pos.row+dx;
                int c = pos.col+dy;

                if(r<grid.Length && r >= 0 && c<grid[0].Length && c>=0 && grid[r][c] == '1' && !visit.Contains((r, c))){
                    queue.Enqueue((r,c));
                    visit.Add((r,c));
                }
            }

        }


    }
}
