namespace VectorRaster
{
    public class Line(Point start, Point end)
    {
        public Point 
            Start = start ?? throw new ArgumentNullException(nameof(start)), 
            End = end ?? throw new ArgumentException(nameof(end));
    }
}
