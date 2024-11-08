// NOTE: You cannot overload the assignment operator in C# like you can in other languages like C++

// When you do the following... nothing works due to setter and getter
var creature = new Creature();
creature.Agility = 5;
creature.Agility = 5;
creature.Agility = new Property<int>(20);
creature.Agility = new Property<int>(20);

// you essentially are going to do this -> creature.Agility = new Property<int>(10)
// Since we have implemented the implicit conversion this way.
// This means that our Property Value Setter 'if condition' will not work.
// If we create a new Property<T> and compare it to the existing value T stored in a Property:
// if (Equals(this.value, value)) return;
// They will be considered unequal, and not the same. one will be an int, and the other will be a new Property<int>, thus the check will not function properly.
// To get the behavior we want, the Agility Property will have to be setup Differently.
// Once it is setup our property proxy will work as it is supposed to.
// It will be comparing the actual Values, and it will assign a new one if it is not the same as the previous one.

// The way the setter and getter is setup here works with either an int or a Property<int>
var propperCreature = new PropperCreature();
propperCreature.Agility = 15;
propperCreature.Agility = 15;
propperCreature.Agility = new Property<int>(10);
propperCreature.Agility = new Property<int>(10);