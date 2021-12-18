using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// The supplier and their contact details are recorded.
/// </summary>
namespace CofffeeLovers.Models
{
    public class Supplier
    {
        /// <summary>
        /// Supplier's company name.
        /// </summary>
        [DisplayName("Company name"), Required, StringLength(maximumLength: 15)]
        public String Name { get; set; }

        /// <summary>
        /// Phone number for the supplier.
        /// </summary>
        [DisplayName("Phone number"), Required, StringLength(maximumLength: 10)]
        public int Contact { get; set; }

        /// <summary>
        /// Email address for the supplier.
        /// </summary>
        [DisplayName("Email"), Required, StringLength(maximumLength: 30)]
        public String Email { get; set; }
    }
}