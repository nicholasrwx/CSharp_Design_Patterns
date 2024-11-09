// Array of Structures ( AoS )
var creatures = new Creature[100];

foreach (var creature in creatures)
{
    creature.X++;
}

// Structure of Arrays ( SoA )
var moreCreatures = new Creatures(100);

// This foreach works because we added a GetEnumerator() method in Creatures which yield returns a CreatureProxy
foreach (Creatures.CreatureProxy creature in moreCreatures)
{
    creature.X++;
}