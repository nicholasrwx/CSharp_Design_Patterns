var goblin = new Creature("Goblin", 2, 2);
WriteLine(goblin);

var root = new CreatureModifier(goblin);

root.Add(new NoBonusesModifier(goblin));

WriteLine("Let's double goblin's attack...");
root.Add(new DoubleAttackModifier(goblin));

WriteLine("Let's increase goblin's defense");
root.Add(new IncreaseDefenseModifier(goblin));

// eventually...
root.Handle();
WriteLine(goblin);