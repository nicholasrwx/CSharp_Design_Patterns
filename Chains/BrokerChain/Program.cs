var game = new Game();
var goblin = new Creature(game, "Strong Goblin", 3, 3);
WriteLine(goblin);

using (new DoubleAttackModifier(game, goblin))
{
  WriteLine(goblin);
  using (new IncreaseDefenseModifier(game, goblin))
  {
    WriteLine(goblin);
  }
}

WriteLine(goblin);
