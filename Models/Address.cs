using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


/// <summary>
/// This class records the address of the user so if there are any deliveries
/// are going to be made, we have the place we need to deliver to.
/// </summary>
namespace CofffeeLovers.Models
{
    public class Address
    {
        /// <summary>
        /// User's address ID is recorded.
        /// </summary>
        [DisplayName("Address ID"),Required, StringLength(maximumLength: 30)]
        public int AddressID { get; set; }

        /// <summary>
        /// Address one of the user.
        /// </summary>
        [DisplayName("Address one"), Required, StringLength(maximumLength: 30)]
        public string Line1Address { get; set; }

        /// <summary>
        /// User's city
        /// </summary>
        [DisplayName("City"), Required, StringLength(maximumLength: 15)]
        public string City { get; set; }

        /// <summary>
        /// User's address ID
        /// </summary>
        [DisplayName("Address ID"), StringLength(maximumLength: 30)]
        public string Line2Address { get; set; }

        /// <summary>
        /// Address 2 is optional in the case they need to have somewhere else.
        /// </summary>
        [DisplayName("Address 2"), StringLength(maximumLength: 30)]
        public int AddressID2 { get; set; }

        /// <summary>
        /// Postcode of the user.
        /// </summary>
        [DisplayName("Postcode"), Required, StringLength(maximumLength: 8)]
        public string Postcode { get; set; }
    }
}