﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftService.Models
{
    public class ProductBdo
    {
        public int Id { get; set; }

        public string ProductUid { get; set; }

        public int PosId { get; set; }

        /// <summary>
        /// UID of user, generated by POS
        /// </summary>
        public string PosUserUid { get; set; }

        /// <summary>
        /// UID to communicate with payment system
        /// </summary>
        public string PaySystemUid { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTill { get; set; }

        public decimal ProductPrice { get; set; }

        public string CurrencyCode { get; set; }
    }
}
