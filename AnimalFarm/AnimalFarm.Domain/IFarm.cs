using AnimalFarm.Domain.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Domain
{
    public interface IFarm
    {
		bool IsOpen { get; }

		IEnumerable<IParrot> GetAllParrots();
		IEnumerable<IElephant> GetAllElephants();
    }
}
