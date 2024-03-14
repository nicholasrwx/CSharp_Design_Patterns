public class Person : IDeepCopyable<Person>
{
    public string[] Names;
    public Address Address;

    public Person()
    {

    }

    public Person(string[] names, Address address)
    {
        Names = names;
        Address = address;
    }

    public void CopyTo(Person target)
    {
        target.Names = (string[]) Names.Clone();
        target.Address = ((IDeepCopyable<Address>)Address).DeepCopy(); // broken ( for now )
    }

    //  public Person DeepCopy()
    //  {
    //      return new Person((string[]) Names.Clone(), Address.DeepCopy());
    //  }

    public override string ToString()
    {
        return $"{nameof(Names)}: {string.Join(", ", Names)} " +
               $"{nameof(Address)}: {Address}";
    }
}