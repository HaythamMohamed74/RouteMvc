﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Entities
{
    public class Department:BaseEntity
    {
        public string  Code { get; set; }
        public string  Name { get; set; }
        public string  Desc { get; set; }


    }
}
