using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Domain.Animals
{
    public interface IAnimal
    {
		string Name { get; }
		int Age { get; }
    }
}
