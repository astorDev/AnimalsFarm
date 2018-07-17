using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalFarm.Domain.Animals;

namespace AnimalFarm.UI.V1.Models
{
	public class ElephantViewModel : AnimalViewModel
	{
		public double TrunkLength { get; set; }
		public string ColorName { get; set; }

		public ElephantViewModel() : base()
		{
		}

		internal ElephantViewModel(IElephant elephant) : base(elephant)
		{
			this.TrunkLength = elephant.TrunkLength;
			this.ColorName = this.GetColorName(elephant.Color);
		}

		private string GetColorName(ElephantColor color)
		{
			switch (color)
			{
				case ElephantColor.White:
					return "white";
				case ElephantColor.Pink:
					return "pink";
				case ElephantColor.Grey:
					return "grey";
				default:
					return "colorless";
			}
		}
	}
}
