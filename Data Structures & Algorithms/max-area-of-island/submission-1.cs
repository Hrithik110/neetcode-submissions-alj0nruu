public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var visit = new HashSet<(int row, int col)>();
        int maxArea = 0;
        for(int i = 0; i<grid.Length; i++){
            for(int j = 0; j<grid[0].Length; j++){
                if(grid[i][j] == 1 && !visit.Contains((i, j))){
                    int area = DFS(grid, visit, i, j);
                    maxArea = Math.Max(area, maxArea);
                }
            }
        }

        return maxArea;
    }


    public int BFS(int[][] grid, HashSet<(int row, int col)> visit, int row, int col){

        var queue = new Queue<(int row, int col)>();

        visit.Add((row, col));
        queue.Enqueue((row, col));
        int count = 1;
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

                if(r<grid.Length && r >= 0 && c<grid[0].Length && c>=0 && grid[r][c] == 1 && !visit.Contains((r, c))){
                    queue.Enqueue((r,c));
                    visit.Add((r,c));
                    count++;
                }
            }
        }

        return count;
    }

    public int DFS(int[][] grid, HashSet<(int, int)> visited, int row, int col) {
    if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length ||
        grid[row][col] == 0 || visited.Contains((row, col))) return 0;

    visited.Add((row, col));
    int area = 1;
    (int dx, int dy)[] directions = {
                (1, 0),   // down
                (-1, 0),  // up
                (0, 1),   // right
                (0, -1)   // left
            };
    foreach (var (dx, dy) in directions) {
        area += DFS(grid, visited, row + dx, col + dy);
    }
    return area;
}

}
