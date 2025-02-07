﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaenx.DataContext.Catalog
{
    public class AppParameterTypeViewModel
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }
        [MaxLength(18)]
        public string ApplicationId { get; set; }
        public ParamTypes Type { get; set; }
        public int Size { get; set; }
        [MaxLength(100)]
        public string Tag1 { get; set; }
        [MaxLength(100)]
        public string Tag2 { get; set; }
    }

    public enum ParamTypes
    {
        Text,
        Enum,
        NumberUInt,
        NumberInt,
        Float9,
        Picture,
        None,
        IpAdress,
        Color,
        CheckBox
    }
}
