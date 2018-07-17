using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Domain.Animals
{
    public interface IParrot : IAnimal
    {
		bool CanSpeak { get; }
    }
}
