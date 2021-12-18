using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Creates the base to create a product. This is then going to be
/// bought by users and ordered.
/// </summary>
namespace CofffeeLovers.Models
{
    public class Products
    {
        /// <summary>
        /// Enumeration of catergories of food and drinks.
        /// </summary>
        public enum Catergories {Toastie, Coffee, Tea, Dessert, Crisps,}

        /// <summary>
        /// The name of the product.
        /// </summary>
        [DisplayName("Product name"), Required, StringLength(maximumLength: 20)]
        public string ProductName { get; set; }

        /// <summary>
        /// Description of the product
        /// </summary>
        [DisplayName("Description"), Required]
        public string Description { get; set; }

        /// <summary>
        /// Sets the coloumn.
        /// </summary>
        [Required]
        public int Column { get; set; }

        /// <summary>
        /// The price is set for the item.
        /// </summary>
        [DisplayName("Price"), Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Uses the enumeration for the user to change.
        /// </summary>
        [Required]
        public Catergories Catagory { get; set; } = Catergories.Tea;

        /// <summary>
        /// Supplier's ID is recorded for reference.
        /// </summary>
        [DisplayName("Supplier ID"), Required]
        public int SupplierID { get; set; }
    }
}