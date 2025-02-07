﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaenx.DataContext.Catalog
{
    public class AppComObjectRef
    {
        [Key]
        [MaxLength(255)]
        public string Id { get; set; }
        public string RefId { get; set; }

        public string Text { get; set; }
        public string FunctionText { get; set; }

        public bool? Flag_Read { get; set; }
        public bool? Flag_Write { get; set; }
        public bool? Flag_Communicate { get; set; }
        public bool? Flag_Transmit { get; set; }
        public bool? Flag_ReadOnInit { get; set; }
        public bool? Flag_Update { get; set; }

        public int Number { get; set; }
        public int Size { get; set; }
        public int Datapoint { get; set; }
        public int DatapointSub { get; set; }

        public void SetSize(string size)
        {
            if (size == null)
            {
                Size = -1;
                return;
            }
            string[] splitted = size.Split(' ');
            int i = int.Parse(splitted[0]);
            int m = (splitted[1] == "Byte") ? 8 : 1;
            Size = i * m;
        }

        public void SetDatapoint(string dp)
        {
            if (dp == null || dp == "")
            {
                Datapoint = -1;
                DatapointSub = -1;
                return;
            }

            if (dp.Contains(" "))
                dp = dp.Substring(0, dp.IndexOf(' '));

            string[] splitted = dp.Split('-');

            if (splitted[0] == "DPT")
            {
                Datapoint = int.Parse(splitted[1]);
                DatapointSub = -1;
            }
            else
            {
                Datapoint = int.Parse(splitted[1]);
                DatapointSub = int.Parse(splitted[2]);
            }
        }
    }
}
