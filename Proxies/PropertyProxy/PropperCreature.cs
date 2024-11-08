namespace PropertyProxy;

public class PropperCreature
{
    private Property<int> agility = new Property<int>();

    public int Agility
    {
        get => agility.Value;
        set => agility.Value = value;
    }
}