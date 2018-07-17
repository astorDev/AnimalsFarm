using AnimalFarm.Domain.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.UI.V1.Models
{
    public class AnimalViewModel
    {
		public string Description { get; set; }

		public AnimalViewModel()
		{
		}

		internal AnimalViewModel(IAnimal animal)
		{
			this.Description = $"This is {animal.Name} he is {animal.Age} years old";
		}
    }
}
