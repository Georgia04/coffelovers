using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// When an order has been made, we get the ID of the order,
/// and then the details on where it needs to be taken.
/// </summary>
namespace CofffeeLovers.Models
{
    public class Order
    {
        /// <summary>
        /// Gives a unique ID for the order.
        /// </summary>
        [Key, DisplayName("Order ID"), Required, Range(minimum: 1, maximum: 100)]
        public int ID { get; set; }

        /// <summary>
        /// Type a table to bring the items to.
        /// </summary>
        [DisplayName("Table number"), Required, Range(minimum: 1, maximum: 20)]
        public int TableNo { get; set; }

        /// <summary>
        /// Time when the order was recieved.
        /// </summary>
        [Required]
        public DateTime TimeRecieved { get; set; }

        /// <summary>
        /// When the order was bought to the customer.
        /// </summary>
        [Required]
        public DateTime Timestamp { get; set; }
    }
}