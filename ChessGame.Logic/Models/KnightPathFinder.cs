namespace ChessGame.Logic.Services;

public static class KnightPathFinder
{
    private static readonly int[] RowOffsets = { -2, -2, -1, -1, 1, 1, 2, 2 };
    private static readonly int[] ColOffsets = { -1, 1, -2, 2, -2, 2, -1, 1 };

    public static List<Coordinate> FindShortestPath(Coordinate start, Coordinate target)
    {
        Queue<Coordinate> queue = new Queue<Coordinate>();
        Dictionary<Coordinate, int> visited = new Dictionary<Coordinate, int>();
        Dictionary<Coordinate, Coordinate> previous = new Dictionary<Coordinate, Coordinate>();

        queue.Enqueue(start);
        visited[start] = 0;

        while (queue.Count > 0)
        {
            Coordinate current = queue.Dequeue();

            if (current.Row == target.Row && current.Col == target.Col)
            {
                return BuildPath(previous, start, target);
            }

            for (int i = 0; i < 8; i++)
            {
                int newRow = current.Row + RowOffsets[i];
                int newCol = current.Col + ColOffsets[i];

                if (newRow < 0 || newRow > 7 || newCol < 0 || newCol > 7)
                    continue;

                Coordinate next = Coordinate.FromRowCol(newRow, newCol);

                if (visited.ContainsKey(next))
                    continue;

                visited[next] = visited[current] + 1;
                previous[next] = current;
                queue.Enqueue(next);
            }
        }

        return new List<Coordinate>();
    }

    private static List<Coordinate> BuildPath(Dictionary<Coordinate, Coordinate> previous, Coordinate start, Coordinate target)
    {
        List<Coordinate> path = new List<Coordinate>();
        Coordinate current = target;

        path.Add(current);

        while (current.Row != start.Row || current.Col != start.Col)
        {
            current = previous[current];
            path.Add(current);
        }

        path.Reverse();
        return path;
    }
}