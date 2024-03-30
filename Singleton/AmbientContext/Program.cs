using AmbientContext;

var house = new Building();

// gnd floor
using(new BuildingContext(3000))
{
house.Walls.Add(new Wall(new Point(0,0), new Point(5000,0)));
house.Walls.Add(new Wall(new Point(0,0), new Point(0,4000)));

    // 1st floor
    using (new BuildingContext(3500))
    {
        house.Walls.Add(new Wall(new Point(0, 0), new Point(6000, 0)));
        house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
    }

// gnd floor
house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
}

Console.WriteLine(house);