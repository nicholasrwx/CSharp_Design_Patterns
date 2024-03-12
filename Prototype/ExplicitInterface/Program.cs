﻿var Billy = new DeepCopyPerson(new[] { "Billy", "James" }, new DeepCopyAddress("Granville Street", 798));
Console.WriteLine(Billy.ToString());

// Using an explicit deep copy interface
// this allows us to explicitly declare the type we want to return
var Perrin = Billy.DeepCopy();

// Updating params doesn't alter original object ( Billy )
Perrin.Address.HouseNumber = 20;
Perrin.Address.StreetName = "Corbin Street";
Perrin.Names = new[] { "Perrin", "Jorgen" };

Console.WriteLine(Perrin.ToString());
