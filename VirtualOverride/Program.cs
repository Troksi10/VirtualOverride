using VirtualOverride;

Dog dog = new Dog("Sarko", 12);
Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
dog.MakeSound();
dog.Play();
dog.Eat();

Console.ReadLine();