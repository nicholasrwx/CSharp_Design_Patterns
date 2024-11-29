namespace MethodChain;

public class NoBonusesModifier : CreatureModifier
{
  public NoBonusesModifier(Creature creature) : base(creature)
  {
  }

  public override void Handle()
  {
    // nothing
    WriteLine("No bonuses for you!");
  }
}