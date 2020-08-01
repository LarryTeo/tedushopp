﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [Column(TypeName =("varchar"))]
        [MaxLength(50)]
        public string Code { set; get; }
        [MaxLength(50)]
        public string ValueString { set; get; }
        public int? ValueInt { set; get; }
    }
}
