using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Orders of the items are recorded and checks how much
/// of each of the products are desired.
/// </summary>
namespace CofffeeLovers.Models
{
    public class OrderItems
    {
        /// <summary>
        /// Total price of the items together.
        /// </summary>
        [DisplayName("Price"), Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Get multiple of an item.
        /// </summary>
        [DisplayName("Quantity"), Required, Range(minimum: 1, maximum: 6)]
        public int Quantity { get; set; }
    }
}