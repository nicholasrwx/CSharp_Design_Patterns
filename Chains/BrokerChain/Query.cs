namespace BrokerChain;

// command query separation is being used here

public class Query
{
public string CreatureName;

public enum Argument
{
  Attack, Defense
}

public Argument WhatToQuery;

public int Value; // bidirectional

public Query(string creatureName, Argument whatToQuery, int value)
{
  CreatureName = creatureName ?? throw new ArgumentNullException(paramName: nameof(creatureName));
  WhatToQuery = whatToQuery;
  Value = value;
}
}