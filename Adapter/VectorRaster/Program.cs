using VectorRaster;
using MoreLinq;
using static System.Console;

List<VectorObject> vectorObjects
        =
        [
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        ];

void DrawPoint(Point p)
{ 
    Write(".");
}

void Draw()
{
    foreach (var vo in vectorObjects)
    {
        foreach (var line in vo)
        {
            var adapter = new LineToPointAdapter(line);
            adapter.ForEach(DrawPoint);
            WriteLine("");
        }
    }
}

Draw();
Draw();
