﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kaenx.DataContext.Catalog
{
    public class Hardware2AppModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string HardwareId { get; set; }
        [MaxLength(18)]
        public string ApplicationId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int Version { get; set; }
        public int Number { get; set; }

        public string VersionString
        {
            get
            {
                int rest = Version % 16;
                int full = (Version - rest) / 16;
                return "V" + full.ToString() + "." + rest.ToString();
            }
        }
    }
}
