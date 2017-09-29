using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required] // Validation - makes a field required
        [Display(Name = "Cheese Name")] // Customize how Name property is displayed in View
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")] // Make field required AND specify error message displayed
        public string Description { get; set; }
    }
}
