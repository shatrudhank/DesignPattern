﻿using DecoratorDesignPattern;


BasePizza basePizza = new Mushroom( new ExtraCheese( new FarmHouse()));

Console.WriteLine(basePizza.CalculatePrice());

Console.ReadLine();