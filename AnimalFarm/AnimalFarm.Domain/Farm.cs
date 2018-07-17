using System;
using System.Collections.Generic;
using System.Text;
using AnimalFarm.Domain.Animals;

namespace AnimalFarm.Domain
{
	public class Farm : IFarm
	{
		public bool IsOpen => true;

		public IEnumerable<IElephant> GetAllElephants()
		{
			return new[] 
			{
				new Elephant {Name = "Baboo", Age = 9, TrunkLength = 15, Color = ElephantColor.White},
				new Elephant {Name = "Max", Age = 10, TrunkLength = 30, Color = ElephantColor.Pink}
			};
		}

		public IEnumerable<IParrot> GetAllParrots()
		{
			return new[] 
			{
				new Parrot {Name = "Kesha", Age = 7, CanSpeak = false},
				new Parrot {Name = "Alex", Age = 13, CanSpeak = true}
			};
		}

		private class Animal
		{
			public string Name { get; set; }
			public int Age { get; set; }
		}

		private class Elephant :  Animal, IElephant
		{
			public double TrunkLength { get; set; }
			public ElephantColor Color { get; set; }
		}

		private class Parrot : Animal, IParrot
		{
			public bool CanSpeak { get; set; }
		}
	}
}
