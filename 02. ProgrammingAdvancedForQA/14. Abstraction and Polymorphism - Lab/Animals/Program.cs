﻿using System;

using Animals.Models;

Animal cat = new Cat("Peter", "Whiskas");
Animal dog = new Dog("George", "Meat");

Console.WriteLine(cat.ExplainSelf());
Console.WriteLine(dog.ExplainSelf());
