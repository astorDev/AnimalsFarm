using AnimalFarm.Domain.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.UI.V1.Models
{
    public class ParrotViewModel : AnimalViewModel
    {
		public string SpeakingAbility { get; set; }

		public ParrotViewModel() { }

		internal ParrotViewModel(IParrot parrot) : base(parrot)
		{
			this.SpeakingAbility = parrot.CanSpeak ? "can speak" : "cannot speak";
		}
    }
}
