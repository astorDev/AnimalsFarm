using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFarm.UI.V2.Models
{
    public class HomeViewModel
    {
		public IEnumerable<ParrotViewModel> Parrots { get; set; }
		public IEnumerable<ElephantViewModel> Elephants { get; set; }
    }
}
