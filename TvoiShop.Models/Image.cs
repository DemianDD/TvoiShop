﻿using Reinforced.Typings.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace TvoiShop.Models
{
    [TsInterface(IncludeNamespace = false)]
    public class Image
    {
        [TsProperty(Type = "string")]
        public Guid Id { get; set; }
        public string Url { get; set; }
    }
}
