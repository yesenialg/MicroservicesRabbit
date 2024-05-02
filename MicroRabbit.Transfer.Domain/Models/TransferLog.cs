﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal TransferAccount { get; set; }
    }
}
