﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VehicleType
    {
        [Key]
        //[Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        //public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<MaterialTypeOrder> MaterialTypeOrder { get; set; }

    }
}
