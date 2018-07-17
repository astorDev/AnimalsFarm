using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Domain.Animals
{
    public interface IElephant : IAnimal
    {
		double TrunkLength { get; }
		ElephantColor Color { get; }
	}

	public enum ElephantColor
	{
		White, Pink, Grey
	}
}
