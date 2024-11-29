namespace MethodChain;

public class IncreaseDefenseModifier : CreatureModifier
{
  public IncreaseDefenseModifier(Creature creature) : base(creature)
  {
  }

  public override void Handle()
  {
    WriteLine("Increasing goblin's defense");
    creature.Defense += 3;
    base.Handle();
  }
}
